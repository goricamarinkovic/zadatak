using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Humanity
{
    public class EmployeeTest
    {
        public static void EmployeeStep(string methodName, string stepName)
        {

            string name = @"C:\Test-Humanity\";
            string employeePath = name + "20191030";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(employeePath);

            using (StreamWriter writer = new StreamWriter(employeePath + @"\" + "TestEmployee.txt", true))
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(methodName + " " + stepName);
                writer.WriteLine();
            }
        }
        public static void EmployeePassedTest()
        {

            string name = @"C:\Test-Humanity\";
            string employeePath = name + "20191030";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(employeePath);

            using (StreamWriter writer = new StreamWriter(employeePath + @"\" + "TestEmployee.txt", true))
            {
                writer.WriteLine("TEST IS PASSED!");
                writer.WriteLine();
            }
        }

        public static void EmployeeFailedTest()
        {

            string name = @"C:\Test-Humanity\";
            string employeePath = name + "20191030";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(employeePath);

            using (StreamWriter writer = new StreamWriter(employeePath + @"\" + "TestEmployee.txt", true))
            {
                writer.WriteLine("TEST IS FAILED!");
                writer.WriteLine();
            }
        }

        public static void EmployeeEnd()
        {

            string name = @"C:\Test-Humanity\";
            string employeePath = name + "20191030";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(employeePath);

            using (StreamWriter writer = new StreamWriter(employeePath + @"\" + "TestEmployee.txt", true))
            {
                writer.WriteLine("---------------------------------------------------------------------------");
                writer.WriteLine();
            }
        }

    }
}
