using System;
using System.Collections.Generic;

namespace EF_DBapproach_task_20feb.Models;

public partial class Department
{
    public int Departmentid { get; set; }

    public string? Departmentname { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
