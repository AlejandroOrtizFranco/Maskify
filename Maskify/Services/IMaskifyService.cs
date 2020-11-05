using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maskify.Services
{
    public interface IMaskifyService
    {
        string PostMaskify(string stringToMaskify);
    }
}
