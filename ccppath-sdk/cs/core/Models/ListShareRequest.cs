// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class ListShareRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public ListShareRequestHeader Header { get; set; }
        public class ListShareRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("creator")]
        [Validation(Required=true)]
        public string Creator { get; set; }

        [NameInMap("limit")]
        [Validation(Required=true)]
        public int? Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("owner")]
        [Validation(Required=true)]
        public string Owner { get; set; }

    }

}