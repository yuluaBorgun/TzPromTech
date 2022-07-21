using Information.Model;
using Information.ServiceConnector;
using System;
using System.Windows.Forms;

namespace Information
{
    public partial class SendMessageForm : Form
    {
        private Employee data { get; set; }
        IWebServiceConnector webService { get; set; }


        public SendMessageForm(Employee employee, IWebServiceConnector webService)
        {
            InitializeComponent();
            data = employee;
            this.webService = webService;
            this.Text = data.FIO;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string message = TextMessage.Text;
            bool otvet = webService.SendMessage(data, message);
            if (otvet)
            {
                MessageBox.Show("Сообщение успешно отправлено", "Отправка сообщения");
            }
            else
            {
                MessageBox.Show("При отправке сообщения произошла ошибка", "Отправка сообщения");
            }
        }

        private void SendMessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
