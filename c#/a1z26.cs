using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";

            string text = "Nessuno puo sfuggire al destino che e stato scelto per loro.";
            string h = "";
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (!alpha.Contains(text[i]))
                    h += text[i].ToString();
                else
                    h += (alpha.IndexOf(text[i]) + 1).ToString() + "-";
            }

            Console.Write(h.Remove(h.Length-1, 1));
        }
    }
}
