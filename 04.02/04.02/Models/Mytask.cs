using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Id
//Başlıq
//İzahat
//Created
//DeadLine (tarix və saat olaraq)
//TaskStatus (enum)
//Id dəyəri Constructor vasitəsilə statik olaraq avtomatik veriləcək, Created dəyəri constructor-da hazırki vaxtı göstərəcək.
//ToString() override edilməli


namespace _04._02.Models
{
    internal class Mytask
    {
        private static int _id;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public DateTime Created { get; set; }
        public DateTime DeadLine { get; set; }
        public TaskStatus TaskStatus  { get; set; }
        public Mytask()
        {
            _id++;
            Id = _id;
            Created = DateTime.Now;
        }
        public override string ToString()
        {
           return $"Id: {Id}\nBaşlıq: {Title}\nİzahat: {Explanation}\nCreated: {Created}\nDeadLine: {DeadLine}\nTaskStatus: {TaskStatus}";
        }              
    }
}
