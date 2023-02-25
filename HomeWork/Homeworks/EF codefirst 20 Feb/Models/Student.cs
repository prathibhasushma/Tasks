using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_codefirst_20_Feb.Models
{

    public class Student
    {
        public int studentid { get; set; }
        public string? studentname { get; set; }
        [ForeignKey("Standard")]
        //will not use "Standard" anywhere in the code just a name
        //should be given only the name of the other table bcos if given other name it create
        //by itself a foreign key with its own name
        public int studentrefid { get; set; }

        public Standard? Standard { get; set; } // refers to the primary key of the other table

    }
    public class Standard
    {
        public int standardid { get; set; }
        public string? Standardname { get; set; }

        public ICollection<Student>? Students { get; set; }

    }

}
