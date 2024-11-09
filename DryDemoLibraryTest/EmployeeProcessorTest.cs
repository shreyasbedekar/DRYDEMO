using DRYDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DryDemoLibraryTest
{
    public class EmployeeProcessorTest
    {
        [Theory]
        [InlineData("John", "Doee", "JohnXDoee")]
        [InlineData("Jane", "Smi", "JaneXSmi")]
        [InlineData("J", "D", "JX")]
        public void GenerateEmployeeId_ShouldCalculate(string firstname, string lastname, string expectedStart)
        {
            // Arrange
            EmployeeProcessor processor = new EmployeeProcessor();
            // Act
            string actualStart = processor.GenerateEmployeeId(firstname, lastname).Substring(0, expectedStart.Length);
            // Assert
            Assert.Equal(expectedStart, actualStart);
        }
    }
}
