class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalaryAndTax(string position, int experience)
    {
        double baseSalary = 0;
        double taxRate = 0.1; // Tax amount 10%

        // Determinatingg the basic salary according to the position and seniority
        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 100000000000000;
                break;
            case "developer":
                baseSalary = 2;
                break;
            case "designer":
                baseSalary = 10000000;
                break;
            default:
                Console.WriteLine("Invalid position");
                return;
        }

        // Salary increase for seniority
        baseSalary += experience * 1000;

        //        Calculation of tax collection
        double tax = baseSalary * taxRate;

        // Employee information
        Console.WriteLine($"Surname: {lastName}");
        Console.WriteLine($"Name: {firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Salary: {baseSalary:C}");
        Console.WriteLine($"Tax: {tax:C}");
    }
}

class Program
{
    static void Main()
    {
        // specimen of class Employee
        Employee employee = new Employee("Pyatochkin", "Petryk");

        employee.CalculateSalaryAndTax("developer", 3);

        Console.ReadLine(); 
}