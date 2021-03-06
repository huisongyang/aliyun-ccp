import requests
import json
import time

from datetime import datetime
from Tea.request import TeaRequest
from Tea.core import TeaCore


class AccessTokenCredential():

    def __init__(self, config):
        self.__endpoint = config.endpoint
        self.__domain_id = config.domain_id
        self.__client_id = config.client_id
        self.__refresh_token = config.refresh_token
        self.__client_secret = config.client_secret
        self.__access_token = config.access_token
        self.__expire_time = config.expire_time

    def set_expire_time(self, expire_time):
        self.__expire_time = expire_time

    def get_expire_time(self):
        return self.__expire_time

    def get_refresh_token(self):
        return self.__refresh_token

    def set_refresh_token(self, refresh_token):
        self.__refresh_token = refresh_token

    def set_access_token(self, access_token):
        self.__access_token = access_token

    def get_access_token(self):
        if self.__access_token is None or self.__with_should_refresh():
            self.__refresh_access_token()

        return self.__access_token

    def __refresh_access_token(self):
        tea_request = TeaRequest()
        tea_request.protocol = "http"
        tea_request.set_method("POST")
        tea_request.pathname = "/v2/oauth/token"
        headers = {
            "host": self.__get_host(self.__endpoint, self.__domain_id + ".api.alicloudccp.com"),
            "content-type": "application/x-www-form-urlencoded; charset=utf-8",
            "date": datetime.utcnow().strftime('%a, %d %b %Y %H:%M:%S GMT'),
            "accept": "application/json",
            "x-acs-signature-method": "HMAC-SHA1",
            "x-acs-signature-version": "1.0"
        }
        tea_request.headers = headers
        body_str = "grant_type=refresh_token&refresh_token={0}&client_id={1}&client_secret={2}".format(
            self.__refresh_token, self.__client_id, self.__client_secret)
        tea_request.body = bytes(body_str, encoding="utf-8")
        response = TeaCore.do_action(tea_request)
        if response.status_code == 200:
            dic = json.loads(str(response.content, encoding="utf-8"))
            self.__expire_time = dic.get("expire_time")
            self.__access_token = dic.get("access_token")
            self.__refresh_token = dic.get("refresh_token")

    def __get_host(self, endpoint, domain):
        if endpoint is not None and endpoint != "":
            return endpoint
        else:
            return domain

    def __with_should_refresh(self):
        if self.__refresh_token == "" or self.__expire_time == "":
            return False

        expire_time_str = self.__expire_time.replace('T', ' ').replace('Z', '')
        timeArray = time.strptime(expire_time_str, "%Y-%m-%d %H:%M:%S")
        timeStamp = int(time.mktime(timeArray))
        return int(time.mktime(time.localtime())) >= (timeStamp - 180)
