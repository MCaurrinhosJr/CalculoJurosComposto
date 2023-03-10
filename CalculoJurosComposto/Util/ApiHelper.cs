using Microsoft.AspNetCore.Http.HttpResults;
using System.Net.Http.Headers;

namespace CalculoJurosComposto.Util
{
    public class ApiHelper
    {
        static HttpClient client = new HttpClient();

        static ApiHelper()
        {
            client.BaseAddress = new Uri("http://taxajuros/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<double> GetAsync(string path)
        {
            var response = await client.GetAsync(path);
            response.EnsureSuccessStatusCode();
            
            return double.Parse(await response.Content.ReadAsStringAsync(), System.Globalization.CultureInfo.InvariantCulture);
            
        }
    }
}
