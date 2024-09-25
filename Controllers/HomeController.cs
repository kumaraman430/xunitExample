﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace xunitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("index/{guessedNumber}")]
        public string Index(int guessedNumber)
        {
            if (guessedNumber < 100)
            {
                return "Try a bigger number";
            }
            else if (guessedNumber > 100) 
            {
                return "Try a smaller number";
            }
            else
            {
                return "Guessed number is correct";
            }
        }
    }
}
