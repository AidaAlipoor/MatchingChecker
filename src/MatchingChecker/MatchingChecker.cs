using System;
using System.Collections;
using System.Linq;

namespace MatchingChecker
{
    internal class MatchingChecker
    {
        private const char _openParenthesis = '(';
        private const char _openBracket = '[';
        private const char _openCurlyBracket = '{';
        private const char _closedParenthesis = ')';
        private const char _closedBracket = ']';
        private const char _closedCurlyBracket = '}';

        private readonly char[] _openBrackets = new[] { _openParenthesis, _openBracket, _openCurlyBracket };
        private readonly char[] _closeBrackets = new[] { _closedParenthesis, _closedBracket, _closedCurlyBracket };


        public bool AreParenthesesMatched(string equation = "\n")
        {
            if (DoesEquationContainParenthesis(equation) == false)
                throw new ArgumentException();


            if (CountParentheses(equation) % 2 != 0)
                return false;


            var stack = new Stack();

            for (int i = 0; i < equation.Length; i++)
            {
                var equationCharacter = equation[i];

                if (_openBrackets.Contains(equationCharacter))
                    stack.Push(equationCharacter);

                else if (_closeBrackets.Contains(equationCharacter))
                {
                    if (stack.Count == 0)
                        return false;
                    else if (IsMatchingPair(Convert.ToChar(stack.Peek()), equationCharacter))
                        stack.Pop();
                }
            }

            return stack.Count == 0;
        }

        private bool IsMatchingPair(char character1, char character2)
        {
            return (character1 == _openParenthesis && character2 == _closedParenthesis)
                   || (character1 == _openBracket && character2 == _closedBracket)
                   || (character1 == _openCurlyBracket && character2 == _closedCurlyBracket);
        }

        private bool DoesEquationContainParenthesis(string equation)
            => equation.Any(c => _openBrackets.Contains(c) || _closeBrackets.Contains(c));

        private int CountParentheses(string equation)
            => equation.Count(c => _openBrackets.Contains(c) || _closeBrackets.Contains(c));
    }

}
