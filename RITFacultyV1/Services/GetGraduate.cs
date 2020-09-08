﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RITFacultyV1.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace RITFacultyV1.Services
{
    public class GetGraduate
    {
        public async Task<List<GradMajors>> GetGradDegrees()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/degrees", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<GradMajors>>>(data);

                    List<GradMajors> gradList = new List<GradMajors>();
                    GradMajors grad = new GradMajors();

                    foreach (KeyValuePair<string, List<GradMajors>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            gradList.Add(item);
                        }
                    }

                    return gradList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<GradMajors> gradList = new List<GradMajors>();
                    return gradList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<GradMajors> gradList = new List<GradMajors>();
                    return gradList;
                    //return "Exception";
                }
            }
        }
    }
}
