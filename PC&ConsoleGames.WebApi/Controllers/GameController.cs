using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PC_ConsoleGames.Core.DTOs;
using PC_ConsoleGames.Core.Interfaces;

namespace PC_ConsoleGames.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _game;
        public GameController(IGameService game)
        {
            _game = game;
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _game.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _game.GetByIdAsync(id));
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateGameDTO game)
        {
            await _game.CreateAsync(game);
            return Ok();
        }
        [HttpPut("Edit")]
        public async Task<IActionResult> Edit(GameDTO game)
        {
            await _game.UpdateAsync(game);
            return Ok();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _game.DeleteAsync(id);
            return Ok();
        }
    }
}
