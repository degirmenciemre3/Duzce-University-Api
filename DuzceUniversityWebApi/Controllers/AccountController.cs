using DuzceUniversityWebApi.Model;
using DuzceUniversityWebApi.Model.ViewModel;
using DuzceUniversityWebApi.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniversityWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("myclients")]
    public class AccountController : Controller
    {
        private UserManager<UserModel> userManager;
        private SignInManager<UserModel> signInManager;
        private ResponseService resService = new ResponseService();
        private IStudentRepository repo;
        public AccountController(UserManager<UserModel> userMgr,
                SignInManager<UserModel> signInMgr, IStudentRepository _repo)
        {
            userManager = userMgr;
            signInManager = signInMgr;
            repo = _repo;
        }

        [Route("AccountLogin")]
        [HttpPost]
        public async Task<ActionResult> Login( LoginModel loginModel)
        {
            UserModel user = await userManager.FindByNameAsync(loginModel.UserName);
            if (user != null)
            {
                await signInManager.SignOutAsync();
                if ((await signInManager.PasswordSignInAsync(user,
                        loginModel.Password, false, false)).Succeeded)
                {
                    resService.Description = "Giriş Başarılı";
                    resService.Result = 1;
                    return Json(resService);
                }
            }
            resService.Description = "Giriş Başarısız";
            resService.Result = 0;
            return Json(resService);
        }
        [Route("AccountLogout")]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            resService.Description = "Çıkış İşlemi Başarılı";
            resService.Result = 1;
            return Json(resService);
        }

        [Route("AccountRegister")]
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Register(RegisterModel registerModel)
        {
            IEnumerable<Students> students = repo.Students;
            Students student = students.Where(p => p.ogrenciMail == registerModel.ogrenciMail).FirstOrDefault();
            if (student != null)
            {
                resService.Description = "Bu Mail İle Bir Kayıt Zaten Var";
                resService.Result = 0;
                return Json(resService);
            }
            else
            {
                Students newStudent = new Students();
                newStudent.createdAt = DateTime.Now;
                newStudent.stajDurumu = registerModel.stajDurumu;
                newStudent.tecrube = registerModel.tecrube;
                newStudent.bolum = registerModel.bolum;
                newStudent.ogrenciMail = registerModel.ogrenciMail;
                newStudent.lastName = registerModel.lastName;
                newStudent.name = registerModel.name;
                newStudent.profileImage = registerModel.profileImage;
                newStudent.mezunDate = registerModel.mezunDate;
                repo.CreateStudent(newStudent);
                resService.Description = "Öğrenci Başarılı Bir Şekilde Kayıt Edildi";
                resService.Result = 1;
                return Json(resService);
            }
            
        }

        [Route("AccountGetById")]
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public Students AccountGetById(int _id)
        {
            Students student = repo.Students.Where(d => d.id == _id).FirstOrDefault();
            return student;
        }

        [Route("AccountGetByMail")]
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public Students AccountGetByNo(string _mail)
        {
            Students student = repo.Students.Where(d => d.ogrenciMail == _mail).FirstOrDefault();
            return student;
        }

        [Route("AccountGetByBolum")]
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public Students AccountGetByBolum(string _bolum)
        {
            Students student = repo.Students.Where(d => d.bolum == _bolum).FirstOrDefault();
            return student;
        }

        [Route("AccountGet")]
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IEnumerable<Students> AccountGet()
        {
            return repo.Students;
        }
    }
}
