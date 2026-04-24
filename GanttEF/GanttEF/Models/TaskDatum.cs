using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace GanttEF.Models;

public partial class TaskDatum
{
    [Key]
    public int TaskId { get; set; }

    public string? TaskName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? ParentId { get; set; }

    public int? Progress { get; set; }

    public int? Duration { get; set; }
}
