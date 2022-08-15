using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorTests
{
    public class MainTests
    {
        [Fact]
        public void ShouldDoRun()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("10");
            stringBuilder.AppendLine("7");
            stringBuilder.AppendLine("a");
            stringBuilder.AppendLine("n");
            var stringReader = new StringReader(stringBuilder.ToString());
            Console.SetIn(stringReader);
            Program.Main(Array.Empty<string>());
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "Type another number, and then press Enter: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "Your result: 17" +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";
            Assert.Equal(expectedResult, Regex.Replace(stringWriter.ToString(), @"[\r\t\n]+", string.Empty));

        }
        [Fact]
        public void ShouldDoRunWith()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("v");
            stringBuilder.AppendLine("5");
            stringBuilder.AppendLine("s");
            stringBuilder.AppendLine("0");
            stringBuilder.AppendLine("d");
            stringBuilder.AppendLine("n");
            var stringReader = new StringReader(stringBuilder.ToString());
            Console.SetIn(stringReader);
            Program.Main(Array.Empty<string>());
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "This is not valid input. Please enter an integer value: " +
                                 "Type another number, and then press Enter: " +
                                 "This is not valid input. Please enter an integer value: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "This operation will result in a mathematical error." +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";
            Assert.Equal(expectedResult, Regex.Replace(stringWriter.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShouldReturnMathError()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("4");
            stringBuilder.AppendLine("0");
            stringBuilder.AppendLine("d");
            stringBuilder.AppendLine("n");
            var stringReader = new StringReader(stringBuilder.ToString());
            Console.SetIn(stringReader);



            Program.Main(Array.Empty<string>());
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "Type another number, and then press Enter: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "This operation will result in a mathematical error." +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedResult, Regex.Replace(stringWriter.ToString(), @"[\r\t\n]+", string.Empty));

        }
    }

}
