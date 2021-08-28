using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberBit.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public TaskStatus Status { get; set; }

    }
}
