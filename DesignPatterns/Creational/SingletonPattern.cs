namespace DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// Ensure a class has only one instance, and provide a global point of access to it.
    /// </summary>
    public class SingletonPattern
    {
        public static void Test()
        {
            SettingProvider setting = SettingProvider.Default;
            var name = setting.Name;
        }
    }


    public class SettingProvider
    {
        public static SettingProvider Default { get; private set; }

        static SettingProvider()
        {
            Default = new SettingProvider()
            {
                Name = "Default Instance"
            };
        }

        SettingProvider()
        {
            
        }

        public string Name { get; set; }
    }
}