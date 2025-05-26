using PongGame.Controllers;
using PongGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public partial class GameForm : Form
    {
        private readonly GameModel _model;
        private readonly GameController _controller;
        private readonly HumanController _humanCtrl;

        public GameForm()
        {
            InitializeComponent();

            // events rabotat
            this.KeyPreview = true;

            // model i kontrolerite
            _model = new GameModel();
            _humanCtrl = new HumanController();
            var aiCtrl = new AIController();
            _controller = new GameController(_model, _humanCtrl, aiCtrl);

            // resetiranje na pozicijata odnovo
            _model.Reset(ClientSize.Width, ClientSize.Height);

            // zapochnuvanje na tajmerot
            gameTimer.Start();

            // vlezni eventi
            this.KeyDown += GameForm_KeyDown;
            this.KeyUp += GameForm_KeyUp;
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // updejtiranje ne lofikata i pochnuvanje otponovo
            _controller.Update(ClientSize);
            Invalidate();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            // sledenje gore/dole dvizenje na paddles
            if (e.KeyCode == Keys.W) _humanCtrl.Up = true;
            if (e.KeyCode == Keys.S) _humanCtrl.Down = true;
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) _humanCtrl.Up = false;
            if (e.KeyCode == Keys.S) _humanCtrl.Down = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;

            // paddles da bidat crni
            g.FillRectangle(Brushes.Black, _model.PlayerPaddle);
            g.FillRectangle(Brushes.Black, _model.AIPaddle);

            // topkata vo plava
            g.FillEllipse(Brushes.Blue, _model.Ball);

            // rezultatite da bidat crni
            string score = $"{_model.PlayerScore}  :  {_model.AIScore}";
            using (var font = new Font("Consolas", 24, FontStyle.Bold))
            {
                var textSize = g.MeasureString(score, font);
                float x = (ClientSize.Width - textSize.Width) / 2;
                g.DrawString(score, font, Brushes.Black, x, 10);
            }
        }
    }
}
