namespace DesignPatterns.Behavioral.Interpreter;

public static class RpnInterpreter
{
    public static int Evaluate(string expression)
    {
        var stack = new Stack<IExpression>();
        foreach (var token in expression.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            switch (token)
            {
                case "+":
                    var rightAdd = stack.Pop();
                    var leftAdd = stack.Pop();
                    stack.Push(new AddExpression(leftAdd, rightAdd));
                    break;
                case "-":
                    var rightSub = stack.Pop();
                    var leftSub = stack.Pop();
                    stack.Push(new SubtractExpression(leftSub, rightSub));
                    break;
                default:
                    stack.Push(new NumberExpression(int.Parse(token)));
                    break;
            }
        }
        return stack.Pop().Interpret();
    }
}
