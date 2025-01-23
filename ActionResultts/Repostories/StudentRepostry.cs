using ActionResultts.Context;
using ActionResultts.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActionResultts.Repostories
{
    public class StudentRepostry : IStudentRepostory
    {

        private readonly SchoolDbContext schoolDbContext;

        public StudentRepostry(SchoolDbContext schoolDbContext)
        {
            this.schoolDbContext = schoolDbContext;
        }

        public void Add(Student student)
        {
            schoolDbContext.Students.Add(student);
            schoolDbContext.SaveChanges();
        }

        public async Task<List<Student>> GetAllASync()
        {
           return await schoolDbContext.Students.ToListAsync();
        }
    }
}
    
