using System;
using System.IO;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using OPI_Practice1;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.UI;

namespace OPI_Practice1Tests
{
    public class StreamInputProviderTests
    {
        private IInputProvider Input { get; set; }
        private MemoryStream InputStream { get; set; }

        [SetUp]
        public void Setup()
        {
            InputStream = new MemoryStream();
            Input = new ServiceProviderBuilder()
                .SetInputStream(new StreamReader(InputStream))
                .Build()
                .GetService<IInputProvider>();
        }

        [Test]
        public void TestGetMatrixInputsBasicMatrix2X2()
        {
            InputStream.Write(Encoding.UTF8.GetBytes("1 2\n3 4").AsSpan());
            var expected = new Matrix(2, 2, new int[,]
            {
                {1, 2},
                {3, 4}
            });
            var actual = Input.GetMatrix(2, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}