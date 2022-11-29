using LocalApiTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LocalApiTest.HTTPHelper
{
    public static class HttpClientHelper
    {


        // static async Task callAPI()
        //public static void callAPI()
        // {

        //     static async Task RunAsync()
        // {
        //     using (var client = new HttpClient())
        //     {
        //         client.BaseAddress = new Uri("https://localhost:7076/");
        //         client.DefaultRequestHeaders.Accept.Clear();
        //         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //         // HTTP GET
        //         HttpResponseMessage response = await client.GetAsync("api/client");
        //         if (response.IsSuccessStatusCode)
        //         {
        //             ClientCategory category = await response.Content.ReadAsAsync<ClientCategory>();
        //             Console.WriteLine("{0}\t${1}\t{2}", category.Id, category.CategoryName);
        //         }

        //    }
        //  }
        // }

            public static void callAPI(string apiUrl)
            {
            var json = "{\"msgInfo\":{\"versionNo\":\"1.0.0\",\"msgID\":\"U0053034420190808110118000001\",\"timeStamp\":\"20190808110118\",\"msgType\":\"DEBIT_TRANSACTION\",\"insID\":\"00530344\"},\"trxInfo\":{\"merchantInfo\":{\"acquirerIIN\":\"47010344\",\"fwdIIN\":\"00020344\",\"mid\":\"701034453110010\",\"merchantName\":\"testing merchant Macau MAC\",\"mcc\":\"5311\",\"merchantCountry\":\"344\",\"termId\":\"00104001\"},\"onUsFlag\":\"N\",\"debitAccountInfo\":\"eyJhbGciOiJSU0ExXzUiLCJlbmMiOiJBMTI4Q0JDLUhTMjU2Iiwia2lkIjoiMTU2MjAzMjg4NTk2MiJ9.IGVbmIFn7kqiSEQTYoCZDp7dxWHFKbgATceor14wOUjiTzjaq-BnKQ7UL8HEtT1K_OO2SmJf67-sREZ-widaS5gnjl_7vrDPMpRyitBnAsAaDcklcLq48CQ7jaTWrJg9te2m8U2VgyIdh7CVTpxS1yyon5CSTVSG94y qJm6O70Fh2zUDxqdPxXqfJj9bb1jMwofkOOwuHG-RhQNs6CP4zl22s7mnfg1h-tb-7J6BVD5Tu-zrt3VY6aAshooFDS63aesa9Xh7swQzBEIdBltSF-PHVMlok7_gnErTV MiiLRuonkPtZ801wvFaeH4Ppq9q3U1XGynSO7kbB6IlnHV2Hg.NDIxODViZDYyYzBkNGJjOA.Gt5I2aRcw0RL1YS860PDjXHoWQYtW9g6BT3snvFmCe0.gKc1fpZsZ3az 6jm7UpUoLA\",\"trxAmt\":\"2.22\",\"trxCurrency\":\"344\",\"billAmt\":\"2.22\",\"billCurrency\":\"344\",\"markupAmt\":\"0\",\"feeAmt\":\"0\",\"billConvRate\":\"1.000000\",\"settAmt\":\"0.28\",\"settCurrency\":\"840\",\"settConvRate\":\"0.1278459\",\"convDate\":\"0716\",\"settDate\":\"20190808\",\"posEntryModeCode\":\"042\",\"retrivlRefNum\":\"080887948744\"}}";
            //json deserialize

            CardStatusInquireRequestModel model = JsonConvert.DeserializeObject<CardStatusInquireRequestModel>(json);
              Console.WriteLine(model.msgInfo.msgID);
            HttpClient client = new HttpClient();
            
       //      //   client.DefaultRequestHeaders.Add("UPI-JWS", signature);
                try
                {

                    var url = apiUrl;
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
               //  //   request.Content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                    var information = client.SendAsync(request).Result;

                    if (information.IsSuccessStatusCode)
                    {
                        Console.Write("\n\nResponse: " + information.Content);
                    }
                    Console.Write("\n\nResponse: " + information);
                }
                catch (Exception ex)
                {
                    Console.Write("\n\nResponse: " + ex);
                }
            }
        }
}