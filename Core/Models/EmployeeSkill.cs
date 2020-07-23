
namespace api_db.Core.Models
{
    public class EmployeeSkill
    {
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeID { get; set; }
        public Skill Skill{get;set;}
        public int SkillID{get;set;}
    }
}