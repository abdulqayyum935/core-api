using Microsoft.EntityFrameworkCore;
using api_db.Core.Models;

namespace api_db.Persistence
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions options):base(options){}
       public DbSet<Employee> Employees{get;set;}
        public DbSet<Skill> Skills{get;set;}
        public DbSet<Attendance> Attendances{get;set;}
        public DbSet<EmployeeSkill> EmployeeSkill{get;set;}

        public DbSet<BankDetail> BankDetails{get;set;}
    }
}