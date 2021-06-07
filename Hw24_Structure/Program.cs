using System;

namespace Hw24_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            // struct -> value type
            Rectangle rectangleClass = new Rectangle();
            rectangleClass.shortEdge = 3;
            rectangleClass.longEdge = 4;
            Console.Write($"{"Class Area".PadRight(13)}: {rectangleClass.Area()}");

            RectangleStruct rectangleStruct;// new lenmedende kullanilabilir.
            rectangleStruct.ShortEdge = 3;
            rectangleStruct.LongEdge = 4;
            Console.Write($"\n{"Struct Area".PadRight(13)}: {rectangleStruct.Area()}");

            Rectangle rectangleClass2 = new Rectangle();
            Console.Write($"\n{"Class Area".PadRight(13)}: {rectangleClass2.Area()}");

            RectangleStruct rectangleStruct2 = new RectangleStruct(3, 4);
            Console.Write($"\n{"Struct Area".PadRight(13)}: {rectangleStruct2.Area()}");

        }
    }

    class Rectangle
    {
        public int shortEdge;
        public int longEdge;

        public Rectangle()  // Constructor tanımladıgımda direk degerleri verebiliyorum
        {
            shortEdge = 3;
            longEdge = 4;
        }

        public long Area()
        {
            return this.shortEdge * this.longEdge;
        }
    }

    struct RectangleStruct
    {
        public int ShortEdge;
        public int LongEdge;

        public RectangleStruct(int shortEdge, int longEdge) // Constructor tanımladıgımda direk degerleri veremiyorum, parametre vermem gerekiyor
        {
            ShortEdge = shortEdge;
            LongEdge = longEdge;
        }

        public long Area()
        {
            return this.ShortEdge * this.LongEdge;
        }
    }
}
