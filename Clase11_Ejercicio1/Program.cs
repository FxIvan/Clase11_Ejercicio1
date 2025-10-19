using static Clase11_Ejercicio1.IComparer;

List<Employee> employees = new List<Employee>
{
    new Employee { Name = "Alice", Salary = 60000 },
    new Employee { Name = "Carla", Salary = 50000 },
    new Employee { Name = "Bob", Salary = 50000 },
    new Employee { Name = "Analia", Salary = 85000 },
};

employees.Sort();

foreach (var emp in employees)
{
    Console.WriteLine($"{emp.Name} - {emp.Salary}");
}