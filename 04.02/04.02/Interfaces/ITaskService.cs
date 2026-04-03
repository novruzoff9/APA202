using _04._02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02.Interfaces
{
    internal interface ITaskService
    {
        Mytask GetTask(string title);
        void Addtask(Mytask addTask);

    }
}
