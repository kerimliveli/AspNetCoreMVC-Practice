using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ActionResultts.Entities
{
    public class Employee
    {
        [Range(1,100)]
        public int Id { get; set; }

        [DisplayName("User Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("User Surname")]
        [Required]
        public string LastName { get; set; }
        public int Cityid { get; set; }






    }
}
