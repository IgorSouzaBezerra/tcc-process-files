﻿using Newtonsoft.Json;
using ProcessFile.API.Domain.Entities;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProcessFile.API.Job.http
{
    public class Http
    {
        public async Task<long> PostJob()
        {
            HttpClient client = new HttpClient();

            string url = @"https://tcc-process-files.herokuapp.com/JobEvent";

            HttpResponseMessage response = await client.PostAsync(url, null);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var jobEntity = JsonConvert.DeserializeObject<JobEvent>(responseBody);
            return jobEntity.Id;
        }

        public static async Task UpdateJob(long id)
        {
            HttpClient client = new HttpClient();

            string url = @"https://tcc-process-files.herokuapp.com/JobEvent/" + id;

            HttpResponseMessage response = await client.PostAsync(url, null);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
        }

        public static async Task PostFile(string filename, string subject)
        {
            HttpClient client = new HttpClient();

            string url = @"https://tcc-process-files.herokuapp.com/Files?filename=" + filename + "&subject=" + subject;

            HttpResponseMessage response = await client.PostAsync(url, null);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
        }
    }
}
