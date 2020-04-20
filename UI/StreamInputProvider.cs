using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.Tasks;
using OPI_Practice1.UI;

namespace OPI_Practice1.Services
{
    public class StreamInputProvider : IInputProvider
    {
        private TextReader Reader { get; }
        
        public StreamInputProvider(TextReader reader)
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
            int[,] source = new int[n, m];
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