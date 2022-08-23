using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP.Adapter
{
    public class Adapter
    {
        private Second _second;

        public Adapter(Second second)
        {
            this._second = second;
        }

        public List<int> transfer(int value)
        {
            // 123
            List<int> list = new List<int>();
            //'123'
            // '1','2','3'
            foreach (var x in value.ToString().ToList())
            {
                list.Add(Int32.Parse(x.ToString()));
            }
            // 1, 2, 3
            return list;
        }

        public void processFOO(int number)
        {
            _second.processFoo(transfer(number));
        }
    }
}