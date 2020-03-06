// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class CCPCreateFileRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public CCPCreateFileRequestHeader Header { get; set; }
        public class CCPCreateFileRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("content_md5")]
        [Validation(Required=false)]
        public string ContentMd5 { get; set; }

        [NameInMap("content_type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("name")]
        [Validation(Required=false, Pattern="[a-z0-9.-_]{1,1000}")]
        public string Name { get; set; }

        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<UploadPartInfo> PartInfoList { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long Size { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("auto_rename")]
        [Validation(Required=false)]
        public bool? AutoRename { get; set; }

        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        [NameInMap("description")]
        [Validation(Required=false, MaxLength=0)]
        public string Description { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        [NameInMap("meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        [NameInMap("parent_file_id")]
        [Validation(Required=false, MaxLength=50, Pattern="[a-z0-9]{1,50}")]
        public string ParentFileId { get; set; }

        [NameInMap("pre_hash")]
        [Validation(Required=false)]
        public string PreHash { get; set; }

    }

}