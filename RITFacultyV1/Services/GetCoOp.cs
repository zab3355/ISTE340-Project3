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
    public class GetCoOp
    {
        public async Task<List<CoopInformation>> GetCoOpEmployment()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/employment/coopTable/coopInformation", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<CoopInformation>>>(data);

                    List<CoopInformation> coopTable = new List<CoopInformation>();
                    CoopInformation coop = new CoopInformation();

                    foreach (KeyValuePair<string, List<CoopInformation>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            coopTable.Add(item);
                        }
                    }

                    return coopTable;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<CoopInformation> coopTable = new List<CoopInformation>();
                    return coopTable;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<CoopInformation> coopTable = new List<CoopInformation>();
                    return coopTable;
                    //return "Exception";
                }
            }
        }
    }
}
