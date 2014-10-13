using System.Collections.Generic;

namespace NinjectDemo.Repositories
{
    public interface INumberRepository
    {
        IList<int> GetNumbers();
    }
}