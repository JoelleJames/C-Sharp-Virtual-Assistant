using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

/* class to reuse and call internet (like a browser for the assistant)
 */
namespace AI_personal_assistant_Csharp
{
    public static class APIHelper
    {
        public static HttpClient apiClient { get; set; }

        public static void InitializeClient()
        {
            apiClient = new HttpClient();
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")); //give us json
        }
    }
}
