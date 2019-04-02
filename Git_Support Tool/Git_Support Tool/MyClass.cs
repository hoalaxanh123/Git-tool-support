using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Support_Tool
{
    public class MyClass
    {
        public List<String> GetSetting()
        {
            if(!File.Exists("config.inf"))
            {
                using (StreamWriter sw = new StreamWriter("config.inf", true))
                {
                    //write to the file
                }
            }
            List<String> result = new List<string>();
            try
            {
                // tao instance cua StreamReader de doc mot file.
                // lenh using cung duoc su dung de dong StreamReader.
                using (StreamReader sr = new StreamReader("config.inf"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        result.Add(line);
                    }
                }
            }
            catch (Exception)
            {
            }

            return result;
        }

        public void SaveSetting(string remoteLink, string projectLink)
        {
            using (StreamWriter sw = new StreamWriter("config.inf"))
            {
                sw.WriteLine(remoteLink);
                sw.WriteLine(projectLink);
            }
        }

        public string Do(string command, string WorkingDirectory)
        {
            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            //helps to hide the black console window from user completely
            pProcess.StartInfo.CreateNoWindow = true;

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = "git";

            //strCommandParameters are parameters to pass to program
            pProcess.StartInfo.Arguments = command;

            pProcess.StartInfo.UseShellExecute = false;

            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;

            //Optional
            pProcess.StartInfo.WorkingDirectory = WorkingDirectory;

            //Start the process
            pProcess.Start();

            //Get program output
            string strOutput = pProcess.StandardOutput.ReadToEnd();

            //Wait for process to finish
            pProcess.WaitForExit();

            return strOutput;
        }
        public string Do2(string command, string WorkingDirectory)
        {
            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            //show to hide the black console window from user completely
            pProcess.StartInfo.CreateNoWindow = false;

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = "git";

            //strCommandParameters are parameters to pass to program
            pProcess.StartInfo.Arguments = command;

            pProcess.StartInfo.UseShellExecute = false;

            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;

            //Optional
            pProcess.StartInfo.WorkingDirectory = WorkingDirectory;

            //Start the process
            pProcess.Start();

            //Get program output
            string strOutput = pProcess.StandardOutput.ReadToEnd();

            //Wait for process to finish
            pProcess.WaitForExit();

            return strOutput;
        }
    }
}
