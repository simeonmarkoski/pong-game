using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame.Models
{
    public class GameModel
    {
        public Rectangle PlayerPaddle;
        public Rectangle AIPaddle;
        public Rectangle Ball;
        public int PaddleSpeed { get; set; } = 8;

        public int PlayerScore { get; set; }
        public int AIScore { get; set; }

        // prvichna brzina
        public const int BaseBallXSpeed = 5;
        public const int BaseBallYSpeed = 5;

        public int BallXSpeed { get; set; } = BaseBallXSpeed;
        public int BallYSpeed { get; set; } = BaseBallYSpeed;

        public void Reset(int width, int height)
        {
            int pw = 10, ph = 80, bs = 16;
            PlayerPaddle = new Rectangle(10, (height - ph) / 2, pw, ph);
            AIPaddle = new Rectangle(width - pw - 10, (height - ph) / 2, pw, ph);
            Ball = new Rectangle((width - bs) / 2, (height - bs) / 2, bs, bs);

            BallXSpeed = BaseBallXSpeed * (new Random().Next(0, 2) == 0 ? 1 : -1);
            BallYSpeed = BaseBallYSpeed * (new Random().Next(0, 2) == 0 ? 1 : -1);
        }
    }
}
