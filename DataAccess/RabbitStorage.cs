using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitsAndGeese.Models;

namespace RabbitsAndGeese.DataAccess
{
    public class RabbitStorage
    {
        static List<Rabbit> _hutch;

        public void Add(Rabbit rabbit)
        {
            _hutch.Add(rabbit);
        }
    }
}
