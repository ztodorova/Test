using System.Collections.Generic;

namespace Lemon.Services
{
    public interface ILemonService
    {
        ICollection<string> GetNames();
    }
}