using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EventStore.ClientAPI;
using EventStore.ClientAPI.SystemData;
using Newtonsoft.Json;
using Registration.Application;
using Registration.Blueprint.Events;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {

            var app = new RegistrationApp();
            var eventNamespace = "Registration.Blueprint.Events";
            Bootstrap.ConfigureApp(app,eventNamespace);
           // Bootstrap.ConfigureController();
            app.Start();
            
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}
