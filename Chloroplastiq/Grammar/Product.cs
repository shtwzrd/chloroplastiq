#region

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Chloroplastiq.Grammar
{
    public class Product
    {
        public string Alphabet;
        public IDictionary<char, string> Rules;

        public Product(string w, Dictionary<char, String> p)
        {
            Axiom = w;
            Alphabet = Axiom;
            Rules = p;
        }

        // / <summary>
        // / Gets or sets Axiom
        // / </summary>
        public string Axiom { get; set; }

        // / <summary>
        // / Gets or sets Angle
        // / </summary>
        public float Angle { get; set; }

        // / <summary>
        // / Gets or sets Iterations
        // / </summary>
        public ushort Iterations { get; set; }

        public string Yield(String current, int iter, IDictionary<char, string> rules)
        {
            var next = new String[current.Length]; // create an array representing the smallest possible substrings
            var none = true;
            for (var i = 0; i < current.Length; i++)
            {
                var c = current[i];
                foreach (var r in rules)
                {
                    if (c == r.Key) // If it matches, replace that string with the successor
                    {
                        next[i] = r.Value;
                        none = false;
                    }
                }

                if (none) // If no rules apply, leave the symbol the same
                {
                    next[i] = c.ToString();
                }
                none = true;
            }

            var result = new StringBuilder();
            foreach (var s in next)
            {
                result.Append(s);
            }
            Console.WriteLine(result);

            if (iter == 0)
                return result.ToString();
            return Yield(result.ToString(), iter - 1, rules);
        }
    }
}