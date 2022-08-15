using iMessengerCoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

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

        //Return all dialogs in which the listed clients are members
        // POST api/<RGDialogsClientsController>/list
        [HttpPost]
        [Route("[controller]/list")]
        public List<Guid> GDList([FromBody] List<Guid> value)
        {
            return _model.GetDialogList(value);
        }
        
        //Return dialog in which only listed clients are members
        // POST api/<RGDialogsClientsController>
        [HttpPost]
        public Guid GDialog([FromBody] List<Guid> value)
        {
            return _model.GetDialog(value);
        }

    }
}
