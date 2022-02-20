using GameApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace GameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameApiController : ControllerBase
    {
        MathOperations mathOperations = new();
        
        static int life = 100;
        



        [HttpGet]
        public int Get()
        {
            if (life == 0)
            {
                return life = 100;
            }
            var result = life - mathOperations.RandomNumber(0,10);
           life = result;
            if (life < 0)
            {
                return life = 0;
             
            }
          
            return result;

        }
     
        

       
    }

    
}
