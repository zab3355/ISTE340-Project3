using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RITFacultyV1.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace RITFacultyV1.Services
{
    public class GetUndergraduate
    {
        public async Task<List<UnderGradMajors>> GetUnderGradDegrees()
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/degrees/undergraduate", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<UnderGradMajors>>>(data);

                    List<UnderGradMajors> undergradList = new List<UnderGradMajors>();
                    UnderGradMajors under = new UnderGradMajors();

                    foreach (KeyValuePair<string, List<UnderGradMajors>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            undergradList.Add(item);
                        }
                    }

                    return undergradList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<UnderGradMajors> undergradList = new List<UnderGradMajors>();
                    return undergradList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<UnderGradMajors> undergradList = new List<UnderGradMajors>();
                    return undergradList;
                    //return "Exception";
                }

            }
        }
    }
}
