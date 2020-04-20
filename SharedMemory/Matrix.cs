using System;
using System.Linq;

namespace OPI_Practice1.SharedMemory
{
    public class Matrix
    {
        public readonly int M;
        public readonly int N;

        private int[,] Source { get; set; }
        
        public Matrix(int n, int m)
        {
            N = n;
            M = m;
            Source = new int[n, m];
        }
        
        public Matrix(int n, int m, int[,] source)
        {
            N = n;
            M = m;
            Source = source;
        }

        public int Get(int i, int j) => Source[i, j];
        public int Set(int i, int j, int value) => Source[i, j] = value;
        
        protected bool Equals(Matrix other)
        {
            return M == other.M && N == other.N && Source.Cast<int>().SequenceEqual(other.Source.Cast<int>());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Matrix) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(M, N, Source);
        }

        public static bool operator ==(Matrix left, Matrix right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Matrix left, Matrix right)
        {
            return !Equals(left, right);
        }
    }
}