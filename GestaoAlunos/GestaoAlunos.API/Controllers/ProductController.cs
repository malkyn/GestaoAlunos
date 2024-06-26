using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestaoAlunos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IApplicationServiceProduct _application;
        public ProductController(IApplicationServiceProduct application)
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
        public ActionResult Post([FromBody] ProductDTO productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _application.Add(productDto);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        [HttpPut]
        public ActionResult Put([FromBody] ProductDTO productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _application.Update(productDto);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpDelete()]
        public ActionResult Delete([FromBody] ProductDTO productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _application.Remove(productDto);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
