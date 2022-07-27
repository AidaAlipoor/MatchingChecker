using System;

namespace MatchingChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();

            Console.WriteLine("Tests are running...");
            Console.WriteLine();


            test.CheckAreParenthesesMatched_WithOnlyOneParenthesis_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithOnlyOneParenthesis_ReturnsFalse)} is passed.");
        
            test.CheckAreParenthesesMatched_WithTwoBalancedParentheses_ReturnsTrue();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithTwoBalancedParentheses_ReturnsTrue)} is passed.");

            test.CheckAreParenthesesMatched_WithTwoUnbalancedParentheses_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithTwoUnbalancedParentheses_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithUnbalancedParentheses_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithUnbalancedParentheses_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithOnlyOneBracket_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithOnlyOneBracket_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithTwoOpenBrackets_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithTwoOpenBrackets_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithTwoUnbalancedBrackets_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithTwoUnbalancedBrackets_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithOnlyOneCurlyBracket_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithOnlyOneCurlyBracket_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithTwoOpenCurlyBrackets_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithTwoOpenCurlyBrackets_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithTwoUnbalancedCurlyBrackets_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithTwoUnbalancedCurlyBrackets_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithTwoClosedCurlyBrackets_ReturnFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithTwoClosedCurlyBrackets_ReturnFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithBalancedBracketsAndParentheses_ReturnsTrue();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithBalancedBracketsAndParentheses_ReturnsTrue)} is passed.");

            test.CheckAreParenthesesMatched_WithTwoUnbalancedBracketAndParenthesis_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithTwoUnbalancedBracketAndParenthesis_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithUnbalancedParenthesisAndCurlyBracket_ReturnFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithUnbalancedParenthesisAndCurlyBracket_ReturnFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithUnbalancedBracketsAndCurlyBrackets_ReturnFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithUnbalancedBracketsAndCurlyBrackets_ReturnFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithAnEmptyEquation_ReturnsError();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithAnEmptyEquation_ReturnsError)} is passed.");

            test.CheckAreParenthesesMatched_WithAnEquationWithoutParentheses();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithAnEquationWithoutParentheses)} is passed.");

            test.CheckAreParentheseMatched_WithOddNumberOfCharacters_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParentheseMatched_WithOddNumberOfCharacters_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithBalancedEquation_ReturnsTrue();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithBalancedEquation_ReturnsTrue)} is passed.");

            test.CheckAreParenthesesMatched_WithUnbalancedEquation_ReturnsFalse();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithUnbalancedEquation_ReturnsFalse)} is passed.");

            test.CheckAreParenthesesMatched_WithNullInput_ReturnsError();
            Console.WriteLine($"{nameof(test.CheckAreParenthesesMatched_WithNullInput_ReturnsError)} is passed.");

            Console.Read();
        }
    }
}
