using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;

namespace DogDoorApp.Models
{
    internal class DogDoor
    {
        private bool open;
        private Timer timer;

        public DogDoor() {
            this.open = false;
        }

        public void Open()
        {
            Console.WriteLine("The Dog Door Opens");
            open = true;

            Timer timer = new Timer(5000);
            timer.Elapsed += (sender, e) => Close();
            timer.AutoReset = false;
            timer.Start();
        }

        public void Close()
        {
            open = false;
            Console.WriteLine("The Dog Door Closes");
        }

        public bool IsOpen() { 
            return open;
        }


    }
}
