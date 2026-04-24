using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GanttEF.Models;

public partial class EfWasmContext : DbContext
{
    public EfWasmContext()
    {
    }

    public EfWasmContext(DbContextOptions<EfWasmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TaskDatum> TaskData { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TaskDatum>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK_TaskData");

            entity.ToTable("taskData");

            entity.Property(e => e.TaskId)
                .ValueGeneratedNever()
                .HasColumnName("TaskID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TaskName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
