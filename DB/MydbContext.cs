using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace brouillon_agenda.MusicDB;

public partial class MydbContext : DbContext
{
    public MydbContext()
    {
    }

    public MydbContext(DbContextOptions<MydbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<EventTask> EventTasks { get; set; }

    public virtual DbSet<Socialmedium> Socialmedia { get; set; }

    public virtual DbSet<Todotask> Todotasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=mydb", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.21-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Idcontact).HasName("PRIMARY");

            entity.ToTable("contact");

            entity.HasIndex(e => e.Email, "email_UNIQUE").IsUnique();

            entity.HasIndex(e => e.Idcontact, "idtable1_UNIQUE").IsUnique();

            entity.Property(e => e.Idcontact).HasColumnName("idcontact");
            entity.Property(e => e.Addresse)
                .HasMaxLength(100)
                .HasColumnName("addresse");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Nom)
                .HasMaxLength(25)
                .HasColumnName("nom");
            entity.Property(e => e.NumeroTel)
                .HasMaxLength(15)
                .HasColumnName("numero_tel");
            entity.Property(e => e.Prenom).HasMaxLength(20);
        });

        modelBuilder.Entity<EventTask>(entity =>
        {
            entity.HasKey(e => e.Idevent).HasName("PRIMARY");

            entity.ToTable("event_task");

            entity.HasIndex(e => e.TodotaskIdtask, "fk_event_task_todotask1_idx");

            entity.Property(e => e.Idevent).HasColumnName("idevent");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EventTaskcol)
                .HasMaxLength(45)
                .HasColumnName("event_taskcol");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Title)
                .HasMaxLength(45)
                .HasColumnName("title");
            entity.Property(e => e.TodotaskIdtask).HasColumnName("todotask_idtask");

            entity.HasOne(d => d.TodotaskIdtaskNavigation).WithMany(p => p.EventTasks)
                .HasForeignKey(d => d.TodotaskIdtask)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_event_task_todotask1");
        });

        modelBuilder.Entity<Socialmedium>(entity =>
        {
            entity.HasKey(e => e.Idsocialmedia).HasName("PRIMARY");

            entity.ToTable("socialmedia");

            entity.HasIndex(e => e.ContactIdcontact, "fk_socialmedia_Contact_idx");

            entity.Property(e => e.Idsocialmedia).HasColumnName("idsocialmedia");
            entity.Property(e => e.ContactIdcontact).HasColumnName("Contact_idcontact");
            entity.Property(e => e.Plateform)
                .HasMaxLength(45)
                .HasColumnName("plateform");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.ContactIdcontactNavigation).WithMany(p => p.Socialmedia)
                .HasForeignKey(d => d.ContactIdcontact)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_socialmedia_Contact");
        });

        modelBuilder.Entity<Todotask>(entity =>
        {
            entity.HasKey(e => e.Idtask).HasName("PRIMARY");

            entity.ToTable("todotask");

            entity.Property(e => e.Idtask).HasColumnName("idtask");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Statue)
                .HasColumnType("enum('pending','completed','overdue')")
                .HasColumnName("statue");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
