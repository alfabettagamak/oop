using System;
using System.Collections.Generic;

namespace OOP.Adapter
{
    public class Second
    {
        public void processFoo(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}