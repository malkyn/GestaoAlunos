using GestaoAlunos.Application;
using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestaoAlunos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IApplicationServiceClient _application;
        public ClientController(IApplicationServiceClient application)
        {
            _application = application;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_application.GetAll());
        }

        
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_application.GetById(id));
        }

        
        [HttpPost]
        public ActionResult Post([FromBody] ClientDTO clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _application.Add(clienteDto);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        
        [HttpPut]
        public ActionResult Put([FromBody] ClientDTO clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _application.Update(clienteDto);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClientDTO clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _application.Remove(clienteDto);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
