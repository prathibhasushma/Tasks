﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_sharp_task3_jan_23
{
    internal class Serializations
    {
        class student
        {
            public int id;
            public string name;
            public int age;
            public string gender;

            public student(int id, int age, string name, string gender)

            {

                this.id = id;
                this.age = age;
                this.name = name;
                this.gender = gender;


            }

            public void display()
            {
                Console.WriteLine("the details are {0},{1},{2},{3} ", id, age, name, gender);
            }
            class child : student
            {
                public child(int id, int age, string? name, string? gender) : base(id, age, name, gender)
                {
                    this.id = id;
                    this.name = name;
                    this.gender = gender;
                    this.age = age;
                }

                //public child(int id, string? name, string? gender, int age)
                //{
                //    this.id = id;
                //    this.name = name;
                //    this.gender = gender;
                //    this.age = age;
                //}
            }




            public static void Main()
            {
                Console.WriteLine("Enter id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Gender");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter age");
                int age = Convert.ToInt32(Console.ReadLine());
                child c = new child(id,age, name, gender);
                c.display();





            }

        }

    }
}
