﻿using Microsoft.EntityFrameworkCore;
using PrivateBlog.Web.Data;

namespace PrivateBlog.Web
{
    public static class CustomConfiguration
    {
        public static WebApplicationBuilder AddCustomBuilderConfiguration(this WebApplicationBuilder builder)
        {
            //Data Context
            builder.Services.AddDbContext<DataContext>(Configuration =>
            {
                Configuration.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"));
            });
            return builder;
        }
    }
}
