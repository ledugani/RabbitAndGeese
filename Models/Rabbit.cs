﻿using RabbitsAndGeese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitsAndGeese
{
    public class Rabbit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int MaxFeetPerSecond { get; set; }
        public EarSize EarSize { get; set; }
        public Sex Sex { get; set; }
    }
}
