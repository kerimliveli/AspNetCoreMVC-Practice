using ActionResultts.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActionResultts.Repostories
{
    public interface IStudentRepostory
    {
        Task<List<Student>> GetAllASync();
        void Add(Student student);
       
    }
}
