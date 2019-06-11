using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MultipleContractServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host=new ServiceHost(typeof(MultipleContractService.CompanyService)))
            {
                host.Open();
                Console.WriteLine("MultipleContractService Host Started at " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
