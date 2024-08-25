using EF01.Contexts;
using EF01.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EnteroriseDbContext enteroriseDbContext = new EnteroriseDbContext();
            //// enteroriseDbContext.Database.EnsureCreated();
            //// enteroriseDbContext.Database.Migrate();


            //try
            //{

            //}
            //finally
            //{

            //}


            //using (EnteroriseDbContext enteroriseDbContext = new EnteroriseDbContext())
            //{

            //}


            using EnteroriseDbContext enteroriseDbContext = new EnteroriseDbContext();

            #region CRUD
            //Employee employee = new Employee()
            //{
            //    EmpName = "Manar",
            //    Age = 24,
            //    Email = "manar@gmail.com"
            //    ,
            //    phoneNum = "01154548"
            //    ,
            //    Salary = 15000
            //    ,
            //    password = "password"
            //};
            //Employee employee01 = new Employee()
            //{
            //    EmpName = "Mohamed",
            //    Age = 26,
            //    Email = "mohamed@gmail.com"
            //    ,
            //    phoneNum = "01154548"
            //    ,
            //    Salary = 25000
            //    ,
            //    password = "password"
            //};
            #region Insert


            ////add locally
            //enteroriseDbContext.Employees.Add(employee); 
            //enteroriseDbContext.Employees.Add(employee01);

            //Console.WriteLine(enteroriseDbContext.Entry(employee).State);
            //Console.WriteLine(enteroriseDbContext.Entry(employee01).State);


            //Console.WriteLine("*************************************");

            ////add remotly

            //enteroriseDbContext.SaveChanges();


            //Console.WriteLine(enteroriseDbContext.Entry(employee).State);
            //Console.WriteLine(enteroriseDbContext.Entry(employee01).State);
            #endregion

            #region Read
            //var emp = (from E in enteroriseDbContext.Employees
            //               where E.EmpId ==1 
            //               select E).FirstOrDefault();

            //    Console.WriteLine(emp?.EmpName ?? "Not Found");


            #endregion

            #region Update
            //var emp = (from E in enteroriseDbContext.Employees
            //           where E.EmpId == 1
            //           select E).FirstOrDefault();
            //Console.WriteLine(enteroriseDbContext.Entry(emp).State);
            //emp.EmpName = "Manar Abdo";  //locally
            //Console.WriteLine(enteroriseDbContext.Entry(emp).State);
            //enteroriseDbContext.SaveChanges();
            //Console.WriteLine(enteroriseDbContext.Entry(emp).State);

            #endregion

            #region Delete 
            //var emp = (from E in enteroriseDbContext.Employees
            //where E.EmpId == 1
            //           select E).FirstOrDefault();
            //Console.WriteLine(enteroriseDbContext.Entry(emp).State);

            //enteroriseDbContext.Employees.Remove(emp);   //locally
            //Console.WriteLine(enteroriseDbContext.Entry(emp).State);
            //enteroriseDbContext.SaveChanges();
            //Console.WriteLine(enteroriseDbContext.Entry(emp).State);

            #endregion
            #endregion



        }
    }
}
