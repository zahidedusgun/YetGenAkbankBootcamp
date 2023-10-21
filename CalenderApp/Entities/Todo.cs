using CalenderApp.Abstract;
using CalenderApp.Common;
using CalenderApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderApp.Entities
{

    internal class Todo : Event, INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this To Do: {Title}");
        }
    }


}
