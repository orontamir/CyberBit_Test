using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberBit.Models
{
    public interface ITask
    {
        IEnumerable<Task> GetDoneTasks(int userid);
        IEnumerable<Task> GetLateTasks(int userid);
        IEnumerable<Task> GetOnTimeTasks(int userid);

        Task AddTask(Task task);

    }
}
