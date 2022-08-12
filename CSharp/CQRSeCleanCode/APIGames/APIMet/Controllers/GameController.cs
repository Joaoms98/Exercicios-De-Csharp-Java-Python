using APIGames.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIMet.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class GameController : ControllerBase
    {
        private static List<GameModel> games = new List<GameModel>();

        [HttpPost]
        public void NewGame([FromBody] GameModel game)
        {
            game.Id = Guid.NewGuid();
            games.Add(game);
        }

        [HttpGet]
        public IActionResult ListGames()
        {
            try
            {
                return Ok(games);
            }
            catch
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult SeachGameforId(Guid id)
        {
            try
            {
                return Ok(games.FirstOrDefault(g => g.Id == id));
            }
            catch(Exception)
            {
                return NotFound();
            }
        }
    }
}
