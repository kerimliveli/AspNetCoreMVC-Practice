using ActionResultts.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActionResultts.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllByKeyASync(string key = "");
    }
}
