using System;

namespace MatchingChecker
{
    internal class Test
    {
        private readonly MatchingChecker _check = new MatchingChecker();
        private string _errorMessage;

        public void CheckAreParenthesesMatched_WithOnlyOneParenthesis_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("("))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithOnlyOneParenthesis_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithTwoBalancedParentheses_ReturnsTrue()
        {
            if (!_check.AreParenthesesMatched("(x)"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithTwoBalancedParentheses_ReturnsTrue)} Failed");
        }
        public void CheckAreParenthesesMatched_WithTwoUnbalancedParentheses_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched(")("))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithTwoUnbalancedParentheses_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithUnbalancedParentheses_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("(()"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithUnbalancedParentheses_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithOnlyOneBracket_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("]"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithOnlyOneBracket_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithTwoOpenBrackets_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("[["))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithTwoOpenBrackets_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithTwoUnbalancedBrackets_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("]["))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithTwoUnbalancedBrackets_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithOnlyOneCurlyBracket_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("}"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithOnlyOneCurlyBracket_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithTwoOpenCurlyBrackets_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("{{"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithTwoOpenCurlyBrackets_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithTwoUnbalancedCurlyBrackets_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("}{"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithTwoUnbalancedCurlyBrackets_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithTwoClosedCurlyBrackets_ReturnFalse()
        {
            if (_check.AreParenthesesMatched("}}"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithTwoClosedCurlyBrackets_ReturnFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithBalancedBracketsAndParentheses_ReturnsTrue()
        {
            if (!_check.AreParenthesesMatched("([])"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithBalancedBracketsAndParentheses_ReturnsTrue)} Failed");
        }
        public void CheckAreParenthesesMatched_WithTwoUnbalancedBracketAndParenthesis_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("y]x("))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithTwoUnbalancedBracketAndParenthesis_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithUnbalancedParenthesisAndCurlyBracket_ReturnFalse()
        {
            if (_check.AreParenthesesMatched("(w}"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithUnbalancedParenthesisAndCurlyBracket_ReturnFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithUnbalancedBracketsAndCurlyBrackets_ReturnFalse()
        {
            if (_check.AreParenthesesMatched("{[[}"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithUnbalancedBracketsAndCurlyBrackets_ReturnFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithAnEmptyEquation_ReturnsError()
        {
            _errorMessage = $"{nameof(CheckAreParenthesesMatched_WithAnEmptyEquation_ReturnsError)} Failed";

            try
            {
                _check.AreParenthesesMatched("");

                throw new Exception(_errorMessage);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(ArgumentException))
                    throw new Exception(_errorMessage);
            }
        }
        public void CheckAreParenthesesMatched_WithNullInput_ReturnsError()
        {
            _errorMessage = $"{nameof(CheckAreParenthesesMatched_WithNullInput_ReturnsError)} Failed";

            try
            {
                _check.AreParenthesesMatched();

                throw new Exception(_errorMessage);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(ArgumentException))
                    throw new Exception(_errorMessage);
            }
        }
        public void CheckAreParenthesesMatched_WithAnEquationWithoutParentheses()
        {
            _errorMessage = $"{nameof(CheckAreParenthesesMatched_WithAnEquationWithoutParentheses)} Failed";

            try
            {
                _check.AreParenthesesMatched("A+B+C");

                throw new Exception(_errorMessage);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(ArgumentException))
                    throw new Exception(_errorMessage);
            }
        }
        public void CheckAreParentheseMatched_WithOddNumberOfCharacters_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("([{"))
                throw new Exception($"{nameof(CheckAreParentheseMatched_WithOddNumberOfCharacters_ReturnsFalse)} Failed");
        }
        public void CheckAreParenthesesMatched_WithBalancedEquation_ReturnsTrue()
        {
            if (!_check.AreParenthesesMatched("[X{(Z+Y)}]"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithBalancedEquation_ReturnsTrue)} Failed");
        }
        public void CheckAreParenthesesMatched_WithUnbalancedEquation_ReturnsFalse()
        {
            if (_check.AreParenthesesMatched("Z((X){}}[]"))
                throw new Exception($"{nameof(CheckAreParenthesesMatched_WithUnbalancedEquation_ReturnsFalse)} Failed");
        }
    }
}
