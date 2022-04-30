using System;

namespace OO_cookies_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Colour blue = new Colour("blue", 0, 255, 0);
            Colour red = new Colour("red", 255, 0, 0);
            
            Cookie round = new Cookie(100, "round", blue);
            Cookie square = new Cookie(110, "square", blue);
            Cookie oval = new Cookie(50, "oval", red);
            Cookie triangle = new Cookie(70, "triangle", red);
        }
    }
}
