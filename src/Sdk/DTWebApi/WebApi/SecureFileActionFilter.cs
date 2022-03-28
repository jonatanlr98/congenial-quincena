﻿using System;
using System.Runtime.Serialization;

namespace GitHub.DistributedTask.WebApi
{
    [Flags]
    [DataContract]
    public enum SecureFileActionFilter
    {
        [EnumMember]
        None = 0,

        [EnumMember]
        Manage = 2,

        [EnumMember]
        Use = 16,
    }
}
