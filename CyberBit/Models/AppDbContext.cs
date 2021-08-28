using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace CyberBit.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
             : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Task> Tasks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Oron",
                },
                 new User
                 {
                     Id = 2,
                     Name = "Tamir",
                 },
                new User
                {
                    Id = 3,
                    Name = "Naama",
                },
                 new User
                 {
                     Id = 4,
                     Name = "Shmuel",
                 },
                new User
                {
                    Id = 5,
                    Name = "Yusi",
                },
                 new User
                 {
                     Id = 6,
                     Name = "dotan",
                 }
                );

            modelBuilder.Entity<Task>().HasData(
                new Task
                {
                    Id = 1,
                    UserId = 1,
                    Title = "working",
                    DueDate = DateTime.Parse("2020-02-01 00:00:00.0000000"),
                    Status = TaskStatus.Done
                },
                 new Task
                 {
                     Id = 2,
                     UserId = 1,
                     Title = "eating",
                     DueDate = DateTime.Parse("2021-02-02 00:00:00.0000000"),
                     Status = TaskStatus.Done
                 },
                new Task
                {
                    Id = 3,
                    UserId = 1,
                    Title = "working",
                    DueDate = DateTime.Parse("2020-02-01 00:00:00.0000000"),
                    Status = TaskStatus.Late
                },
                 new Task
                 {
                     Id = 4,
                     UserId = 1,
                     Title = "sleeping",
                     DueDate = DateTime.Parse("2021-08-27 11:11:00.0000000"),
                     Status = TaskStatus.Late

                 },
                new Task
                {
                    Id = 5,
                    UserId = 2,
                    Title = "testing",
                    DueDate = DateTime.Parse("2021-08-26 11:09:00.0000000"),
                    Status = TaskStatus.OnTime
                },
                 new Task
                 {
                     Id = 6,
                     UserId = 2,
                     Title = "leaving",
                     DueDate = DateTime.Parse("2020-02-02 00:00:00.0000000"),
                     Status = TaskStatus.OnTime
                 }
                );
        }
    }
}
