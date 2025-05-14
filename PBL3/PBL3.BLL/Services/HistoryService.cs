using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL.Repositories;
using PBL3.DTO;
namespace PBL3.BLL.Services
{
    public class HistoryService
    {
        private HistoryRepository _repository = new HistoryRepository();

        public List<HistoryDTO> GetAllHistory()
        {
            return _repository.GetAllHistory();
        }

        public void AddHistory(HistoryDTO dto)
        {
            _repository.AddHistory(dto);
        }

        public void UpdateHistory(HistoryDTO dto)
        {
            _repository.UpdateHistory(dto);
        }

        public void DeleteHistory(int id)
        {
            _repository.DeleteHistory(id);
        }

        public HistoryDTO GetById(int id)
        {
            return _repository.GetById(id);
        }
    }

}
