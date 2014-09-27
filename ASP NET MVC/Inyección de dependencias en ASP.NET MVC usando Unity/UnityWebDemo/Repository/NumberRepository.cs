using System.Collections.Generic;

namespace UnityWebDemo.Repository
{
    public class NumberRepository : INumberRepository
    {
        public List<int> GetNumbers()
        {
            return new List<int>() { 1, 2, 3, 4, 5 };
        }
    }
}