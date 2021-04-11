using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TICKETS.Context;
using TICKETS.Entities;
using Microsoft.EntityFrameworkCore;

namespace TICKETS.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
    public class TicketController:ControllerBase
    {
        private readonly TicketDbContext context;
        public TicketController(TicketDbContext context)
        {
            this.context = context;
        }


        //GET api/Ticket
        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> Get()
        {
            return context.ticket.ToList();
        }

        //GET api/Ticket/5
        [HttpGet("{id}")]
        public ActionResult<Ticket> Get(int id)
        {
            var objTicket = context.ticket.FirstOrDefault(x => x.id == id);
            if (objTicket == null)
            {
                return NotFound();
            }

            return objTicket;
        }

        // POST api/Ticket

        [HttpPost]
        public ActionResult Post([FromBody] Ticket tickets)
        {

            context.Add(tickets);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerTicket", new { id = tickets.id }, tickets);

        }

        //PUT api/ticket/5

        [HttpPut("{id}")]
        public ActionResult Put(int id,[FromBody]Ticket ticket)
        {
            context.Entry(ticket).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        //DELETE api/Ticket/5

        [HttpDelete]
        public ActionResult<Ticket> Delete(int id)
        {
            var objTicket = context.ticket.FirstOrDefault(x => x.id == id);
            if (objTicket == null)
            {
                return NotFound();
            }
            context.Remove(objTicket);
            context.SaveChanges();
            return Ok();
        }


    }
}
