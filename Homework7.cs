﻿using System;

namespace Homework7
{
    // Customer class
    public class Customer
    {
        private int cus_id;
        public string cus_name;
        public int cus_age;

        // Constructor
        public Customer(int cus_id, string cus_name, int cus_age)
        {
            this.cus_id = cus_id;
            this.cus_name = cus_name;
            this.cus_age = cus_age;
        }

        // Method to change customer ID
        public void ChangeID(int new_id)
        {
            cus_id = new_id;
        }

        // Method to print customer info in specific format
        public void PrintCusInfo()
        {
            Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age:{cus_age}");
        }

        // Method to compare age
        public void CompareAge(Customer objCustomer)
        {
            if (this.cus_age > objCustomer.cus_age)
            {
                Console.WriteLine($"{this.cus_name} is older");
            }
            else if (this.cus_age < objCustomer.cus_age)
            {
                Console.WriteLine($"{objCustomer.cus_name} is older");
            }
            else
            {
                Console.WriteLine("Both customers are the same age");
            }
        }
    }

    // Program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create customers
            Customer customer1 = new Customer(110, "Alice", 28);
            Customer customer2 = new Customer(111, "Bob", 30);

            // Print initial info
            customer1.PrintCusInfo();
            customer2.PrintCusInfo();

            // Change IDs
            customer1.ChangeID(220);
            customer2.ChangeID(221);

            // Print updated info
            customer1.PrintCusInfo();
            customer2.PrintCusInfo();

            // Compare ages
            customer1.CompareAge(customer2);
        }
    }
}