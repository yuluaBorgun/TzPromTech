using Information.Model;

namespace Information.ServiceConnector
{
    class DemoService : IWebServiceConnector
    {
        public bool SendMessage(Employee employee, string message)
        {
            return true;
        }
    }
}
