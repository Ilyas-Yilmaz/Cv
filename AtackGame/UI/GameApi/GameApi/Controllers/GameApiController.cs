using GameApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameApiController : ControllerBase
    {
        MathOperations mathOperations=new();
        
        static int life = 100;
        [HttpGet]
       
        public int Main()
        {
            if (life == 0)
            {
                return life = 100;
            }
            var random = mathOperations.RandomNumber(0, 10);
            
            var result = life - random;
           life = result;
            if (life < 0)
            {
                return life = 0;
             
            }
          
            return life;

        }
     
        

       
    }
}
