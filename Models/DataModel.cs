using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using taskboard.Models;

namespace taskboard.Data
{
    public class TaskBoardDataContext : DbContext
    {
        public DbSet<TaskControlBoard> TaskControlBoards { get; set; }
        public DbSet<CardList> CardLists { get; set; }
        public DbSet<TaskCard> TaskCards { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<TaskTag> TaskTags { get; set; }
        public DbSet<TaskAppendixFile> TaskAppendixFiles { get; set; }
        


        public TaskBoardDataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

        }
    }
}