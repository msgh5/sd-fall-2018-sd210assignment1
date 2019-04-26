﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SD210Assignment1.Models
{
    public class ActionLog
    {
        public int Id { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public long TimeInMs { get; set; }
    }
}