using System;
using System.Collections.Generic;

namespace EF_DBapproach_task_20feb.Models;

public partial class Employee
{
    public int Empid { get; set; }

    public string? Empname { get; set; }

    public string? Department { get; set; }

    public int? Deptid { get; set; }

    public string? Designation { get; set; }

    public string? Gender { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public virtual Department? Dept { get; set; }
}
