// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class DefaultChangePasswordRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public DefaultChangePasswordRequestHeader Header { get; set; }
        public class DefaultChangePasswordRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("app_id")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("new_password")]
        [Validation(Required=true)]
        public string NewPassword { get; set; }

        [NameInMap("phone_number")]
        [Validation(Required=true)]
        public string PhoneNumber { get; set; }

        [NameInMap("sms_code")]
        [Validation(Required=true)]
        public string SmsCode { get; set; }

        [NameInMap("sms_code_id")]
        [Validation(Required=true)]
        public string SmsCodeId { get; set; }

    }

}