using System;
using System.Linq;
using System.Text;

namespace MaskifyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringToMaskify = "64607935616";

            var result = MaskifyString(stringToMaskify);

            Console.WriteLine(result);
        }


        static string MaskifyString(string stringToMaskify)
        {
            if (stringToMaskify.Length <= 4)
            {
                return stringToMaskify;
            }

            var stringToList = stringToMaskify.ToCharArray().ToList();

            var nonvisiblePart = stringToList.Count - 4;

            var visiblePart = stringToList.TakeLast(4);

            var newString = new StringBuilder();

            for (int i = 0; i < nonvisiblePart; i++)
            {
                newString.Append("#");
            }

            foreach (var word in visiblePart)
            {
                newString.Append(word);
            }

            return newString.ToString();

        }
    }
}
