using api_db.Core.Models;

namespace api_db.Core.Models
{
    public class BankDetail
    {
        public int ID { get; set; }
        public string NameOfBank { get; set; }
        public string AccountTitle { get; set; }
        public string AccountNumber { get; set; }
        public Employee Employee{get;set;}
        public int EmployeeID {get;set;}
        public bool IsDeleted { get; set; }
    }
}