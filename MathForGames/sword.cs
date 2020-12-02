using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using MathLibrary;

namespace MathForGames
{
    class Sword : Actor
    {
        private float _speed = 1;
        private Sprite _sprite;
        private Actor _enemy;

        public Sword(float x, float y, char icon = ' ', Actor enemy, ConsoleColor color = ConsoleColor.White)
           : base(x, y, icon, color)
        {
            _enemy = enemy;
            _sprite = new Sprite("Images/sword.png");

        }

        public Sword(float x, float y, Color rayColor, char icon = ' ', Actor enemy, ConsoleColor color = ConsoleColor.White)
           : base(x, y, rayColor, icon, color)
        {
            _sprite = new Sprite("Images/sword.png");
            _enemy = enemy;
        }

        private bool CheckPlayerDistance()
        {
            float distance = (_enemy.Position - Position).Magnitude;
            return distance <= 1;
        }

        public override void Update(float deltaTime)
        {
            //If the player is in range of the goal, end the game
            if (CheckPlayerDistance())
                Game.SetGameOver(true);

            base.Update(deltaTime);
        }


        public override void Draw()
        {
            _sprite.Draw(_globalTransform);
            base.Draw();
        }
    }
}
