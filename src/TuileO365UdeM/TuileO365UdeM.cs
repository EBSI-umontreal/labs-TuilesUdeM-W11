using System.Diagnostics;

namespace TuileO365UdeM
{
    class TuileO365UdeM
    {
        //Source : https://stackoverflow.com/questions/4580263/how-to-open-in-default-browser-in-c-sharp
        static void Main(string[] args)
        {

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C start http://o365.umontreal.ca",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };

            proc.Start();

        }
    }
}
