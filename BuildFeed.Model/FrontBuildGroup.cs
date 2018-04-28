﻿using System;

namespace BuildFeed.Model
{
    public class FrontBuildGroup
    {
        public int BuildCount { get; set; }
        public BuildGroup Key { get; set; }
        public DateTime? LastBuild { get; set; }
    }
}