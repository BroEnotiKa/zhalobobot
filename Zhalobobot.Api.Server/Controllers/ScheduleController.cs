using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zhalobobot.Api.Server.Repositories.Schedule;
using Zhalobobot.Common.Models.Schedule;
using Zhalobobot.Common.Models.Schedule.Requests;

namespace Zhalobobot.Api.Server.Controllers
{
    [Route("schedule")]
    public class ScheduleController
    {
        private readonly IScheduleRepository repository;

        public ScheduleController(IScheduleRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost("getByCourse")]
        public async Task<ScheduleItem[]> GetByCourse([FromBody] GetScheduleByCourseRequest request)
            => await repository.GetByCourse(request.Course);

        [HttpPost("getByDayOfWeek")]
        public async Task<ScheduleItem[]> GetByDayOfWeek([FromBody] GetScheduleByDayOfWeekRequest request)
            => await repository.GetByDayOfWeek(request.DayOfWeek);
        
        [HttpPost("getByDayOfWeekAndStartsAtHourAndMinute")]
        public async Task<ScheduleItem[]> GetByDayOfWeekAndStartsAtHourAndMinute([FromBody] GetScheduleByDayOfWeekHourAndMinuteRequest request)
            => await repository.GetByDayOfWeekAndStartsAtHourAndMinute(request.DayOfWeek, request.HourAndMinute);

        [HttpPost("getByDayOfWeekAndEndsAtHourAndMinute")]
        public async Task<ScheduleItem[]> GetByDayOfWeekAndEndsAtHourAndMinute([FromBody] GetScheduleByDayOfWeekHourAndMinuteRequest request)
            => await repository.GetByDayOfWeekAndEndsAtHourAndMinute(request.DayOfWeek, request.HourAndMinute);
    }
}