using EFMyShop;
using EFMyShop.Impl;
using EFMyShop.Models;
using System;
using System.Linq;

namespace MyShop
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SampleContext context = new SampleContext();
            var name = context.Customers
                             .Select(c => c.FirstName)
                             .FirstOrDefault();

            Console.WriteLine(name);
            context.SaveChanges();

            var context1 = new SampleContext();
            ICustomerRepository employeeRepository = new CustomerRepository(context);
            employeeRepository.GetAll(p => p.FirstName == "Customer2");

            IUnitOfWork unitOfWork = new UnitOfWork(context);
            Console.WriteLine(unitOfWork.Customer.ToString());
            unitOfWork.Commit();
            Console.ReadLine();
        }
    }
}
