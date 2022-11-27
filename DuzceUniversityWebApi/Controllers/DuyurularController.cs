using DuzceUniversityWebApi.Model;
using DuzceUniversityWebApi.Model.ViewModel;
using DuzceUniversityWebApi.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DuzceUniversityWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("myclients")]
    public class DuyurularController : Controller
    {
        private IDuyurularRepository repository;
        private ResponseService resService = new ResponseService();
        public DuyurularController(IDuyurularRepository repo)
        {
            repository = repo;
        }
        // GET: api/<DuyurularController>
        [Route("DuyurularGet")]
        [HttpGet]
        public IEnumerable<Duyuru> Get()
        {
            return repository.Duyurulars;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<DuyurularController>/5
        [Route("DuyurularGetId")]
        [HttpGet]
        public Duyuru Get(int id)
        {
            return repository.Duyurulars.Where(d => d.Id == id).FirstOrDefault();
        }

        // POST api/<DuyurularController>
        [Authorize(Roles = "Administrator")]
        [Route("DuyuruCreate")]
        [HttpPost]
        public ActionResult DuyurularPost([FromBody] Duyuru postDu)
        {
            try
            {
                repository.CreateDuyuru(postDu);
                resService.Description = "Duyuru Eklendi.";
                resService.Result = 1;
                return Json(resService);
            }
            catch
            {
                resService.Description = "Duyuru ekleme işlemi başarısız";
                resService.Result = 0;
                return Json(resService);
            }
            
        }

        // PUT api/<DuyurularController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<DuyurularController>/5
        [Authorize(Roles = "Administrator")]
        [Route("DuyuruDelete")]
        [HttpDelete]
        public void Delete(int id)
        {
            Duyuru duyuru = repository.Duyurulars.Where(d => d.Id == id).FirstOrDefault();
            repository.DeleteDuyuru(duyuru);
        }
    }
}
