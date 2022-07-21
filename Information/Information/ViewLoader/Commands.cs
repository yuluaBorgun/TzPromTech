using System;

namespace Information.ViewLoader
{
    public static class Commands
    {
        public static string GetRandomCode(int length)
        {
            Random rand = new Random();
            char[] code = new char[length];
            for (int i = 0; i< code.Length; i++)
            {
                code[i] = (char)rand.Next('A', 'Z');
            }
            return string.Join("", code);
        }
    }
}
