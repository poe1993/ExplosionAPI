using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblerController : ControllerBase
    {
        [HttpGet]
        public string Get(string input)
        {
            var answer = "";
            for (var index = 0; index < input.Length; index++)
            {
                var currentCharacter = input[index];
                for (var repeatCount = 0; repeatCount < index + 1; repeatCount++)
                {
                    if (repeatCount == 0)
                    {
                        answer += Char.ToUpper(currentCharacter);
                    }
                    else
                    {
                        answer += Char.ToLower(currentCharacter);
                    }
                }
                if (index < input.Length - 1)
                {
                    answer += "-";
                }
            }
            return answer;
        }
    }
}