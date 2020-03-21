﻿using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caya.Framework.Configuration
{
    public class AppConfigOption
    {
        public DatabaseCluster DatabaseCluster { get; set; }

        public LoggingConfig LoggingConfig { get; set; } = new LoggingConfig();

        public RedisCluster RedisCluster { get; set; }
    }
}