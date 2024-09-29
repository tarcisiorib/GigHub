using GigHub.Core.Models;
using System.Collections.Generic;

namespace GigHub.Core.Repositories
{
    public interface IAttendanceRepository
    {
        Attendance GetAttendance(int id, string userId);
        IEnumerable<Attendance> GetFutureAttendances(string userId);
        void AddAttendance(Attendance attendance);
        void RemoveAttendance(Attendance attendance);
    }
}