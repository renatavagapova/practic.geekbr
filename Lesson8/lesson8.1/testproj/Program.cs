using System;
using System.Configuration;
using testproj.Properties;

namespace testproj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Resources.HelloWording);
            ReadAllSettings();
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            ReadSetting("Name");
            AddUpdateAppSettings("Name", name);
            Console.WriteLine("Введите ваш возраст");
            string age = Console.ReadLine();
            ReadSetting("Age");
            AddUpdateAppSettings("Age", age);
            Console.WriteLine("Чем вы занимаетесь?");
            string career = Console.ReadLine();
            ReadSetting("Career");
            AddUpdateAppSettings("Career", career);
            ReadAllSettings();

        }
        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
        static void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("{0}: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }
    }
}
