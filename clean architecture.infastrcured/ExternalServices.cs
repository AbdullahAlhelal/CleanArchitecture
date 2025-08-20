using clean_architecture.Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Linq;


namespace clean_architecture.infastrcured
{
    public class ExternalServices : IExternalService


    {

        private HttpClient _httpClient;


        public ExternalServices()
        {
            _httpClient = new HttpClient();


        }
        public async ValueTask<TResult> Post<TResult, TRequest>(string url, TRequest Content)
        {
            var OContent = JsonConvert.SerializeObject(Content);

            var request = await _httpClient.PostAsync(url, new StringContent(OContent, System.Text.Encoding.UTF8, "appliction/json"));
            if (request.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TResult>(await request.Content.ReadAsStringAsync())!;
            }
            return default!;
        }

        public async ValueTask<HttpResponseMessage> Post<TRequest>(string url, TRequest Content)
        {
            var OContent = JsonConvert.SerializeObject(Content);

            var request = await _httpClient.PostAsync(url, new StringContent(OContent, System.Text.Encoding.UTF8, "appliction/json"));
           
            return request;
        }


        public async ValueTask<TResult> Get<TResult>(string url)
        {
           var Oresult = await _httpClient.GetStringAsync(url);

            return JsonConvert.DeserializeObject<TResult>(Oresult);
        }



        public async ValueTask<TResult> Put<TResult, TRequest>(string url, TRequest Content)
        {
            var OContent = JsonConvert.SerializeObject(Content);

            var request = await _httpClient.PutAsync(url, new StringContent(OContent, System.Text.Encoding.UTF8, "appliction/json"));
            if (request.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TResult>(await request.Content.ReadAsStringAsync())!;
            }
            return default!;
        }

        public async ValueTask<HttpResponseMessage> Put<TRequest>(string url, TRequest Content)
        {
          
            var OContent = JsonConvert.SerializeObject(Content);

            var request = await _httpClient.PutAsync(url, new StringContent(OContent, System.Text.Encoding.UTF8, "appliction/json"));
           
            return request;
        }
        public async ValueTask<HttpResponseMessage> Delete<TResult>(string url)
        {
            return await _httpClient.DeleteAsync(url);
        }
    }
}
