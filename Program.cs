using System;
using System.Collections.Generic;

namespace VismaKoodi
{
    //  program that counts price of product based on what rebate group customer belongs to
    class Program
    {

        static void Counter(string rebate, double oldprice)
        {
            double newprice;
            // here we can count the discount based on rebate class customer has
            // if we want to add another class, we add another switchcase.
            switch (rebate)
            {
                case "a":
                    newprice = (oldprice * 0.9);
                    Console.WriteLine(newprice);
                    break;
                case "b":
                    newprice = (oldprice * 0.7);
                    Console.WriteLine(newprice);
                    break;
                case "c":
                    newprice = (oldprice * 0.8);
                    Console.WriteLine(newprice);
                    break;

            }

        }

            static void Main(string[] args)
            {
                // strings that the read lines will be put to from input
                 string prod, cust;
                // the price value and rebate group get put into these
                 double prodprice = default;
                 string custRebate = default;
                // The products have their ID number first, price second
                // special product offers could be counted for example by adding another category to 
                // product object and send the info about it to the calculator with the product price info
                // and the quantity discount could be added to calculator so when there is certain amount of
                // product id it gives the discount.
                List<Products> ProductList = new List<Products>();
                ProductList.Add(new Products(10, 100.5));
                ProductList.Add(new Products(20, 10.0));
                ProductList.Add(new Products(30, 40.0));
                ProductList.Add(new Products(10, 400.5));
                // Customer list, Id first, rebate class second
                List<Customer> CustomerList = new List<Customer>();
                CustomerList.Add(new Customer(100, "a"));
                CustomerList.Add(new Customer(200, "b"));
                CustomerList.Add(new Customer(300, "c"));
                CustomerList.Add(new Customer(400, "b"));
                CustomerList.Add(new Customer(500, "a"));
                // ask the user product id and customer id
                Console.WriteLine("Give the product ID: (10,20,30 etc)");
                prod = Console.ReadLine();
                Console.WriteLine("Give the customer ID (100,200,300..etc): ");
                cust = Console.ReadLine();
                // turn the given values to int 
                int prod2 = Int32.Parse(prod);
                int cust2 = Int32.Parse(cust);
              
                // search for the given product id from list
                foreach (var product in ProductList)
                {
                    if (prod2 == product.Id)
                    {
                        prodprice = product.Price;
                    }
                }
                // search for given customer id from list
                foreach (var customer in CustomerList)
                {
                    if (cust2 == customer.Id)
                    {
                        custRebate = customer.Rebate;
                    }
                }
                // call the counter method
                Counter(custRebate, prodprice);
            }


        
     
    }
    public class Products
    {
        // Builder for product object
        private int pr_Id;
        private double pr_Price;

        public Products(int pr_Id, double pr_Price)
        {
            this.pr_Id = pr_Id;
            this.pr_Price = pr_Price;

        }
        public int Id
        {
            get { return pr_Id; }
            set { pr_Id = value; }
        }
        public double Price
        {
            get { return pr_Price; }
            set { pr_Price = value; }
        }
        
    }
    class Customer
    {
        // builder for customer object
        private int custId;
        private string rebate;
        public Customer(int cId, string reb)
        {
            this.custId = cId;
            this.rebate = reb;
        }
        public int Id
        {
            get { return custId; }
            set { custId = value; }
        }
        public string Rebate
        {
            get { return rebate; }
            set { rebate = value; }
        }

    }


}
