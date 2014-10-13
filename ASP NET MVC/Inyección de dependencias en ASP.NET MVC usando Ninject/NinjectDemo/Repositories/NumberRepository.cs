using System.Collections.Generic;

namespace NinjectDemo.Repositories
{
    public class NumberRepository : INumberRepository
    {
        public IList<int> GetNumbers()
        {
            return new List<int> { 1, 2, 3, 4, 5 };
        }
    }
}