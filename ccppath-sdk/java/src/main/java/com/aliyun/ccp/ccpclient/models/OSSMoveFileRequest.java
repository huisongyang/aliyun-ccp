// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 文件移动请求
 */
public class OSSMoveFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("new_name")
    @Validation(required = true)
    public String newName;

    @NameInMap("overwrite")
    public Boolean overwrite;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-z-]+")
    public String shareId;

    @NameInMap("to_parent_file_path")
    public String toParentFilePath;

    public static OSSMoveFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSMoveFileRequest self = new OSSMoveFileRequest();
        return TeaModel.build(map, self);
    }

}
