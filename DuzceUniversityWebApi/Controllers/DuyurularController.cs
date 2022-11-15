using DuzceUniversityWebApi.Model;
using DuzceUniversityWebApi.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DuzceUniversityWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuyurularController : ControllerBase
    {
        private IDuyurularRepository repository;
        private DuyuruViewModel viewModel;
        public DuyurularController(IDuyurularRepository repo)
        {
            repository = repo;
            viewModel = new DuyuruViewModel
            {
                Duyurulars = repository.Duyurulars
            };
        }
        // GET: api/<DuyurularController>
        [HttpGet]
        public IEnumerable<Duyuru> Get()
        {
            return repository.Duyurulars;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<DuyurularController>/5
        [HttpGet("{id}")]
        public Duyuru Get(int id)
        {
            return repository.Duyurulars.Where(d => d.Id == id).FirstOrDefault();
        }

        // POST api/<DuyurularController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<DuyurularController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<DuyurularController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
