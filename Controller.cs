using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutDownApp
{
    public class Controller
    {
        private static int[] options = { 1, 2, 3, 4, 5, 10, 20, 30, 60, 90, 120, 150, 180 };
        static string path = System.IO.Directory.GetCurrentDirectory();
        static double number = 0;
        static char separator = System.IO.Path.DirectorySeparatorChar;

        public static int GetOptions(int index)
        {
            return options[index] * 60;
        }

        public static int Calculated(int max)
        {
            double value = (number / double.Parse(max.ToString())) * 100;
            int result = Convert.ToInt32(value);
            return result;
        }

        public static void ResetNumber()
        {
            number = 0;
        }

        public static string[] GetTime(int minutes)
        {
            number += 1;

            double final_minutes = double.Parse(minutes.ToString()) - number;
            var result = TimeSpan.FromSeconds( final_minutes );

            string[] time = new string[3];

            time[0] = result.Hours < 10 ? "0" + result.Hours.ToString() : result.Hours.ToString();
            time[1] = result.Minutes < 10 ? "0" + result.Minutes.ToString() : result.Minutes.ToString();
            time[2] = result.Seconds < 10 ? "0" + result.Seconds.ToString() : result.Seconds.ToString();

            return time;
        }

        public static void SetOff(int duration, bool is_shutdown)
        {
            using (StreamWriter newTask = new StreamWriter(path + separator + "typeoff.bat", false))
            {
                string dur = duration.ToString();
                Console.WriteLine("Is Shutdown ? " + is_shutdown);
                string command = is_shutdown ? "shutdown -s -t" : "shutdown -r -t";

                string final_command = command + " " + dur;

                newTask.WriteLine(final_command);
                newTask.Flush();
                newTask.Close();
                newTask.Dispose();

                //To Run the batch file use below command
                System.Diagnostics.Process.Start(path + separator + "typeoff.bat");
            }
        }

        public static void CancelOff()
        {
            using (StreamWriter newTask = new StreamWriter(path + separator + "canceloff.bat", true))
            {
                var command = "shutdown -a";
                newTask.WriteLine(command);
                newTask.Flush();
                newTask.Close();
                newTask.Dispose();
            }
            System.Diagnostics.Process.Start(path + separator + "canceloff.bat");
        }
    }
}
