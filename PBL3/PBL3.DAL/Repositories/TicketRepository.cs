using PBL3.DAL.Entities;
using PBL3.DAL.Context;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PBL3.DAL.Repositories
{
    public class TicketRepository
    {
        public List<Ticket> GetTickets()
        {
            using (var db = new BusManagement())
            {
                return db.Tickets.ToList();
            }
        }

        public void BookTicket (Ticket ticket)
        {
            using (var db = new BusManagement())
            {
                bool isBooked = db.Tickets.Any(t =>
          t.ID_seat == ticket.ID_seat && t.ID_Schedule == ticket.ID_Schedule);

                if (isBooked)
                {
                    throw new Exception("Ghế đã được đặt trước");
                }

                db.Tickets.Add(ticket);
                db.SaveChanges();
            }   
        }

        public void CancelTicket (Ticket ticket)
        {
            using (var db = new BusManagement())
            {
                var existingTicket = db.Tickets.FirstOrDefault(t =>
                    t.ID_ticket == ticket.ID_ticket);
                if (existingTicket != null)
                {
                    db.Tickets.Remove(existingTicket);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Không tìm thấy vé để hủy");
                }
            }
        }
        public int GetRevenueByDate(DateTime date)
        {
            using (var db = new BusManagement())
            {
                 return db.Tickets
                    .Where(t => t.booking_date.Date == date.Date)
                    .Sum(t => (int?)t.price) ?? 0;
            }
        }

        public int GetRevenueByMonth(int month, int year)
        {
            using (var db = new BusManagement())
            {
                return db.Tickets
                    .Where(t => t.booking_date.Month == month && t.booking_date.Year == year)
                    .Sum(t => (int?)t.price) ?? 0;
            }
        }

        public Dictionary<int, int> GetMonthlyRevenueByYear(int year)
        {
            using (var db = new BusManagement())
            {
                // Lấy tất cả vé trong năm đó
                var tickets = db.Tickets
                    .Where(t => t.booking_date.Year == year)
                    .ToList();

                // Tạo Dictionary để lưu doanh thu của từng tháng
                var revenueByMonth = new Dictionary<int, int>();

                for (int month = 1; month <= 12; month++)
                {
                    int revenue = tickets
                        .Where(t => t.booking_date.Month == month)
                        .Sum(t => t.price);

                    revenueByMonth[month] = revenue;
                }

                return revenueByMonth;
            }
        }
    }
}
