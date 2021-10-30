using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace PainChaos5.Controllers
{
    public class DataArray
    {
        public int[][] Data { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IHubContext<MessageHub> _hubContext;

        public ValuesController(IHubContext<MessageHub> hubContext)
        {
            _hubContext = hubContext;
        }


        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] DataArray value)
        {
            await _hubContext.Clients.All.SendAsync("PAINT", value);
        }
    }
}
