// https://leetcode.com/problems/valid-parentheses/submissions/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        sol.IsValid(")(");
    }
}

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        for(int i=0; i<s.Length; i++){
            switch(s[i]) 
            {
                case '(':
                    stack.Push(s[i]);
                    break;
                case ')':
                    if(stack.Count > 0 && stack.Peek() == '(') stack.Pop();
                    else return false;
                    break;
                case '{':
                    stack.Push(s[i]);
                    break;
                case '}':
                    if(stack.Count > 0 && stack.Peek() == '{') stack.Pop();
                    else return false;
                    break;
                case '[':
                    stack.Push(s[i]);
                    break;
                default:
                    if(stack.Count > 0 && stack.Peek() == '[') stack.Pop();
                    else return false;
                    break;
            }
        }
        return stack.Count == 0;
    }
}