using System;
using System.Windows.Forms;
using Information.Model;
using Information.Model.View;
using Information.ServiceConnector;
using Information.ViewLoader;

namespace Information
{
    public partial class EmployeeControl : UserControl
    {
        public Employee Data { get;private set; }
        IWebServiceConnector webService { get; set; }
        public EmployeeControl()
        {
            Data = new Employee();
            InitializeComponent();
        }

        public EmployeeControl(Employee employee, IWebServiceConnector webService)
        {
            Data = employee;
            this.webService = webService;
            InitializeComponent();
            loadInformation();
        }

        private void loadInformation()
        {
            EmployeeView employeeView = ViewLoaderData.GetEmployeeView(Data);
            this.Fio.Text = employeeView.FIO;
            this.BirthDay.Text =$"Дата рождения: {employeeView.DateBirth.ToString("dd.MM.yyyy")}";
            this.Phone.Text = $"Телефон: {employeeView.Phone}";
            this.Department.Text = $"Отдел: {employeeView.Department}";
            this.Pozition.Text = $"Должность:{employeeView.Post}";
            if (Data.Photo != null && Data.Photo.Length != 0)
            {
                this.EmployeeImage.Image = ViewLoader.ImageConverter.ByteArrayToImage(Data.Photo);
            }
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            if (ViewLoaderData.CheckConnectTelegram(this.Data))
            {
                SendMessageForm messageForm = new SendMessageForm(this.Data, this.webService);
                messageForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Подключение к боту не добавлено пользователем!", "Аккаунт не подключен!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            RequestConnect requestConnect = ViewLoaderData.GetАliveRequestConnect(this.Data);
            if (requestConnect!= null)
            {
                ViewLoaderData.DisconnectRequestConnect(this.Data);
            }
            string code = Commands.GetRandomCode(6);
            if(ViewLoaderData.CreateNewRequestConnect(Data, code))
            {
                MessageBox.Show($"Код для подключения успешно создан: {code}");
            }
            else
            {
                MessageBox.Show($"Что-то пошло не так");
            }
        }
    }
}
