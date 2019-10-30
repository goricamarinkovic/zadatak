﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Humanity
{
    public class LogTest
    {
        public static void LogStep(string methodName, string stepName)
        {

            string name = @"C:\Test-Humanity\";
            string logPath = name + "20191030";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(logPath);

            using (StreamWriter writer = new StreamWriter(logPath + @"\" + "TestLogovanje.txt", true))
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(methodName + " " + stepName);
                writer.WriteLine();
            }
        }


        public static void LogPassedTest()
        {

            string name = @"C:\Test-Humanity\";
            string logPath = name + "20191030";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(logPath);

            using (StreamWriter writer = new StreamWriter(logPath + @"\" + "TestLogovanje.txt", true))
            {
                writer.WriteLine("TEST IS PASSED!");
                writer.WriteLine();
            }
        }


        public static void LogFailedTest()
        {

            string name = @"C:\Test-Humanity\";
            string logPath = name + "20191030";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(logPath);

            using (StreamWriter writer = new StreamWriter(logPath + @"\" + "TestLogovanje.txt", true))
            {
                writer.WriteLine("TEST IS FAILED!");
                writer.WriteLine();
            }
        }



        public static void LogEnd()
        {

            string name = @"C:\Test-Humanity\";
            string logPath = name + "20191030";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(logPath);

            using (StreamWriter writer = new StreamWriter(logPath + @"\" + "TestLogovanje.txt", true))
            {
                writer.WriteLine("---------------------------------------------------------------------------");
                writer.WriteLine();
            }
        }
    }
}
