using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Context;
using PBL3.DAL.Entities;
using PBL3.DAL;
namespace PBL3.DAL.Repositories
{
    public class AccountRepository
    {
        public Account GetAccount(string username, string password)
        {
            using (var db = new BusManagement())
            {
                return db.Accounts.FirstOrDefault(a =>
                    a.username == username &&
                    a.password == password);
            }
        }

        public bool ChangePassword(int id, string OldPass, string NewPass)
        {
            using (var db = new BusManagement())
            {
                var account = db.Accounts.FirstOrDefault(a => a.id == id);
                if (account.password != OldPass)
                    return false;
                account.password = NewPass;
                db.SaveChanges();
                return true;
            }
        }
    }
}
