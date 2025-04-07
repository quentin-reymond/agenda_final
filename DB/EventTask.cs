using System;
using System.Collections.Generic;

namespace brouillon_agenda.MusicDB;

public partial class EventTask
{
    public int Idevent { get; set; }

    public int TodotaskIdtask { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? EventTaskcol { get; set; }

    public virtual Todotask TodotaskIdtaskNavigation { get; set; } = null!;
}
