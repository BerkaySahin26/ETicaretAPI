﻿using ETicaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class ETicaretAPIDbContext : DbContext
{
    public ETicaretAPIDbContext(DbContextOptions options) : base(options)
    {
    }

    
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
  

    
   
}
