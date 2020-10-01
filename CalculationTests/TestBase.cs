using BootStrapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace CalculationTests
{
    public class TestBase
    {
        private static AppSettings _appSettings;
        protected AppSettings AppSettings { get { return _appSettings; } }

        private static IServiceProvider _serviceProvider;

        protected IServiceProvider ServiceProvider { get { return _serviceProvider; } }

        public TestBase()
        {
            if (_appSettings == null)
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                _appSettings = Bootstrapper.GetJSONConfigFile<AppSettings>($"{ currentDirectory }\\appsettings.json", "AppSettings");
            }
            if (_serviceProvider == null)
            {
                // additional test-world services would get registered here
                _serviceProvider = Bootstrapper.ConfigureServices(_appSettings);
            }
        }
    }
}