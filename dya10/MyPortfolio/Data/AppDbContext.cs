﻿using Microsoft.EntityFrameworkCore;
using MyPortfolio.Models;

namespace MyPortfolio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        // CodeFirst로 테이블로 만들 엔티티 클래스 정의
        public DbSet<Board> board {  get; set; }      
    } 
}