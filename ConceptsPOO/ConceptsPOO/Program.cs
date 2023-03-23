// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Hello, World!");
Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022,1,15),
    IsActive = true,
    Salary = 1815453.45M
};

Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2010,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022,2,5),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};

Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022,2,5),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F
};

Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jazmine",
    LastName = "Salazar",
    BirthDate = new Date(198, 5, 23),
    HiringDate = new Date(2022,2,5),
    IsActive = true,
    Base = 120.56M,
    Sales = 745161321M,
    CommissionPercentaje = 0.015F
};

Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>();
employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);
employees.Add(employee4);

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll+=employee.GetValueToPay();

}
Console.WriteLine(payroll);



