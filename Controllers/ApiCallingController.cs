using LocalApiTest.HTTPHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalApiTest.Controllers
{
    public static class ApiCallingController
    {
      //  public static string json { get; private set; }

        public static void APIClient()
        {
             var url = "https://localhost:7076/api/client";

            //Console.Write("\n");
            HttpClientHelper.callAPI(url);
            Console.WriteLine("Hello World");
        }
          
        
    }
}
