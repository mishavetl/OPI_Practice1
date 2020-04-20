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
    public class StreamOutputProviderTests
    {
        private IOutputProvider Output { get; set; }
        private TextReader InputStream { get; set; }
        private Mock<TextWriter> OutputStream { get; set; }

        [SetUp]
        public void Setup()
        {
            InputStream = new Mock<TextReader>().Object;
            OutputStream = new Mock<TextWriter>();
            Output = ServiceProviderBuilder.construct()
                .SetInputStream(InputStream)
                .SetOutputStream(OutputStream.Object)
                .Build()
                .GetService<IOutputProvider>();
        }

        [Test]
        public void TestOutputMatrixOutputsBasicMatrix2X2()
        {
            var matrix = new Matrix(2, 2, new int[,]
            {
                {1, 2},
                {3, 4},
            });
            Output.OutputMatrix(matrix);
            OutputStream.Verify(writer => writer.Write("1 "));
            OutputStream.Verify(writer => writer.Write("2 "));
            OutputStream.Verify(writer => writer.Write("\n"));
            OutputStream.Verify(writer => writer.Write("3 "));
            OutputStream.Verify(writer => writer.Write("4 "));
            OutputStream.Verify(writer => writer.Write("\n"));
            OutputStream.VerifyNoOtherCalls();
        }

        [Test]
        public void TestGetMatrixInputsBasicMatrix3X3()
        {
            var matrix = new Matrix(3, 3, new int[,]
            {
                {1, 2, 6},
                {3, 5, 4},
                {8, 7, 9},
            });
            Output.OutputMatrix(matrix);
            OutputStream.Verify(writer => writer.Write("1 "));
            OutputStream.Verify(writer => writer.Write("2 "));
            OutputStream.Verify(writer => writer.Write("6 "));
            OutputStream.Verify(writer => writer.Write("\n"));
            OutputStream.Verify(writer => writer.Write("3 "));
            OutputStream.Verify(writer => writer.Write("5 "));
            OutputStream.Verify(writer => writer.Write("4 "));
            OutputStream.Verify(writer => writer.Write("\n"));
            OutputStream.Verify(writer => writer.Write("8 "));
            OutputStream.Verify(writer => writer.Write("7 "));
            OutputStream.Verify(writer => writer.Write("9 "));
            OutputStream.Verify(writer => writer.Write("\n"));
            OutputStream.VerifyNoOtherCalls();
        }
    }
}