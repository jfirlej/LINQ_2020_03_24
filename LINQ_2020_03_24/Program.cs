using LINQ_2020_03_24.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_2020_03_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello LINQ World!");
        }

        #region helpers
        static void display<T>(List<T> list)
        {
            list.ForEach(obj =>
            {
                if (obj is String || obj is ValueType)
                    Console.Write($"{obj} ");
                else
                    obj.GetType().GetProperties().ToList().
                        ForEach(prop => Console.Write($"[{prop.Name}]: {prop.GetValue(obj)} "));
                Console.WriteLine();
            });
        }
        #endregion
    }
}
