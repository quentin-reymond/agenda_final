using System;
using System.Collections.Generic;

namespace brouillon_agenda.MusicDB;

public partial class Socialmedium
{
    public int Idsocialmedia { get; set; }

    public int ContactIdcontact { get; set; }

    public string Plateform { get; set; } = null!;

    public string Username { get; set; } = null!;

    public virtual Contact ContactIdcontactNavigation { get; set; } = null!;
}
