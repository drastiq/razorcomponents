using Microsoft.AspNetCore.Components;
using sandbox.core;
using sandbox.dataaccess;
using System.Linq;
using System.Threading.Tasks;

namespace TestComponent.Services
{
    public class GameService 
    {
        private readonly SandboxContext _context;

        public GameService(SandboxContext context)
        {
            _context = context;
        }

        public Task<Game> SetUpGane()
        {
            Game game = new Game();
            var t = new Player { ID = 1, Name = "test", Type = 1 };
            game.Players.Add(t);
        

            game.GameState = State.Vote;
            game.Cards.AddRange(_context.Cards);
            return Task.FromResult(game);
        }

    }
}
