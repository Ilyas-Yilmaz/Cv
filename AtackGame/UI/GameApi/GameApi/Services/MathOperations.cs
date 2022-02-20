using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Services
{
    public class MathOperations
    {
        
        public int RandomNumber(byte a,byte b)
        {
            Random atack = new Random();
          
            var random =atack.Next(a , b);
            
            return random;
        }
        
    }
}
