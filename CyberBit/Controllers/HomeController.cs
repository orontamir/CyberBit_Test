using CyberBit.Models;
using CyberBit.ViewModels;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberBit.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUser _user;
        private readonly ITask _task;
        private static HomeDetailsViewModel _homeDetailsViewModel;
        private static User _loginuser;
        public HomeController(IUser user, ITask task)
        {
            _user = user;
            _task = task;
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index()
        {
            return View(_homeDetailsViewModel);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(HomeDetailsViewModel model)
        {
            model.User = _user.GetUser(model.UserName);
            _loginuser = model.User;
            if (model.User != null)
            {
                model.GetDoneTasks =_task.GetDoneTasks(model.User.Id).ToList<Models.Task>();
                model.GetLateTasks = _task.GetLateTasks(model.User.Id).ToList<Models.Task>(); ;
                model.GetOnTimeTasks = _task.GetOnTimeTasks(model.User.Id).ToList<Models.Task>(); ;
            }
            _homeDetailsViewModel = model;
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Add(HomeDetailsViewModel model)
        {
           
            if (model != null && _loginuser != null && !string.IsNullOrEmpty(model.TaskTitle) && model.DueDate != null)
            {
                Models.TaskStatus mystatus = model.DueDate >= DateTime.Now ? Models.TaskStatus.OnTime : Models.TaskStatus.Late;
                Models.Task newTask = new Models.Task() { DueDate = model.DueDate, Title = model.TaskTitle, Status = mystatus,UserId = _loginuser.Id };
                _task.AddTask(newTask);
                model.User = _loginuser;
                model.UserName = _loginuser.Name;
                model.GetDoneTasks = _task.GetDoneTasks(model.User.Id).ToList<Models.Task>();
                model.GetLateTasks = _task.GetLateTasks(model.User.Id).ToList<Models.Task>(); ;
                model.GetOnTimeTasks = _task.GetOnTimeTasks(model.User.Id).ToList<Models.Task>(); ;
            }
            _homeDetailsViewModel = model;
            return RedirectToAction("index");
        }





    }
}
