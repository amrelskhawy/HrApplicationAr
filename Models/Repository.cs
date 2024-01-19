namespace HRApplicationArApp.Models;

public class Repository
{
    private static List<Employee> EmployeesList = new List<Employee>();

    public static IEnumerable<Employee> GetEmployees()
    {
        return EmployeesList;
    }

    public static void AddEmployee(Employee employee)
    {
        EmployeesList.Add(employee);
    }
}