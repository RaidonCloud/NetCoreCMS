﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using NetCoreCMS.Framework.Modules;
using NetCoreCMS.Framework.Core.Models;
using NetCoreCMS.Framework.Core.Services;
using NetCoreCMS.Framework.Core.Repository;
using NetCoreCMS.Framework.Themes;
using NetCoreCMS.Framework.Modules.Widgets;
using Microsoft.AspNetCore.Routing;
using NetCoreCMS.Framework.Core.Data;

namespace NetCoreCMS.Core.Modules.Cms
{
    public class CmsModule : IModule
    {
        List<Widget> _widgets;
        public CmsModule()
        {
            
        }

        public string ModuleId { get; set; }
        public string ModuleTitle { get; set; }
        public string ModuleName { get; set; }
        public bool AntiForgery { get; set; }
        public string Author { get; set; }
        public string Website { get; set; }
        public string Version { get; set; }
        public string NetCoreCMSVersion { get; set; }
        public string Description { get; set; }
        public List<string> Dependencies { get; set; }
        public string Category { get; set; }
        public Assembly Assembly { get; set; }
        public string SortName { get; set; }
        public string Path { get; set; }
        public int ModuleStatus { get; set; }
        public List<Widget> Widgets { get { return _widgets; } set { _widgets = value; } }

        public bool Activate()
        {
            throw new NotImplementedException();
        }

        public bool Inactivate()
        {
            throw new NotImplementedException();
        }

        public void Init(IServiceCollection services)
        {
            services.AddTransient<NccPageRepository>();
            services.AddTransient<NccPageService>();
            services.AddTransient<NccCategoryRepository>();
            services.AddTransient<NccCategoryService>();            
        }

        public void RegisterRoute(IRouteBuilder routes)
        {
             
        }

        public bool Install(NccSettingsService settingsService, Func<NccDbQueryText, string> executeQuery)
        {
            return true;
        }

        public bool Uninstall(NccSettingsService settingsService, Func<NccDbQueryText, string> executeQuery)
        {
            return true;
        }
    }
}
