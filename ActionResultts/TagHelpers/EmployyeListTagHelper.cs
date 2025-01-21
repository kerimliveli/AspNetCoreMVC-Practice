using ActionResultts.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ActionResultts.TagHelper
{
    [HtmlTargetElement("employee-list")]
    public class EmployyeListTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {

        public List<Employee> employee;

        public EmployyeListTagHelper()
        {

            employee = new List<Employee>()
            {
            new Employee()
            {
                Id = 1,
                FirstName = "Veli",
                LastName = "Kerimli",
                Cityid = 1,
            },


                new Employee()
                {
                    Id = 2,
                    FirstName = "Veli2",
                    LastName = "Kerimli2",
                    Cityid = 2,
                },


                new Employee()
                {
                    Id = 3,
                    FirstName = "Veli3",
                    LastName = "Kerimli3",
                    Cityid = 3,
                },
                 new Employee()
            {
                Id = 1,
                FirstName = "Veli4",
                LastName = "Kerimli4",
                Cityid = 1,
            },


                new Employee()
                {
                    Id = 2,
                    FirstName = "Veli5",
                    LastName = "Kerimli5",
                    Cityid = 2,
                },


                new Employee()
                {
                    Id = 3,
                    FirstName = "Veli6",
                    LastName = "Kerimli6",
                    Cityid = 3,
                }
            };
        }

        

        private const string ListCountAttribute = "count";
        [HtmlAttributeName(ListCountAttribute)]

        public int ListCount { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            var query = employee.Take(ListCount);
            //var query = employee;
            StringBuilder sb = new ();
            foreach ( var item in query )
            {
                sb.AppendFormat("<h2><a href = 'employee/detail/{0}' > {1} <{1}</a></h2>", item.Id, item.FirstName);
            }

            output.Content.SetHtmlContent( sb.ToString() );
        }

    }
}
