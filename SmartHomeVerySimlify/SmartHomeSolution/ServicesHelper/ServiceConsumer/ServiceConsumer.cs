using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartHome.Services.ServiceConsumer
{
    public class ServiceConsumer<T, K> : IServiceConsumer<T, K>
    {
        private string _baseUrl;
        private string _endpoint;

        public ServiceConsumer(string baseUrl, string endpoint)
        {
            this._baseUrl = baseUrl;
            this._endpoint = endpoint;
        }

        public async Task<K> PostAsync(T request)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                var ext = JsonConvert.SerializeObject(request);
                var response = await client.PostAsJsonAsync(_endpoint, request).ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsAsync<K>();
                    return result;
                }
            }

            return default(K);
        }

        public async Task<K> PutAsync2(T request)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                var response = await client.PutAsJsonAsync(_endpoint, request).ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsAsync<K>();
                    return result;
                }
            }

            return default(K);
        }
        public K PostLogged(T request, ref string log)
        {
            log = "started";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                log = string.Format("about to make request to {0}", _baseUrl);

                var response = client.PostAsJsonAsync(_endpoint, request).Result;

                log = string.Format("received response {0} from {1}", response.StatusCode.ToString(), _baseUrl);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = response.Content.ReadAsAsync<K>().Result;
                    return result;
                }
            }

            return default(K);
        }

        public async Task<K> PostAsync(T request, string authToken)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);

                var response = await client.PostAsJsonAsync(_endpoint, request).ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsAsync<K>();
                    return result;
                }
                else throw new InvalidOperationException("Failed the POST http request");
            }
        }

        public async Task<bool> PutAsync(T request)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                var response = await client.PutAsJsonAsync(_endpoint, request).ConfigureAwait(false);
                return response.StatusCode == HttpStatusCode.OK;
            }
        }
        public async Task<bool> PutAsync(T request, string authToken)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                var response = await client.PutAsJsonAsync(_endpoint, request).ConfigureAwait(false);
                return response.StatusCode == HttpStatusCode.OK;
            }
        }

        public async Task<K> GetAsync(string qryString)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                var response = await client.GetAsync(string.Format("{0}?{1}", _endpoint, qryString)).ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsAsync<K>();
                    return result;
                }
            }

            return default(K);
        }


        public async Task<K> GetAsync(string qryString, string authToken)
        {
            using (var client = new HttpClient())
            {
                var requestUrl = string.Format("{0}/{1}?{2}", _baseUrl, _endpoint, qryString);

                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(requestUrl),
                    Method = HttpMethod.Get,
                };

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authToken);

                var response = await client.SendAsync(request).ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsAsync<K>();
                    return result;
                }
                else throw new InvalidOperationException(string.Format("Failed the GET http request: {0}", response.StatusCode));
            }

            // return default(K);
        }



        public async Task<K> DeleteAsync(string qryString, string authToken)
        {
            using (var client = new HttpClient())
            {
                var requestUrl = string.Format("{0}{1}?{2}", _baseUrl, _endpoint, qryString);

                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(requestUrl),
                    Method = HttpMethod.Delete,
                };

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authToken);

                var response = await client.SendAsync(request).ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsAsync<K>();
                    return result;
                }
                else throw new InvalidOperationException("Failed the DELETE http request");
            }
        }
    }
}
