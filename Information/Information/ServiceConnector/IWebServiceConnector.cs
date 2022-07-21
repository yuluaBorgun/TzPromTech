using Information.Model;

namespace Information.ServiceConnector
{
    public interface IWebServiceConnector
    {
        bool SendMessage(Employee employee, string message);
    }
}
