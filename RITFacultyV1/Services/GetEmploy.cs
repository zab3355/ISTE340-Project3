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
    public class GetEmploy
    {
        public async Task<List<ProfessionalEmploymentInformation>> GetEmployment()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/employment/employmentTable/professionalEmploymentInformation", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<ProfessionalEmploymentInformation>>>(data);

                    List<ProfessionalEmploymentInformation> employmentTable = new List<ProfessionalEmploymentInformation>();
                    ProfessionalEmploymentInformation employment = new ProfessionalEmploymentInformation();

                    foreach (KeyValuePair<string, List<ProfessionalEmploymentInformation>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            employmentTable.Add(item);
                        }
                    }

                    return employmentTable;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<ProfessionalEmploymentInformation> employmentTable = new List<ProfessionalEmploymentInformation>();
                    return employmentTable;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<ProfessionalEmploymentInformation> employmentTable = new List<ProfessionalEmploymentInformation>();
                    return employmentTable;
                    //return "Exception";
                }
            }
        }
    }
}
