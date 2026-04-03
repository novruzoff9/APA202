using _04._02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02.Models
{
    internal class TaskService : ITaskService
    {

        static List<Mytask> tasks = [];
        public void Addtask(Mytask addTask)
        {
            var excist = GetTask(addTask.Title);
            if (excist != null)
            {
                throw new ConflictException();
            }
            tasks.Add(addTask);
        }

        public Mytask GetTask(string title)
        {
            foreach (var item in tasks)
            {
                if (item.Title == title)
                {
                    return item;
                }

            }
            throw new NotFoundException();

        }
    }
}
