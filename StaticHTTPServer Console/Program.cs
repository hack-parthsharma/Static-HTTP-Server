using System;
using System.IO;


namespace StaticHttpSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();
            var port = 80;
            var httpServer = new StaticHttpServer(path, port);
            Console.WriteLine("-----[ Static Http Sharp ]-----");
            Console.WriteLine(string.Format("Starting on http://localhost:{0}", port));
            Console.WriteLine(string.Format("Watching at {0}", path));
            try
            {
                httpServer.Start();
            }
            catch (System.Net.Sockets.SocketException)
            {
                Console.WriteLine(string.Format("Port {0} occupied.",port));
                Console.WriteLine("Exiting...");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Unhandled Exception: {0}", ex.Message));
                Console.WriteLine("Exiting...");
                return;
            }
        }
    }
}
