using System.Collections.Generic;
using System.Threading.Tasks;
using api_db.Core.IRepositories;
using api_db.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace api_db.Persistence
{
    public class SkillsRepository
    {
        DatabaseContext context;
        IUnitOfWork unitOfWork;
        public SkillsRepository(DatabaseContext context,IUnitOfWork unitOfWork){
            this.context=context;
            this.unitOfWork=unitOfWork;
        }

        public async Task<List<Skill>> GetAllSkills(){
           return await context.Skills.ToListAsync();
        }
        public async Task<Skill> Add(Skill skill){
           context.Skills.Add(skill);
           await unitOfWork.SaveChangesAsync();
           return skill;
        }
        public async Task<Skill> Edit(int id)=>await context.Skills.FirstOrDefaultAsync(x=>x.ID==id);
        
        public async Task<Skill> Update(int id,Skill skill){
            var result = await context.Skills.FindAsync(id);
            if(result==null) return null;
            context.Skills.Update(skill);
           await unitOfWork.SaveChangesAsync();
           return skill;
        }
        
    }
}