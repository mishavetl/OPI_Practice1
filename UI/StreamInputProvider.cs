using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OPI_Practice1.SharedMemory;

namespace OPI_Practice1.UI
{
    public class StreamInputProvider : IInputProvider
    {
        private StreamReader Reader { get; }
        
        public StreamInputProvider(StreamReader reader)
        {
            Reader = reader;
        }
        
        public string GetString()
        {
            return Reader.ReadLine();
        }

        public int GetN()
        {
            return int.Parse(GetString());
        }

        public int GetM()
        {
            return int.Parse(GetString());
        }

        public Matrix GetMatrix(int n, int m)
        {
            int[,] source = {};
            foreach (var i in Enumerable.Range(0, n))
            {
                string[] numbers = GetString().Split(' ');
                foreach (var j in Enumerable.Range(0, m))
                {
                    source[i, j] = int.Parse(numbers[j]);
                }
            }
            Matrix matrix = new Matrix(n, m, source);
            return matrix;
        }
    }
}