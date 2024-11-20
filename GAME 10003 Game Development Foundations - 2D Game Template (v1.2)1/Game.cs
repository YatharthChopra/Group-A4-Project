// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(600, 1000);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.DarkGray);
            Draw.LineColor = Color.Black;
            Draw.Rectangle(0, 0, 20, 80);

            Draw.LineColor = Color.Black;
            Draw.Rectangle(100, 0, 40, 80);

            Draw.LineColor = Color.Black;
            Draw.Rectangle(220, 0, 40, 80);

            Draw.LineColor = Color.Black;
            Draw.Rectangle(340, 0, 40, 80);

            Draw.LineColor = Color.Black;
            Draw.Rectangle(460, 0, 40, 80);

            Draw.LineColor = Color.Black;
            Draw.Rectangle(580, 0, 40, 80);
           
        }
    }
}
