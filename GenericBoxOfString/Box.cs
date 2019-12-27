using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
        where T :IComparable<T>
    {
        public Box(List<T> items)
        {
            Items = items;
        }

        public List<T> Items { get; set; }

        public int GetGreaterThan(T inputItem)
        {
            int count = 0;

            foreach (var item in this.Items)
            {
                if (item.CompareTo(inputItem) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public void Swap(int index1, int index2)
        {
            T tempVAr = this.Items[index1];
            this.Items[index1] = this.Items[index2];
            this.Items[index2] = tempVAr;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString().TrimEnd();
        }


    }
}
