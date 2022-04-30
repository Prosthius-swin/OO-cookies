using System;

namespace OO_cookies_task
{
    class Colour
    {
        private int red;
        private int green;
        private int blue;
        private string name;

        public Colour(string pName, int pRed, int pGreen, int pBlue)
        {
            name = pName;
            red = pRed;
            green = pGreen;
            blue = pBlue;
        }
    }
}