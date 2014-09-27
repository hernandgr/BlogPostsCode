using System;

namespace UnityWebDemo.Repository
{
    public interface INumberRepository
    {
        System.Collections.Generic.List<int> GetNumbers();
    }
}