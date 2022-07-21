using System;
using System.Collections.Generic;
using System.Linq;
using Information.Model;
using Information.Model.View;

namespace Information.ViewLoader
{
    static class ViewLoaderData
    {
        public static EmployeeView GetEmployeeView(Employee e)
        {
            EmployeeView employeeView = new EmployeeView() {
                DateBirth = e.DateOfBirth,
                FIO = e.FIO,
                Phone = e.Telephon
            };
            using (InformationModel connect = new InformationModel())
            {
                employeeView.Department = connect.Employee.FirstOrDefault(em=>em.ID == e.ID).Post.Department.Title;
                employeeView.Post = connect.Employee.FirstOrDefault(em => em.ID == e.ID).Post.TitlePost;
            }
            return employeeView;
        }

        public static List<Employee> GetAllEmployees()
        {
            using (InformationModel connect = new InformationModel())
            {
                return connect.Employee.ToList();
            }
        }

        public static List<Post> GetPosts(Department deparament = null)
        {
            using (InformationModel connect = new InformationModel())
            {
                if (deparament != null)
                {
                    return connect.Post.Where(p=>p.DepartmentID == deparament.ID).ToList();
                }
                else
                {
                    return connect.Post.ToList();
                }
            }            
        }
        public static List<Department> GetChildrenDepartament(Department parentDeparament)
        {
            using (InformationModel connect = new InformationModel())
            {
                return connect.Department.Where(d => d.ParentDepartment == parentDeparament.ID).ToList();
            }
        }


        public static List<Department> GetParentDepartament()
        {
            using (InformationModel connect = new InformationModel())
            {
                return connect.Department.Where(d=>d.ParentDepartment == null).ToList();
            }
        }

        public static bool CheckConnectTelegram(Employee employee)
        {
            using (InformationModel connect = new InformationModel())
            {
                return connect.ConnectionBot.FirstOrDefault(c=> c.EmployeeID == employee.ID) != null;
            }
        }

        public static RequestConnect GetАliveRequestConnect(Employee employee)
        {
            using (InformationModel connect = new InformationModel())
            {
                return connect.RequestConnect.FirstOrDefault(rc=> rc.EmployeeID == employee.ID && rc.Active);
            }
        }

        public static bool DisconnectRequestConnect(Employee employee)
        {
            using (InformationModel connect = new InformationModel())
            {
                List<RequestConnect> aliveRequests = connect.RequestConnect.Where(rc => rc.EmployeeID == employee.ID && rc.Active).ToList();
                for (int i = 0; i< aliveRequests.Count; i++)
                {
                    aliveRequests[i].Active = false;
                }
                connect.SaveChanges();
            }
            return true;
        }

        public static bool CreateNewRequestConnect(Employee employee, string code)
        {
            DateTime now = DateTime.UtcNow;
            using (InformationModel connect = new InformationModel())
            {
                RequestConnect newRequest = new RequestConnect() {
                    EmployeeID = employee.ID,
                    DateCreation = now,
                    DateDisconnections = now.AddDays(2),
                    Active = true,
                    Key = code            
                };
                connect.RequestConnect.Add(newRequest);
                connect.SaveChanges();
            }
            return true;
        }
    }
}
