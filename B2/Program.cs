// See https://aka.ms/new-console-template for more information
using B2;
class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        List<Customer> customers = new List<Customer>();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. Find employee with highest salary");
            Console.WriteLine("4. Find customer with lowest balance ");
            Console.WriteLine("5. Find employee by name");
            Console.WriteLine("6. Exit");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid output.Please enter a number.");
            }
            switch (option)
            {
                case 1:
                    AddEmployee(employees);
                    break;
                case 2:
                    AddCustomer(customers);
                    break;
                case 3:
                    FindEmployeeHighestSalary(employees);
                    break;
                case 4:
                    FindCustomerLowestBalance(customers);
                    break;
                case 5:
                    FindEmployeeByName(employees);
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Please choose again.");
                    break;
            }
        }
    }

    public static void AddEmployee(List<Employee> employees)
    {
        try
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            int salary = int.Parse(Console.ReadLine());
            employees.Add(new Employee(name, address, salary));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter correct data.");
        }
    }

    public static void AddCustomer(List<Customer> customers)
    {
        try
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter balance: ");
            int balance = int.Parse(Console.ReadLine());
            customers.Add(new Customer(name, address, balance));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter correct data.");
        }
    }

    public static void FindEmployeeHighestSalary(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employee found.");
            return;
        }

        var highestSalaryEmployees = employees.OrderByDescending(e => e.Salary).FirstOrDefault();
        Console.WriteLine("Employee with the highest salary: ");
        highestSalaryEmployees.display();
    }

    public static void FindCustomerLowestBalance(List<Customer> customers)
    {
        if (customers.Count == 0)
        {
            Console.WriteLine("No customer found.");
            return;
        }

        var lowestBalanceCustomer = customers.OrderBy(c => c.Balance).FirstOrDefault();
        Console.WriteLine("Customer with the lowest balace: ");
        lowestBalanceCustomer.display();
    }

    public static void FindEmployeeByName(List<Employee> employees)
    {
        Console.Write("Enter name: ");
        string s = Console.ReadLine();
        
        var foundEmployees = employees.Where(e => e.Name.Contains(s, StringComparison.OrdinalIgnoreCase)).ToList();
        if (foundEmployees.Count == 0)
        {
            Console.WriteLine("No employees found with the given name.");
        } else
        {
            foreach (var employee in foundEmployees)
            {
                employee.display();
            }
        }
    }
}