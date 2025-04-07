using System;
using System.Collections.Generic;

namespace brouillon_agenda.MusicDB;

public partial class Todotask
{
    public int Idtask { get; set; }

    public string Description { get; set; } = null!;

    public DateOnly Date { get; set; }

    public string? Statue { get; set; }

    public virtual ICollection<EventTask> EventTasks { get; set; } = new List<EventTask>();
}
