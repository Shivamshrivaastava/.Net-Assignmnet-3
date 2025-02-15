using System;
using System.Collections;

public class ValidParenthesesProgram
{
    public static bool IsValid(string s)
    {
        Stack stack = new Stack();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else if (stack.Count == 0 || 
                     (c == ')' && (char)stack.Pop() != '(') || 
                     (c == '}' && (char)stack.Pop() != '{') || 
                     (c == ']' && (char)stack.Pop() != '['))
                return false;
        }
        return stack.Count == 0;
    }

    public static void Main()
    {
        Console.WriteLine(IsValid("()[]{}"));
    }
}
