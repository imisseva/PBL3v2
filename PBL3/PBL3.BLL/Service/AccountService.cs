using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Repositories;
using PBL3.DTO;

namespace PBL3.BLL.Services
{
    public class AccountService
    {
        private readonly AccountRepository _accountRepo;

        public AccountService()
        {
            _accountRepo = new AccountRepository();
        }

        public AccountDTO Authenticate(string username, string password)
        {
            var account = _accountRepo.GetAccount(username, password);
            if (account == null) return null;

            return new AccountDTO
            {
                Id = account.id,
                Username = account.username,
                Password = account.password,
                Role = account.role
            };
        }
        public bool ChangePassword (int id, string OldPass, string NewPass)
        {
            return _accountRepo.ChangePassword(id, OldPass, NewPass);
        }
    }
}
