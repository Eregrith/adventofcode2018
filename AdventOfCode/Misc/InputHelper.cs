using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode.Misc
{
    public static class InputHelper
    {
        public static T NoOp<T>(T obj) => obj;

        public static List<T> LoadListFromFile<T>(string path, Func<string, T> parse)
        {
            List<T> inputList = new List<T>();
            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    inputList.Add(parse(sr.ReadLine()));
                }
            }
            return inputList;
        }
    }
}
