namespace EventManagingSystem.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using EventManagingSystem.Entities;

    public partial class DataContextModel : DbContext
    {
        public DataContextModel()
            : base("name=DataContextModel")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventPerson> EventPerson { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Event)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventPerson)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Event)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.EventPerson)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Message)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.MessageFrom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Message1)
                .WithRequired(e => e.Person1)
                .HasForeignKey(e => e.MessageTo)
                .WillCascadeOnDelete(false);
        }
    }
}
