using PBL3.DAL.Entities;
using PBL3.DAL.Repositories;
using PBL3.DTO;
using System.Collections.Generic;
using System;
using System.Linq;
public class ScheduleService
{
    private readonly ScheduleRepository _scheduleRepo;
    private readonly HistoryRepository _historyRepo;

    public ScheduleService()
    {
        _scheduleRepo = new ScheduleRepository();
        _historyRepo = new HistoryRepository();
    }

    public List<string> GetBusesAvailableForSchedule(string stationId, DateTime startTime, DateTime endTime)
    {
        var candidateBuses = _historyRepo.GetAvailableBusesAtStation(stationId, startTime);
        return candidateBuses
            .Where(busId => _scheduleRepo.IsBusFreeDuringTimeRange(busId, startTime, endTime))
            .ToList();
    }

    public void AddSchedule(ScheduleDTO dto)
    {
        // 1. Thêm lịch trình
        Schedule entity = new Schedule
        {
            ID_Schedule = dto.ID_Schedule,
            ID_bus = dto.ID_bus,
            start_time = dto.start_time,
            end_time = dto.end_time,
            ID_route = dto.ID_route
        };
        _scheduleRepo.Add(entity);

        // 2. Ghi lịch sử ga đến (nếu tuyến tồn tại)
        var route = new RouteRepository().GetById(dto.ID_route);
        if (route != null)
        {
            var historyRepo = new HistoryRepository();

            // 2.1. Cập nhật leave_time cho lịch sử gần nhất (chưa có leave_time)
            var lastHistory = historyRepo
                .GetLastHistoryWithNullLeaveTime(dto.ID_bus);

            if (lastHistory != null)
            {
                lastHistory.leave_time = dto.start_time; // thời điểm xe rời ga cũ là lúc bắt đầu tuyến mới
                historyRepo.UpdateHistory(lastHistory);  // cập nhật lại
            }

            // 2.2. Thêm lịch sử mới (ga đến của tuyến hiện tại)
            var newHistory = new HistoryDTO
            {
                ID_bus = dto.ID_bus,
                ID_Station = route.ID_Station_end,
                arrive_time = dto.end_time,
                leave_time = null
            };
            historyRepo.AddHistory(newHistory);
        }
    }



    public void UpdateSchedule(ScheduleDTO dto)
    {
        var entity = ConvertToEntity(dto);
        _scheduleRepo.Update(entity);
    }

    public void DeleteSchedule(string id) => _scheduleRepo.Delete(id);

    public List<ScheduleDTO> GetAllSchedules()
    {
        return _scheduleRepo.GetAll().Select(ConvertToDTO).ToList();
    }

    private ScheduleDTO ConvertToDTO(Schedule s) => new ScheduleDTO
    {
        ID_Schedule = s.ID_Schedule,
        ID_bus = s.ID_bus,
        start_time = s.start_time,
        end_time = s.end_time,
    };

    private Schedule ConvertToEntity(ScheduleDTO dto) => new Schedule
    {
        ID_Schedule = dto.ID_Schedule,
        ID_bus = dto.ID_bus,
        start_time = dto.start_time,
        end_time = dto.end_time,
    };
}
