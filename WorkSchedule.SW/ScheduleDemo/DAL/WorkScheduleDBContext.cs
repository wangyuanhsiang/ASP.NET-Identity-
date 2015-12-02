using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using ScheduleDemo.Entiies;

namespace ScheduleDemo.DAL
{
    public class WorkScheduleDBContext : DbContext
    {
        public WorkScheduleDBContext() : base("name=WorkSchedule") { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<PlacementContract> PlacementContracts { get; set; }
        public DbSet<Shift> Shifts { get; set; }  
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }

    }
}
