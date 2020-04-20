using System;
using System.IO;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using OPI_Practice1;
using OPI_Practice1.Services;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.UI;

namespace OPI_Practice1Tests
{
    public class StreamInputProviderTests
    {
        private IInputProvider Input { get; set; }
        private StringReader InputStream { get; set; }
        private Mock<TextWriter> OutputStream { get; set; }

        public void Setup(string input)
        {
            InputStream = new StringReader(input);
            OutputStream = new Mock<TextWriter>();
            Input = ServiceProviderBuilder.construct()
                .SetInputStream(InputStream)
                .SetOutputStream(OutputStream.Object)
                .Build()
                .GetService<IInputProvider>();
        }

        [Test]
        public void TestGetMatrixInputsBasicMatrix2X2()
        {
            Setup("1 2\n3 4");
            var expected = new Matrix(2, 2, new int[,]
            {
                {1, 2},
                {3, 4}
            });
            var actual = Input.GetMatrix(2, 2);
            Assert.AreEqual(expected, actual);
            OutputStream.VerifyNoOtherCalls();
        }

        [Test]
        public void TestGetMatrixInputsBasicMatrix3X3()
        {
            Setup("1 2 6\n3 5 4\n8 7 9");
            var expected = new Matrix(3, 3, new int[,]
            {
                {1, 2, 6},
                {3, 5, 4},
                {8, 7, 9},
            });
            var actual = Input.GetMatrix(3, 3);
            Assert.AreEqual(expected, actual);
            OutputStream.VerifyNoOtherCalls();
        }
    }
}