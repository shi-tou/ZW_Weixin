﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weixin.MP.Entities;

namespace Weixin.MP.AdvancedAPIs
{
    public class UploadResultJson : WxJsonResult
    {
       public UploadMediaFileType type { get; set; }
       public string media_id { get; set; }
       public long created_at { get; set; }
    }
}
