using System;

using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Core.Configuration
{
    public class Configuration
    {
        private IDictionary _configValues;

        public Configuration()
        {
            LoadConfig();
        }

        public string GetValue(string key)
        {
            return _configValues.Contains(key) ? _configValues[key].ToString() : null;
        }


        private void LoadConfig()
        {
            /*
            ConfigurationFileManager configurationFileManager =
                new ConfigurationFileManager("config", "default.config").WithOverrideConfigFiles(new[]
                    {"overrides.config"});
            configurationFileManager.Load();

            _configValues = configurationFileManager.ConfigValues;
            */
        }
    }
}
