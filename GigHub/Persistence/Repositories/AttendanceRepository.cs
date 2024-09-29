using GigHub.Core.Models;
using GigHub.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GigHub.Persistence.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly ApplicationDbContext _context;

        public AttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Attendance GetAttendance(int id, string userId)
        {
            return _context.Attendances
                .SingleOrDefault(a => a.GigId == id && a.AttendeeId == userId);
        }

        public IEnumerable<Attendance> GetFutureAttendances(string userId)
        {
            return _context.Attendances
                            .Where(a => a.AttendeeId == userId && a.Gig.Date > DateTime.Now)
                            .ToList();
        }

        public void AddAttendance(Attendance attendance)
        {
            _context.Attendances.Add(attendance);
        }

        public void RemoveAttendance(Attendance attendance)
        {
            _context.Attendances.Remove(attendance);
        }
    }
}