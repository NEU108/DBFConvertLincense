using System;
using System.Collections.Generic;
using System.Text;

namespace DBFConvertLincense
{


    /*
     * 注册表里面有什么信息：
     * 
     * 软件安装时：
     * InstallTime:2015-12-12
     * 机器码的subkey:[  注册后：time，type,incname=key  ]
     * 
     * 
     */

    public static class RegHelper
    {
        private static string regPath="software\\DBFConvert\\DBFConvertSet\\";
        public static bool WriteToRegInstall(string code)
        {  
                try
                {
                    Microsoft.Win32.RegistryKey retkey =
                             Microsoft.Win32.Registry.CurrentUser.
                             OpenSubKey("software", true).CreateSubKey("DBFConvert").
                             CreateSubKey("DBFConvertSet");
                    retkey.SetValue("InstallTime", DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss"));
                    if (code != null && code != "")
                    {
                        retkey.CreateSubKey(code);
                    }
                    retkey.Close();

                    retkey = Microsoft.Win32.Registry.LocalMachine.
                            OpenSubKey("software", true).CreateSubKey("DBFConvert").
                             CreateSubKey("DBFConvertSet");
                    retkey.SetValue("InstallTime", DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss"));
                    if (code != null && code != "")
                    {
                       retkey =  retkey.CreateSubKey(code); 
                    }
                    retkey.Close();

                    return true;
                }
                catch (Exception e) 
                { 
                    //没有访问注册表的权限
                    return false;
                }
        }
    }
}
