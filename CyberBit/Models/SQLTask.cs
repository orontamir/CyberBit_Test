using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberBit.Models
{
    public class SQLTask : ITask
    {

        public Task AddTask(Task task)
        {
            context.Tasks.Add(task);
            context.SaveChanges();
            return task;
        }

        private readonly AppDbContext context;
        public SQLTask(AppDbContext _context)
        {
            this.context = _context;
        }
        public IEnumerable<Task> GetDoneTasks(int userid)
        {
            return context.Tasks.Where(o => o.UserId == userid && o.Status == TaskStatus.Done );
        }

        public IEnumerable<Task> GetLateTasks(int userid)
        {
            return context.Tasks.Where(o => o.UserId == userid && o.Status == TaskStatus.Late);
        }

        public IEnumerable<Task> GetOnTimeTasks(int userid)
        {
            return context.Tasks.Where(o => o.UserId == userid && o.Status == TaskStatus.OnTime);
        }
    }
}
