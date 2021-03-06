﻿using Microsoft.EntityFrameworkCore;
using CorePractice.Application.Models;

namespace CorePractice.Infrastructure
{
    public class CoreContext : DbContext
    {
        private readonly DbContextOptions<CoreContext> _options;

        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Group> Groups { get; set; }


        private const string connectionString = @"server=coresample.database.windows.net; database=coresample;user id=coredev;password='s+_v_#anXLZHzzpzAgT'";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(entity =>
            {
                entity.HasKey(user => user.UserId);
            });

            builder.Entity<User>(entity =>
            {
                entity.Property(user => user.Username).HasMaxLength(50).IsRequired();
            });

            builder.Entity<User>(entity =>
            {
                entity.Property(user => user.Password).HasMaxLength(128).IsRequired();
            });

            builder.Entity<User>(entity =>
            {
                entity.Property(user => user.Firstname).HasMaxLength(100).IsRequired();
            });

            builder.Entity<User>(entity =>
            {
                entity.Property(user => user.Lastname).HasMaxLength(100).IsRequired();
            });

            builder.Entity<User>(entity =>
            {
                entity.Property(user => user.DateOfBirth);
            });

            builder.Entity<User>(entity =>
            {
                entity.Property(user => user.Email).HasMaxLength(256).IsRequired();
            });

            builder.Entity<User>(entity =>
            {
                entity.Property(user => user.Phone).HasMaxLength(50);
            });

            builder.Entity<User>(entity =>
            {
                entity.Property(user => user.Mobile).HasMaxLength(50);
            });

            // Create group properties

            builder.Entity<Group>(entity =>
            {
                entity.HasKey(group => group.GroupId);
            });

            builder.Entity<Group>(entity =>
            {
                entity.Property(group => group.GroupName).HasMaxLength(50).IsRequired();
            });

            builder.Entity<Group>(entity =>
            {
                entity.Property(group => group.Description).HasMaxLength(256);
            });

        }
    }
}
