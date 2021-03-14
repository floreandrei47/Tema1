using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Car
    {
        public string Model;
        public string Package;
        public string Engine;

        public override string ToString()
        {
            string output = this.Model + " " + this.Package + " " + this.Engine ;

            return output;
        }
    
    }

   
}
