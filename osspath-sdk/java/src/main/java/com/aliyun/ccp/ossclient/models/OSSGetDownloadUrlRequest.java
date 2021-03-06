// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 获取文件下载地址的请求body
 */
public class OSSGetDownloadUrlRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("expire_sec")
    public Long expireSec;

    @NameInMap("file_name")
    public String fileName;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-Z-]+")
    public String shareId;

    public static OSSGetDownloadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSGetDownloadUrlRequest self = new OSSGetDownloadUrlRequest();
        return TeaModel.build(map, self);
    }

}
