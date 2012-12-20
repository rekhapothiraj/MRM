using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace MRM.Mobile.Service.ConsoleTestHost
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var svcHost = new ServiceHost(typeof(MRM.Mobile.Service.DataService));

                svcHost.Open();

                Console.WriteLine("Simple Service is hosted");
                Console.ReadKey();

            }
            catch (System.Exception oEx)
            {
                Console.WriteLine("Exception: " + oEx.Message);
            }
            
           
        }
    
    }
}
