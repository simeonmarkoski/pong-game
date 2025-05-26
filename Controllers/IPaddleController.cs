using PongGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame.Controllers
{
    interface IPaddleController
    {
        void Move(ref Rectangle paddle, GameModel model, Size clientSize);
    }
}
