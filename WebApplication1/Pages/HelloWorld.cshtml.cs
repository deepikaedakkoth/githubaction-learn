using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleWebApp.Services;
using System.Threading.Tasks;

namespace SampleWebApp.Pages
{
    public class HelloWorldModel : PageModel
    {
        private readonly HelloWorldService _helloWorldService;

        public HelloWorldModel(HelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        public string Message { get; private set; }

        public async Task OnGetAsync()
        {
            Message = await _helloWorldService.GetHelloWorldAsync();
        }
    }
}
