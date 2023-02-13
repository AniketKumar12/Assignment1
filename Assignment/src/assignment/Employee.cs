using System;

public class Employee
{
    private string Id{get;set;}
    private string Name{get;set;}
    private string DepartmentName{get;set;}

    public delegate void MethodCalledEventHandler(object sender, EventArgs e);
    public event MethodCalledEventHandler MethodCalled;

    public Employee(string id, string name, string departmentName)
    {
        Id = id;
        Name = name;
        DepartmentName = departmentName;
    }

    public string GetId()
    {
        OnMethodCalled("GetId");
        return Id;
    }

    public string GetName()
    {
        OnMethodCalled("GetName");
        return Name;
    }

    public string GetDepartmentName()
    {
        OnMethodCalled("GetDepartmentName");
        return DepartmentName;
    }

    public void UpdateId(string id)
    {
        Id = id;
    }

    public void UpdateName(string name)
    {
        Name = name;
    }

    public void UpdateDepartmentName(string departmentName)
    {
        DepartmentName = departmentName;
    }
    

    protected virtual void OnMethodCalled(string methodName)
    {
        MethodCalled?.Invoke(this, EventArgs.Empty);
        Console.WriteLine("{0} method called", methodName);
    }
    static void Main(string[] args)
    {
        String id;
        String name;
        string departmentName;
        Console.WriteLine("Enter the employee id: ");
         id = Console.ReadLine();

        Console.WriteLine("Enter the employee name: ");
        name = Console.ReadLine();

        Console.WriteLine("Enter the employee department name: ");
         departmentName = Console.ReadLine();

        Employee employee = new Employee(id, name, departmentName);

        Console.WriteLine(employee.GetId());
        Console.WriteLine(employee.GetName());
        Console.WriteLine(employee.GetDepartmentName());
    }
}