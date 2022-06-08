using System.Diagnostics;

namespace TuileStudiUM
{
    class TuileStudiUM
    {
        //Source : https://stackoverflow.com/questions/4580263/how-to-open-in-default-browser-in-c-sharp
        static void Main(string[] args)
        {

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C start https://studium.umontreal.ca/",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };

            proc.Start();

        }
    }
}
