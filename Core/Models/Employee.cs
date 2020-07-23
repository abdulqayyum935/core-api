using System;
using System.ComponentModel.DataAnnotations;

namespace api_db.Core.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string EmailAddress{get;set;}
        public string PhoneNumber {get;set;}
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public bool IsDeleted { get; set; }
    }
}