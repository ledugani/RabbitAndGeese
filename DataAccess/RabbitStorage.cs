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
        static List<Rabbit> _hutch = new List<Rabbit>();

        public void Add(Rabbit rabbit)
        {
            rabbit.Id = _hutch.Any() ? _hutch.Max(r => r.Id) + 1 : 1;
            _hutch.Add(rabbit);
        }

        public Rabbit GetById(int id)
        {
            return _hutch.First(rabbit => rabbit.Id == id);
        }
    }
}
