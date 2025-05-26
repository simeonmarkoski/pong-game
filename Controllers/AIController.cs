using PongGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame.Controllers
{
    internal class AIController : IPaddleController
    {
        public void Move(ref Rectangle paddle, GameModel model, Size clientSize)
        {
            // algoritam da ja sledi topkata
            if (model.Ball.Y < paddle.Y && paddle.Y > 0) paddle.Y -= model.PaddleSpeed;
            else if (model.Ball.Bottom > paddle.Bottom && paddle.Bottom < clientSize.Height)
                paddle.Y += model.PaddleSpeed;
        }
    }
}
