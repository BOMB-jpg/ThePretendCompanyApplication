using System;
using System.Collections.Generic;

namespace TCPExtensions
{
    public static class Extension
    {
        public static List<T> Filter<T>(this List<T> records, Func<T, bool> func)
            //this 关键字表示这是一个扩展方法，它可以在泛型列表类型上直接调用，而不需要通过静态类的实例来调用。
        {
            List<T> filteredList = new List<T>();

            foreach (T record in records)
            {
                if (func(record))
                {
                    filteredList.Add(record);
                }
            }

            return filteredList;
        }
    }
}
