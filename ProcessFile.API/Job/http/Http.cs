using Newtonsoft.Json;
using ProcessFile.API.Domain.Entities;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProcessFile.API.Job.http
{
    public class Http
    {
        public async Task<long> PostJob(string url)
        {
            HttpClient client = new HttpClient();

            string urlPost = url + "/JobEvent";

            HttpResponseMessage response = await client.PostAsync(urlPost, null);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var jobEntity = JsonConvert.DeserializeObject<JobEvent>(responseBody);
            return jobEntity.Id;
        }

        public static async Task UpdateJob(string url, long id)
        {
            HttpClient client = new HttpClient();

            string urlPost = url + "/JobEvent/" + id;

            HttpResponseMessage response = await client.PostAsync(urlPost, null);
            response.EnsureSuccessStatusCode();

            //string responseBody = await response.Content.ReadAsStringAsync();
        }

        public static async Task PostFile(string url, string filename, string subject)
        {
            HttpClient client = new HttpClient();

            string urlPost = url + "/Files?filename=" + filename + "&subject=" + subject;

            HttpResponseMessage response = await client.PostAsync(urlPost, null);
            response.EnsureSuccessStatusCode();

            //string responseBody = await response.Content.ReadAsStringAsync();
        }
    }
}
