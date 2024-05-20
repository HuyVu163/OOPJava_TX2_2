using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    public abstract class Person
    {
        private string name;
        private string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public abstract void display();
    }

    public class Employee : Person
    {
        private int salary;
        public Employee(string name, string address, int salary) : base(name, address)
        {
            this.salary = salary;
        }
        public int Salary { get { return salary; } set { salary = value; } }

        public override void display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Salary: {salary}");
        }
    }

    public class Customer : Person
    {
        private int balance;
        public Customer(string name, string address, int balance) : base(name, address)
        {
            this.balance = balance;
        }
        public int Balance { get { return balance; } set { balance = value; } }

        public override void display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Balance: {balance}");
        }
    }
}
