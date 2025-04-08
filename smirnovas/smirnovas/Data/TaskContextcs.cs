﻿using Microsoft.EntityFrameworkCore;
using smirnovas.Models;

namespace smirnovas.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}