using EFCorePractice.Contexts;
using EFCorePractice.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ADD for Instructor
            using ITIDbContext context = new ITIDbContext();
            #region Insert
            //Instructor Ins01 = new Instructor() { Name = "Mahmoud", Bonus = 20,Salary = 1000,HourRate = 20,Address = "Giza"};
            //Instructor Ins02 = new Instructor() { Name = "Mohamed", Bonus = 20,Salary = 1000,HourRate = 20,Address = "cairo"};

            //Console.WriteLine(context.Entry(Ins01).State); // Detached

            //context.Add(Ins01);
            //context.Add(Ins02);

            //Console.WriteLine(context.Entry(Ins01).State); //Added

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Ins01).State); // Unchanged


            // ADD for Student

            //Student stu01 = new Student() { FName = "Mahmoud",LName = "Ibrahim",Address = "Giza",Age = 22};
            //Student stu02 = new Student() { FName = "Mohamed",LName = "ahmed",Address = "cairo",Age = 22};


            //Console.WriteLine(context.Entry(stu01).State); // Detached

            //context.Add(stu01);
            //context.Add(stu02);

            //Console.WriteLine(context.Entry(stu01).State); //Added

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(stu01).State); // Unchanged


            // ADD for course

            //Course course01 = new Course() { name = "CS", description = "cs 123", duration = 100 };
            //Course course02 = new Course() { name = "eng", description = "eng 123", duration = 200 };



            //Console.WriteLine(context.Entry(course01).State); // Detached

            //context.Add(course01);
            //context.Add(course02);

            //Console.WriteLine(context.Entry(course01).State); //Added

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(course01).State); // Unchanged


            // ADD for department

            //Department dept01 = new Department() { Name = "ITI", HiringDate = DateTime.UtcNow };
            //Department dept02 = new Department() { Name = "cs", HiringDate = DateTime.UtcNow };
            //Console.WriteLine(context.Entry(dept01).State); // Detached

            //context.Add(dept01);
            //context.Add(dept01);

            //Console.WriteLine(context.Entry(dept01).State); //Added

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(dept01).State); // Unchanged


            // ADD for Topic

            //Topic top01 = new Topic() {Name = "OperatinSystem"};


            //Console.WriteLine(context.Entry(top01).State); // Detached

            //context.Add(top01);
            //Console.WriteLine(context.Entry(top01).State); //Added

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(top01).State); // Unchanged


            #endregion


            #region Select
            //var instructor = (from Ins in context.Instructors
            //                  where Ins.Id == 1
            //                  select Ins).FirstOrDefault();
            //Console.WriteLine(instructor?.Name ?? "NA");


            #region Update
            //instructor.Name = "Ali";
            //Console.WriteLine(context.Entry(instructor).State);
            //context.SaveChanges();
            #endregion

            #endregion


            #region Delete
            //Console.WriteLine(context.Entry(instructor).State);
            //context.Remove(instructor);

            //Console.WriteLine(context.Entry(instructor).State);
            //context.SaveChanges();

            //Console.WriteLine(context.Entry(instructor).State);

            #endregion


        }

    }
}
