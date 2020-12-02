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

        public Sword(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.White)
           : base(x, y, icon, color)
        {
            _sprite = new Sprite("Images/sword.png");
        }

        public Sword(float x, float y, Color rayColor, char icon = ' ', ConsoleColor color = ConsoleColor.White)
           : base(x, y, rayColor, icon, color)
        {
            _sprite = new Sprite("Images/sword.png");
        }

        public override void Draw()
        {
            _sprite.Draw(_globalTransform);
            base.Draw();
        }
    }
}
