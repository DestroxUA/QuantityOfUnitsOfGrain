using System.Text;
using System.Text.RegularExpressions;

namespace QuantityOfUnitsOfGrainOnBarge
{
    internal class AdditionalClass
    {
        public static int ReadIntOnly()
        {
            ConsoleKeyInfo key;
            var rule = @"[0-9]";
            var sb = new StringBuilder();

            while (true)
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (Regex.IsMatch(key.KeyChar.ToString(), rule))
                {
                    sb.Append(key.KeyChar);
                    Console.Write(key.KeyChar);
                }

                if (key.Key == ConsoleKey.Backspace)
                {
                    int PreviosLength = sb.Length;
                    sb.Remove(sb.Length - 1, 1);
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine(new String(' ', PreviosLength));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.WriteLine(sb);
                    Console.SetCursorPosition(sb.Length, Console.CursorTop - 1);
                }
            }

            if (sb.Length==0)

                return 0;
        
            else

                return Convert.ToInt32(sb.ToString());
        }

        public static int CalculateTheQuantityOfUnitsOfGrain(ref int LowerLevelValue, int CurrentLevelValue)
        {
            int buf = 0;
            int result;

            if (LowerLevelValue > CurrentLevelValue)
            {

                result = LowerLevelValue - CurrentLevelValue;
                buf += result;
            }
            else
            {
                LowerLevelValue = CurrentLevelValue;
            }

            return buf;
        }
    }
}
