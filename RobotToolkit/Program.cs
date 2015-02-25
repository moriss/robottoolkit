/* Program.cs
 * 
 * Copyright 2015 Istvan Telek
 * 
 * Main source file of ROBOTC license remover application.
 * Code is released under the MIT license. Read LICENSE.md for more information.
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace RobotToolkit
{
    class Program
    {
        static void Main(string[] args)
        {

            bool waitForUser = false;

            /* Check for wait parameter */
            if (args.Length != 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "-wait" || args[i] == "/wait")
                    {
                        waitForUser = true;
                    }
                }
            }

            /* Try 64-bit Windows versions */
            Console.WriteLine("Trying 64-bit structure...");
            Console.WriteLine();

            try
            {
                string keyPath = @"Software\Wow6432Node\Robomatter Inc\ROBOTC - LEGO 4.x RC\LicenseData";
                RegistryKey testKey = Registry.LocalMachine.OpenSubKey(keyPath, true);
                testKey.DeleteValue("LicenseFile", false);
                testKey.DeleteValue("AliasFile1", false);
                testKey.DeleteValue("AliasFile2", false);
                testKey.Close();
                Console.WriteLine("ROBOTC LEGO RC License succesfully deleted.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not delete ROBOTC LEGO RC License!");
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                string keyPath = @"Software\Wow6432Node\Robomatter Inc\ROBOTC - LEGO RVW 4.x\LicenseData";
                RegistryKey testKey = Registry.LocalMachine.OpenSubKey(keyPath, true);
                testKey.DeleteValue("LicenseFile", false);
                testKey.DeleteValue("AliasFile1", false);
                testKey.DeleteValue("AliasFile2", false);
                testKey.Close();
                Console.WriteLine("ROBOTC LEGO RVW License succesfully deleted.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not delete ROBOTC LEGO RVW License!");
                Console.WriteLine("Error: " + e.Message);
            }

            /* Try 32-bit Windows versions */
            Console.WriteLine();
            Console.WriteLine("Trying 32-bit structure...");
            Console.WriteLine();

            try
            {
                string keyPath = @"Software\Robomatter Inc\ROBOTC - LEGO 4.x RC\LicenseData";
                RegistryKey testKey = Registry.LocalMachine.OpenSubKey(keyPath, true);
                testKey.DeleteValue("LicenseFile", false);
                testKey.DeleteValue("AliasFile1", false);
                testKey.DeleteValue("AliasFile2", false);
                testKey.Close();
                Console.WriteLine("ROBOTC LEGO RC License succesfully deleted.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not delete ROBOTC LEGO RC License!");
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                string keyPath = @"Software\Robomatter Inc\ROBOTC - LEGO RVW 4.x\LicenseData";
                RegistryKey testKey = Registry.LocalMachine.OpenSubKey(keyPath, true);
                testKey.DeleteValue("LicenseFile", false);
                testKey.DeleteValue("AliasFile1", false);
                testKey.DeleteValue("AliasFile2", false);
                testKey.Close();
                Console.WriteLine("ROBOTC LEGO RVW License succesfully deleted.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not delete ROBOTC LEGO RVW License!");
                Console.WriteLine("Error: " + e.Message);
            }

            if (waitForUser)
            {
                Console.WriteLine();
                Console.Write("Press any key to exit...");
                Console.ReadKey();
            }           
        }
    }
}
