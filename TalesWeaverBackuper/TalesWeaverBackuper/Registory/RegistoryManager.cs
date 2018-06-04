using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalesWeaverBackuper.Registory
{
    public class RegistoryManager
    {
        public static string GetRegistory(string keyPath, string key, RegistryHive hive, RegistryView view)
        {
            string value = null;

            try
            {
                using (var prerKey = RegistryKey.OpenBaseKey(hive, view))
                {
                    using (var rKey = prerKey.OpenSubKey(keyPath))
                    {
                        value = (string)rKey.GetValue(key);
                    }
                }
            }
            catch (Exception) { }

            return value;
        }

        public static void SetRegistory(string keyPath, string key, RegistryHive hive, RegistryView view, string data)
        {
            using (var prerKey = RegistryKey.OpenBaseKey(hive, view))
            {
                using (var rKey = prerKey.CreateSubKey(keyPath, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    rKey.SetValue(key, data);
                }
            }
        }
    }
}
