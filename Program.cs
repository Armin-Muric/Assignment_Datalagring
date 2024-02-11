﻿using Assignment_Datalagring.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\46704\source\repos\Assignment_Datalagring\Assignment_Datalagring\Data\database.mdf;Integrated Security=True;Connect Timeout=30"));
}).Build();