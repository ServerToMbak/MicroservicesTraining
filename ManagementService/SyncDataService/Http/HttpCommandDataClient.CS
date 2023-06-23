using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using ManagementService.Dtos;
using Microsoft.Extensions.Configuration;

namespace ManagementService.SyncDataService.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private  HttpClient _http;
        private  IConfiguration _config;
        

        public HttpCommandDataClient(HttpClient http,IConfiguration config)
        {
            _http =  http;
            _config = config;
        }
        public async Task SendManagementToCommand(ClassReadDto cl)
        {
            var httpContent = new StringContent(
                    JsonSerializer.Serialize(cl),
                    System.Text.Encoding.UTF8,
                    "application/Json");
            
            var response = await _http.PostAsync($"{_config["CommandService"]}", httpContent);
 
            if(response.IsSuccessStatusCode)
            {
                Console.WriteLine("Sync POST Success ");
            }
            else
            {
                Console.WriteLine("Sync POST Unsuccess");
            }
        }
    }
}