using ActionResultts.Entities;
using ActionResultts.Repostories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActionResultts.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepostory _studentRepostory;
        
       public StudentService(IStudentRepostory studentRepostory)
        {
            _studentRepostory = studentRepostory;
        }


        public async Task<List<Student>> GetAllByKeyASync(string key = "")
        {
            var data = await _studentRepostory.GetAllAsync();

            return key != "" ?
                (data.Where(s => s.Name.ToLower().Contains(key))).ToList();
        }
    }
}
