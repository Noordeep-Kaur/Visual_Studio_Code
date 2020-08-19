using Bus.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bus.Controllers
{
    public class TicketGenerationController : ApiController
    {
        private BusReservationEntities db=new BusReservationEntities();
        [HttpGet]
        public object getiif(int id)
        {
            var obj = db.proc_TicketFetching(id);
            return obj;
        }
        [HttpPost]
        public object search(Ticket ticks)
        {
            //var busInfoPost = db.proc_Bus(journeyinfo.FromLocation, journeyinfo.ToLocation, journeyinfo.FromDate);
            var ticketInfo = db.proc_addTicketDetail(ticks.BusID,ticks.BookingUserID,ticks.FromLocation,ticks.ToLocation,
                ticks.FromDate,ticks.ToDate,ticks.FromTime,ticks.ToTime,ticks.NumberOfSeats,ticks.Fare);
            return ticketInfo;

        }
    }
}

