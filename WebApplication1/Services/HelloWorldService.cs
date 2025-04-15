using System.Net.Http;
using System.Threading.Tasks;

namespace SampleWebApp.Services
{
    public class HelloWorldService
    {
        private readonly HttpClient _httpClient;

        public HelloWorldService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetHelloWorldAsync()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:5001/api/HelloWorld");
            return response;
        }
    }
}
