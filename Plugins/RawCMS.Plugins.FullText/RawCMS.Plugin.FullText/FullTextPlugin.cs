﻿//******************************************************************************
// <copyright file="license.md" company="RawCMS project  (https://github.com/arduosoft/RawCMS)">
// Copyright (c) 2019 RawCMS project  (https://github.com/arduosoft/RawCMS)
// RawCMS project is released under GPL3 terms, see LICENSE file on repository root at  https://github.com/arduosoft/RawCMS .
// </copyright>
// <author>Daniele Fontani, Emanuele Bucarelli, Francesco Min�</author>
// <autogenerated>true</autogenerated>
//******************************************************************************
using IdentityModel.AspNetCore.OAuth2Introspection;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RawCMS.Library.Core;
using RawCMS.Library.Core.Interfaces;
using System.Security.Claims;

namespace RawCMS.Plugins.FullText
{
    public class FullTextPlugin : RawCMS.Library.Core.Extension.Plugin, IConfigurablePlugin<FullTextConfig>
    {
        public override string Name => "Authorization";

        public override string Description => "Add authorizaton capabilities";

        private readonly FullTextConfig config;
        private AppEngine appEngine;

        public FullTextPlugin(AppEngine appEngine, FullTextConfig config, ILogger logger) : base(appEngine, logger)
        {
            this.appEngine = appEngine;
            this.config = config;
            Logger.LogInformation("FullTextPlugin plugin loaded");
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            
        }

        public override void Configure(IApplicationBuilder app)
        {
           
        }

        public override void ConfigureMvc(IMvcBuilder builder)
        {
         
        }

        public override void Setup(IConfigurationRoot configuration)
        {

        }
    }
}