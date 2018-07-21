﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Enums
{
    /// <summary>
    /// 大陆11位 补0
    /// 香港8位  区号：852 补0
    /// 澳门8位  区号：853 补0
    /// 台湾的是10位 区号：886
    /// 台湾手机号码有10码，例如0912345678不过前面那个0是我们自己在台湾打的，
    /// 假如是其他地方打来要改成打 +886912345678
    /// </summary>
    public enum JT808PhoneNumberType
    {
        大陆=11,
        香港=8,
        澳门=8,
        台湾=10
    }
}
