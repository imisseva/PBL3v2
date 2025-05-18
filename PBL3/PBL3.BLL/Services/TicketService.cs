using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Entities;
using PBL3.DAL.Repositories;
using PBL3.DTO;


namespace PBL3.BLL.Services
{
    public class TicketService
    {
        private TicketRepository _repo = new TicketRepository();
        public List<TicketDTO> GetTickets()
        {
            return _repo.GetTickets()
                .Select(t => new TicketDTO
                {
                    ID_ticket = t.ID_ticket,
                    booking_date = t.booking_date,
                    ID_seat = t.ID_seat,
                    ID_schedule = t.ID_Schedule,
                    Price =t.price,
                }).ToList();
        }

        public void BookTicket(TicketDTO dto)
        {
            var ticket = new Ticket
            {
                // Không cần set ID_ticket vì DB tự tăng
                booking_date = dto.booking_date,
                ID_seat = dto.ID_seat,
                ID_Schedule = dto.ID_schedule,
                price = dto.Price,
                ID_Station_start = dto.station_start,
                ID_Station_end = dto.station_end
            };
            _repo.BookTicket(ticket);
        }


        public void CancelTicket(TicketDTO dto)
        {
            var ticket = new Ticket
            {
                ID_ticket = dto.ID_ticket,
                booking_date = dto.booking_date,
                ID_seat = dto.ID_seat,
                ID_Schedule = dto.ID_schedule,
                price = dto.Price,
            };
            _repo.CancelTicket(ticket);
        }
    }
}
