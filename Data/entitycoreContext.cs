using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PrivateLessons.Data

{
   public partial class entitycoreContext : DbContext
{
 public entitycoreContext  (
            DbContextOptions<entitycoreContext> options)
            : base(options)
        {
        }

 //----------------------------------------------------------------       
public virtual DbSet<Models.subject> subject { get; set; }
public virtual DbSet<Models.users> users {get; set;}
public virtual DbSet<Models.user_types> user_types {get; set;}
public virtual DbSet<Models.teachers> teachers{get; set;}
public virtual DbSet<Models.answers> answers{get; set;}
public virtual DbSet<Models.book> book{get; set;}
public virtual DbSet<Models.exam_question> exam_question{get; set;}
public virtual DbSet<Models.exam> exam{get; set;}
public virtual DbSet<Models.question> question{get; set;}
public virtual DbSet<Models.student_answer> student_answer{get; set;}
public virtual DbSet<Models.student_exams> student_exams{get; set;}
public virtual DbSet<Models.student_subject_registration> student_subject_registration{get; set;}
public virtual DbSet<Models.students> students{get; set;}
public virtual DbSet<Models.subject_teachers> subject_teachers{get; set;}

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{

optionsBuilder.UseNpgsql(@"Host=localhost;Database=PLS;Username=postgres;Password=12345");
}
//model builder for item table
  


        protected  void OnModel(ModelBuilder modelBuilder1)
        {
            modelBuilder1.Entity<Models.user_types>(entity =>
            {
              

                entity.ToTable("user_types", "public");
                entity.Property(e => e.type_id).HasColumnName("user_id");

                entity.Property(e => e.type_name)
                    .HasColumnName("type_name")
                    .HasColumnType("text")
                    .HasMaxLength(14);

            });
        }




}
}