using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Data.Helpers
{
    public class ApiEmpleados
    {
        private const string url = "http://masglobaltestapi.azurewebsites.net/api/Employees";
        public static HttpClient ApiClient { get; set; }

        public static async Task<List<T>> CargarDatosEmpleados<T>()
        {

            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (HttpResponseMessage response = await ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<T> employees = await response.Content.ReadAsAsync<List<T>>();

                    return employees;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }

        }
    }
}
