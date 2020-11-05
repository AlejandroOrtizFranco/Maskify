using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maskify.Services
{
    public class MaskifyService : IMaskifyService
    {
        public string PostMaskify(string stringToMaskify)
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
