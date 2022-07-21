using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information.Model
{
    public class FiltersModel
    {
        public string FIO { get; set; }
        public Department ParentDepartament { get; set; }
        public Post EmployeePost { get; set; }
    }
}
