using CalculationEngine;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace BootStrapper
{
    public class Bootstrapper
    {
        public static IServiceProvider ConfigureServices(AppSettings appSettings)
        {
            return ConfigureServices(appSettings, new ServiceCollection());
        }

        public static IServiceProvider ConfigureServices(AppSettings appSettings, IServiceCollection services)
        {
            // singletons
            services.AddSingleton<AppSettings>(appSettings);

            // engines
            services.AddTransient<IMathEngine, MathEngine>();

            return services.BuildServiceProvider();
        }

        /// <summary>
        /// Method for reading your config file. I'm trying to make it easy for you.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public static T GetJSONConfigFile<T>(string path, string node) where T : class
        {
            var fileContents = File.ReadAllText(path);
            if (string.IsNullOrEmpty(fileContents))
            {
                throw new Exception("Config file is empty!");
            }
            if (string.IsNullOrEmpty(node))
            {
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            var jobject = JObject.Parse(fileContents);
            if (jobject[node] == null || !jobject[node].HasValues)
            {
                throw new Exception($"Config file node: { node } is empty!");
            }
            var nodeContents = jobject[node].ToString();
            return JsonConvert.DeserializeObject<T>(nodeContents);
        }
    }
}