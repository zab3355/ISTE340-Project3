using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MyFirstMultiPlatform.Models;

namespace MyFirstMultiPlatform
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Task<List<UnderGradMajors>> apiCall = GetDegrees();
            var result = await apiCall;

            foreach(var item in result)
            {
                Console.WriteLine(item.title);
                Console.WriteLine(item.degreeName);
                Console.WriteLine(item.description);
                foreach(var item1 in item.concentrations)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine("\n\n");
            }

            return;
        }

        public static async Task<List<UnderGradMajors>> GetDegrees()
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                
                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync("api/degrees/undergraduate/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data1 = response.Content;
                    var data = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<UnderGradMajors>>>(data);
                    List<UnderGradMajors> underGradList = new List<UnderGradMajors>();
                    UnderGradMajors underGradMajors = new UnderGradMajors();

                    foreach (KeyValuePair<string, List<UnderGradMajors>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            underGradList.Add(item);
                        }
                    }

                    return underGradList;



                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<UnderGradMajors> underGradMajorsList = new List<UnderGradMajors>();
                    return underGradMajorsList;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<UnderGradMajors> underGradMajorsList = new List<UnderGradMajors>();
                    return underGradMajorsList;
                }
            }
        }
    }
}
