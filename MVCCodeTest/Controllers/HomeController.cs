using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCodeTest.Models;
using MvcCodeTestLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCodeTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;

        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Counter()
        {
            return View();
        }
        public IActionResult RemoteApi()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FormSubmit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult FormSubmit(LoginData model)
        {
            OperationResult retData = new OperationResult();

            try
            {

                // throw new Exception();


                if (ModelState.IsValid)
                {
                    retData.Message = "Login SUCCESS !";
                    retData.ModelErrors = new List<string>();
                    retData.StatusCode = 0;
                }
                else
                {
                    retData.Message = "Model is NOT Valid !";
                    retData.StatusCode = 1;
                    retData.ModelErrors = new List<string>();
                    foreach (var modelState in ViewData.ModelState.Values)
                    {
                        foreach (var error in modelState.Errors)
                        {
                            string mError = error.ErrorMessage.ToString();
                            retData.ModelErrors.Add(mError);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                retData.Message = "Server Error !";
                retData.ModelErrors = new List<string>();
                retData.StatusCode = -1;
            }
            return Json(new { Result = retData });
        }

        
        public IActionResult Paging()
        {
            var users = _userService.GetAllUsers();
            return View(users);
        }
        [HttpPost]
        public IActionResult DataByPaging([FromBody] DataByPagingDTO model)
        {
            var data = _userService.GetAllUsers()
                          .OrderBy(user => user.Id)
                          .Skip((model.CurrentPageNumber - 1) * model.RecordsPerPage)
                          .Take(model.RecordsPerPage).ToList();
            return PartialView("_DataByPaging", data);
        }


        public IActionResult MasterDetail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DataByUserDetail([FromBody] UserData model)
        {             
            return PartialView("_DataByUserDetail", model);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
