using PongGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame.Controllers
{
    internal class HumanController : IPaddleController
    {
        public bool Up, Down;
        public void Move(ref Rectangle paddle, GameModel model, Size clientSize)
        {
            if (Up && paddle.Y > 0) paddle.Y -= model.PaddleSpeed;
            if (Down && paddle.Bottom < clientSize.Height) paddle.Y += model.PaddleSpeed;
        }
    }
}
