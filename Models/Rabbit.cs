﻿using RabbitsAndGeese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitsAndGeese
{
    public class Rabbit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int MaxFeetPerSecond { get; set; }
        public EarSize EarSize { get; set; }
        public Sex Sex { get; set; }
        public List<Goose> OwnedGeese { get; set; } = new List<Goose>();
    }
}
