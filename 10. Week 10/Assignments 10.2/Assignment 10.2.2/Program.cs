/*
 2. Write a program to create a list of employees. 
Consider a hard coded list.
Display all employees who have salary more than $5000 and age < 30.

 */
List<Employee> employees = new List<Employee>
{
    new Employee { Name = "John", Age = 25, Salary = 6000 },
    new Employee { Name = "Alice", Age = 28, Salary = 4500 },
    new Employee { Name = "Bob", Age = 32, Salary = 7000 },
    new Employee { Name = "Eve", Age = 29, Salary = 5500 },
    new Employee { Name = "Charlie", Age = 27, Salary = 4800 }
};
Solution result = new Solution();
result.FindEmployees(employees);

public class Solution
{
    public void FindEmployees(List<Employee> employees)
    {
        // LINQ query to find employees with salary > 5000 and age < 30
        var employeeQuery = from emp in employees
                            where emp.Salary > 5000 && emp.Age < 30
                            select emp;
        // Display the filtered employees
        foreach (var emp in employeeQuery)
        {
            Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}, Salary: {emp.Salary}");
        }
    }
}

public class Employee
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public decimal Salary { get; set; }
}