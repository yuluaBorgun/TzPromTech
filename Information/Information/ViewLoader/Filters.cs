using Information.Model;
using System.Collections.Generic;
using System.Linq;


namespace Information.ViewLoader
{
    public static class Filters
    {
        public static List<Employee> GetFiltredEmployee(List<Employee>  employees,FiltersModel filters)
        {
            List<Employee> femployee = new List<Employee>(employees);
            if (filters.ParentDepartament != null)
            {

            }
            if (filters.EmployeePost != null) {
                femployee = PostFiltered(femployee, new List<Post>() { filters.EmployeePost });
            }
            if (!string.IsNullOrEmpty(filters.FIO))
            {
                femployee = FioFiltered(femployee, filters.FIO);
            }
            return femployee;
        }
        static List<Employee> FioFiltered(List<Employee> employees, string text)
        {
            return employees.Where(e=>e.FIO.Contains(text)).ToList();
        }

        static List<Employee> PostFiltered(List<Employee> employees, List<Post> posts)
        {
            return employees.Where(e => posts.Where(p=>p.ID == e.ID).FirstOrDefault() != null).ToList();
        }
    }
}
