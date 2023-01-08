using DuzceUniversityWebApi.Model;
using DuzceUniversityWebApi.Model.ViewModel;
using DuzceUniversityWebApi.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniversityWebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("myclients")]
    public class YayinlarController : Controller
    {
        private IYayinRepository repository;
        private ResponseService resService = new ResponseService();
        public YayinlarController(IYayinRepository repo)
        {
            repository = repo;
        }
        // GET: api/<YayinlarController>
        [Route("YayinlarGet")]
        [HttpGet]
        public IEnumerable<Yayin> Get()
        {
            return repository.Yayinlars;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<YayinlarController>
        [Route("YayinlarGetId")]
        [HttpGet]
        public Yayin Get(int id)
        {
            return repository.Yayinlars.Where(d => d.Id == id).FirstOrDefault();
        }

        // POST api/<YayinlarController>
        [Authorize(Roles = "Administrator")]
        [Route("YayinCreate")]
        [HttpPost]
        public ActionResult YayinlarPost([FromBody] Yayin postDu)
        {
            try
            {
                repository.CreateYayin(postDu);
                resService.Description = "Yayin Eklendi.";
                resService.Result = 1;
                return Json(resService);
            }
            catch
            {
                resService.Description = "Yayin ekleme işlemi başarısız";
                resService.Result = 0;
                return Json(resService);
            }

        }

        // PUT api/<YayinlarController>
        [Authorize(Roles = "Administrator")]
        [Route("YayinUpdate/{id:int}")]
        [HttpPut]
        public ActionResult Put(int id, [FromBody] UpdateYayinViewModel yay)
        {
            try
            {
                var yayin = repository.Yayinlars.FirstOrDefault(p => p.Id == id);
                yayin.description = yay.description;
                yayin.date = yay.date;
                yayin.title = yay.title;
                yayin.imgUrl = yay.imgUrl;
                yayin.category = yay.category;
                repository.SaveYayin(yayin);
                resService.Description = "Yayın Güncellendi.";
                resService.Result = 1;
                return Json(resService);
            }
            catch
            {
                resService.Description = "Yayın güncelleme işlemi başarısız";
                resService.Result = 0;
                return Json(resService);
            }
        }

        // DELETE api/<YayinlarController>
        [Authorize(Roles = "Administrator")]
        [Route("YayinDelete")]
        [HttpDelete]
        public void Delete(int id)
        {
            Yayin yayin = repository.Yayinlars.Where(d => d.Id == id).FirstOrDefault();
            repository.DeleteYayin(yayin);
        }

    }
}
