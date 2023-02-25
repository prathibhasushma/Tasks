using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF_DBapproach_task_20feb.Models;

public partial class DivsambarContext : DbContext
{
    public DivsambarContext()
    {
    }

    public DivsambarContext(DbContextOptions<DivsambarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database= divsambar ;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Departmentid).HasName("pk_deptid");

            entity.ToTable("department");

            entity.Property(e => e.Departmentid)
                .ValueGeneratedNever()
                .HasColumnName("departmentid");
            entity.Property(e => e.Departmentname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("departmentname");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("pk_emp");

            entity.ToTable("employee");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Dateofbirth)
                .HasColumnType("date")
                .HasColumnName("dateofbirth");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empname");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("gender");

            entity.HasOne(d => d.Dept).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Deptid)
                .HasConstraintName("fk_emp");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
