namespace HRApplicationArApp.Models;

public class Repository
{
    private static List<Employee> EmployeesList = new List<Employee>();

    private static IEnumerable<Employee> getEmployees()
    {
        return EmployeesList;
    }
}