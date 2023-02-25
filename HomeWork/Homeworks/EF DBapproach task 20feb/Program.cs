using EF_DBapproach_Feb_20.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBapproach_Feb_20
{
    internal class Program
    {

        public static void insertdepartment()
        {
            using (var dbcon = new DivsambarContext())
            {
                Department department = new Department();
                department.Departmentname = "HR";
                dbcon.Add(department);
                dbcon.SaveChanges();

            }
            return;


        }

        public static void insertemployee()
        {
            using (var dbcon = new DivsambarContext())

            {
                Employee employee = new Employee();
                employee.Empid = 1;
                employee.Empname = "Prathibha";
                employee.Department = "Developement";
                employee.Gender = "f";
                // employee.Deptid = 100;
                employee.Designation = "sr.associate engg";
                dbcon.Add(employee);
                dbcon.SaveChanges();


            }
        }

        public static void Main()
        {
            //insertdepartment();
            insertemployee();

        }
    }
}
