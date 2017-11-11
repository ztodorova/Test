using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemon.Services
{
    public class LemonService : ILemonService
    {
        public ICollection<string> GetNames()
        {
            return new List<string>
            {
                "Yellow",
                "Sour"
            };
        }
    }
}
