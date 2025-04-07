using System;
using System.Collections.Generic;

namespace brouillon_agenda.MusicDB;

public partial class Contact
{
    public int Idcontact { get; set; }

    public string Nom { get; set; } = null!;

    public string? Prenom { get; set; }

    public string? Email { get; set; }

    public string? NumeroTel { get; set; }

    public string? Addresse { get; set; }

    public virtual ICollection<Socialmedium> Socialmedia { get; set; } = new List<Socialmedium>();
}
