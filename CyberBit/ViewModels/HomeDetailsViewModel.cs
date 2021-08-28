using CyberBit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CyberBit.ViewModels
{
    public class HomeDetailsViewModel
    {
        public User User { get; set; }
        public IEnumerable<Models.Task> GetDoneTasks { get; set; }
        public IEnumerable<Models.Task> GetLateTasks { get; set; }
        public IEnumerable<Models.Task> GetOnTimeTasks { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Enter Task Title ")]
        public string TaskTitle { get; set; }

        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }
    }
}
