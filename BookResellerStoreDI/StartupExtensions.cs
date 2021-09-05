﻿using BookResellerStoreBusinessServices;
using BookResellerStoreDataAccess;
using BookResellerStoreDataAccess.Db;
using IBookResellerStoreBusinessServices;
using IBookResellerStoreDataAccess.IRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookResellerStoreDI
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddServiceScribeCore(this IServiceCollection services)
        {

            // services.AddTransient<IEmailSender, EmailSender>();

            services.AddSingleton<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IBookInfoService, BookInfoService>();

            return services;
        }
    }
}
