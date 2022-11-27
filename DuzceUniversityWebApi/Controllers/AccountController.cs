using DuzceUniversityWebApi.Model;
using DuzceUniversityWebApi.Model.ViewModel;
using DuzceUniversityWebApi.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
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
        public AccountController(UserManager<UserModel> userMgr,
                SignInManager<UserModel> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
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
    }
}
