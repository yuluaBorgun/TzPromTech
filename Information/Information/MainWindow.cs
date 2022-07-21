using Information.Model;
using Information.ServiceConnector;
using Information.ViewLoader;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Information
{
    public partial class MainWindow : Form
    {
        private FiltersModel filters { get; set; }
        private List<Employee> Data { get; set; }
        IWebServiceConnector webService { get; set; }
        public MainWindow(IWebServiceConnector webService)
        {
            InitializeComponent();
            Data = ViewLoaderData.GetAllEmployees();
            filters = new FiltersModel();
            this.webService = webService;
            LoadEmployeeControls();
        }

        private void LoadEmployeeControls()
        {
            EmployeeItems.Controls.Clear();
            foreach (Employee e in Data)
            {
                EmployeeItems.Controls.Add(new EmployeeControl(e, webService));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filters.FIO = ((TextBox)sender).Text;
            Data = Filters.GetFiltredEmployee(ViewLoaderData.GetAllEmployees(), filters);
            LoadEmployeeControls();
        }

        
    }
}
