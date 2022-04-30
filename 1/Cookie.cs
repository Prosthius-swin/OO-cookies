using System;

namespace OO_cookies_task
{
    class Cookie
    {
        private int weight;
        private string shape;
        private Colour colour;

        public Cookie(int pWeight, string pShape, Colour pColour)
        {
            weight = pWeight;
            shape = pShape;
            colour = pColour;
        }
    }
}