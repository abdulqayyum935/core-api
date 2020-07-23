using System;

namespace api_db.Core.Models
{
    public class Attendance
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Employee Employee {get;set;}
        public int EmployeeID {get;set;}
    }
}