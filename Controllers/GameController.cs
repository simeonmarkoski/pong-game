using System;
using System.Drawing;
using PongGame.Models;

namespace PongGame.Controllers
{
    internal class GameController
    {
        readonly GameModel _model;
        readonly IPaddleController _playerCtrl, _aiCtrl;

        private int _updateCount;
        private const int UPDATES_PER_SPEED_INCREASE = 300;

        public GameController(GameModel model, IPaddleController player, IPaddleController ai)
        {
            _model = model;
            _playerCtrl = player;
            _aiCtrl = ai;
        }

        public void Update(Size clientSize)
        {
            // dvizenje na paddles
            _playerCtrl.Move(ref _model.PlayerPaddle, _model, clientSize);
            _aiCtrl.Move(ref _model.AIPaddle, _model, clientSize);

            // dvizenje na topkata
            _model.Ball.X += _model.BallXSpeed;
            _model.Ball.Y += _model.BallYSpeed;

            // udiranje gore/dole
            if (_model.Ball.Y < 0 || _model.Ball.Bottom > clientSize.Height)
                _model.BallYSpeed = -_model.BallYSpeed;

            // udiranje of paddles
            if (_model.Ball.IntersectsWith(_model.PlayerPaddle) ||
                _model.Ball.IntersectsWith(_model.AIPaddle))
            {
                _model.BallXSpeed = -_model.BallXSpeed;
            }

            // brzina na topkata
            _updateCount++;
            if (_updateCount % UPDATES_PER_SPEED_INCREASE == 0)
            {
                _model.BallXSpeed += Math.Sign(_model.BallXSpeed);
                _model.BallYSpeed += Math.Sign(_model.BallYSpeed);
            }

            // pobeda i reset (ako izleze topkata out of bounds)
            if (_model.Ball.X < 0)
            {
                _model.AIScore++;
                ResetBallAndRamp(clientSize);
            }
            else if (_model.Ball.Right > clientSize.Width)
            {
                _model.PlayerScore++;
                ResetBallAndRamp(clientSize);
            }
        }

        private void ResetBallAndRamp(Size clientSize)
        {
            _model.Reset(clientSize.Width, clientSize.Height);
            // otponovo so brzinata na topkata
            _updateCount = 0;
        }
    }
}
