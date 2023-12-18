using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsumoApi_Aluno.Entities.Services
{
    public class AlunoServices
    {
        public async Task<Aluno> Integracao (int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"http://localhost:5228/aluno/{id}");
            var jsonString = await response.Content.ReadAsStringAsync();

            Aluno jsonObject = JsonConvert.DeserializeObject<Aluno>(jsonString);

            if(jsonObject != null) {
                return jsonObject;
            } else
             { 
                return new Aluno {Verifica = true};
                }
        }
    }
}