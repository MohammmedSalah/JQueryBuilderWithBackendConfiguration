namespace JQueryBuilderWithBackendConfiguration
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class MyModel : DbContext
    {
        // Your context has been configured to use a 'MyModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'JQueryBuilderWithBackendConfiguration.MyModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyModel' 
        // connection string in the application configuration file.
        public MyModel()
            : base("name=MyModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Grade> Grads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasRequired<Grade>(I => I.CurrentGrade)
                .WithMany(J => J.Students)
                .HasForeignKey<int>(I => I.CurrentGradeId);
        }

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentGradeId { get; set; }
        public Grade CurrentGrade { get; set; }

    }
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
        public ICollection<Student> Students { get; set; }
    }

}