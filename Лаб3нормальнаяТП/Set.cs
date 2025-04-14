using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб3нормальнаяТП
{
    public class Set
    {
        private List<int> values = new List<int>();
        public Set(List<int> values)
        {
            this.values = values;
        }
        public List<int> GetValues()
        {
            return values;
        }
        public override string ToString()
        {
            return String.Join(" ", this.values);
        }
        public static Set operator +(Set set, int number)
        {
            if (!set.values.Contains(number))
                set.values.Add(number);
            var newSet = new Set(set.values);
            return newSet;
        }
        public static Set operator +(int number, Set set)
        {
            return set + number;
        }
        public static Set operator +(Set set1, Set set2)
        {
            var newSet = new Set(new List<int>());
            foreach(var number in set1.values)
            {
                if (!newSet.values.Contains(number))
                    newSet.values.Add(number);
            }
            foreach (var number in set2.values)
            {
                if (!newSet.values.Contains(number)) 
                    newSet.values.Add(number);
            }
            return newSet;
        }
        public static Set operator -(Set set, int number)
        {
            if (set.values.Contains(number))
                set.values.Remove(number);
            var newSet = new Set(set.values);
            return newSet;
        }
        public static Set operator *(Set set1, Set set2)
        {
            var newSet = new Set(new List<int>());
            foreach (var number in set1.values)
            {
                if (set1.values.Contains(number) && set2.values.Contains(number))
                    newSet.values.Add(number);
            }
            foreach (var number in set2.values)
            {
                if (set1.values.Contains(number) && set2.values.Contains(number) && !newSet.values.Contains(number))
                    newSet.values.Add(number);
            }
            return newSet;
        }
        public static Set operator -(Set set1, Set set2)
        {
            var newSet = new Set(new List<int>());
           foreach(var number in set1.values)
            {
                if (!set2.values.Contains(number))
                    newSet.values.Add(number);
            }
            return newSet;
        }
    }
}
