using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTask
{
    class Publisher
    {
        public event EventHandler<char> KeyPressed;

        public void Run()
        {
            

            bool exit = false;

            while(!exit)
            {
                char insertChar = Console.ReadKey().KeyChar;
                if (insertChar == 'c')
                {
                    exit = true;
                    Console.WriteLine(" The end");
                    break; 
                }
                  
                
                KeyPressed?.Invoke(this, insertChar);
            }
        }
    }
}
