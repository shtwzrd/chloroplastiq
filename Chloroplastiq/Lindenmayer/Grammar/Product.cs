﻿/*******************************************************
 * Brandon Lucas
 * 30 December 2011
 * Chloroplastiq (Mono-port)
*******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chloroplastiq.Lindenmayer.Grammar
{
    public class Product
    {
        public Product(string w, List<ProductionRule> P)
        {
            Axiom = w;
            Alphabet = Axiom;
            Rules = P;
        }
        
        //This function is responsible for generating each iteration of the grammar mutation
        //In parallel
        public string Yield(String current, int iter, List<ProductionRule> rules)
        {
            String[] next = new String[current.Length]; //create an array representing the smallest possible substrings
            bool none = true;
            for (int i = 0; i < current.Length; i++)
            {
                char c = current[i];
                foreach (ProductionRule r in rules)
                {
                    if (c == r.Predecessor) //If it matches, replace that string with the successor
                    {
                        next[i] = r.Successor;
                        none = false;
                    }
                }
                if (none) //If no rules apply, leave the symbol the same
                {
                    next[i] = c.ToString();
                }
                none = true;
            }

            StringBuilder result = new StringBuilder();
            foreach (string s in next)
            {
                result.Append(s);
            }
            Console.WriteLine(result);
            if (iter == 0)
                return result.ToString();
            else
                return Yield(result.ToString(), iter - 1, rules); //recursive call
        }

        public List<ProductionRule> Rules;
        public string Alphabet;
        public string Axiom { get; set; }
        public float Angle { get; set; }
        public ushort Iterations { get; set; }
    
    }
}
