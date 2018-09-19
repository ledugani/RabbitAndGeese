using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitsAndGeese.DataAccess;
using RabbitsAndGeese.Models;

namespace RabbitsAndGeese.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitController : ControllerBase
    {
        public void AddACustomer(Rabbit rabbit)
        {
            var storage = new RabbitStorage();
            storage.Add(rabbit);
        }

        [HttpPut("{id}")]
        public void AddGooseToRabbit(Goose goose, int id)
        {
            var storage = new RabbitStorage();
            var rabbit = storage.GetById(id);
            rabbit.OwnedGeese.Add(goose);
        }
    }
}