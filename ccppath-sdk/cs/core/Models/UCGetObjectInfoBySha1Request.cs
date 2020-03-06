// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class UCGetObjectInfoBySha1Request : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public UCGetObjectInfoBySha1RequestHeader Header { get; set; }
        public class UCGetObjectInfoBySha1RequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("sha1")]
        [Validation(Required=false)]
        public string Sha1 { get; set; }

    }

}