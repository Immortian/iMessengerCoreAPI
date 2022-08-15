using iMessengerCoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace iMessengerCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RGDialogsClientsController : ControllerBase
    {
        private readonly RGDialogsClients _model;
        public RGDialogsClientsController()
        {
            _model = new RGDialogsClients();
        }

        //Retern all dialogs in which the listed users are members
        // POST api/<RGDialogsClientsController>/list
        [HttpPost]
        [Route("[controller]/list")]
        public List<Guid> GDList([FromBody] List<Guid> value)
        {
            return _model.GetDialogList(value);
        }
        
        // POST api/<RGDialogsClientsController>
        [HttpPost]
        public Guid GDialog([FromBody] List<Guid> value)
        {
            return _model.GetDialog(value);
        }

    }
}
