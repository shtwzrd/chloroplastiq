// <summary>
//   The product.
// </summary>
namespace Chloroplastiq.Grammar
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The product.
    /// </summary>
    public class Product
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="w">
        /// The w.
        /// </param>
        /// <param name="p">
        /// The p.
        /// </param>
        public Product(string w, Dictionary<char, string> p)
        {
            this.Axiom = w;
            this.Alphabet = this.Axiom;
            this.Rules = p;
        }

        #endregion

        #region Fields

        /// <summary>
        /// Gets or sets the alphabet.
        /// </summary>
        public string Alphabet { get; set; }

        /// <summary>
        /// Gets or sets the rules.
        /// </summary>
        public IDictionary<char, string> Rules { get; set; }

        #endregion

        // / <summary>
        // / Gets or sets Axiom
        // / </summary>

        // / <summary>
        // / Gets or sets Angle
        // / </summary>
        #region Public Properties

        /// <summary>
        /// Gets or sets the angle.
        /// </summary>
        public float Angle { get; set; }

        /// <summary>
        /// Gets or sets the axiom.
        /// </summary>
        public string Axiom { get; set; }

        // / <summary>
        // / Gets or sets Iterations
        // / </summary>

        /// <summary>
        /// Gets or sets the iterations.
        /// </summary>
        public ushort Iterations { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The yield.
        /// </summary>
        /// <param name="current">
        /// The current.
        /// </param>
        /// <param name="iter">
        /// The iteration.
        /// </param>
        /// <param name="rules">
        /// The rules.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string Yield(string current, int iter, IDictionary<char, string> rules)
        {
            var next = new string[current.Length]; // create an array representing the smallest possible substrings
            var none = true;
            for (var i = 0; i < current.Length; i++)
            {
                var c = current[i];
                foreach (var r in rules)
                {
                    if (c == r.Key)
                    {
                        // If it matches, replace that string with the successor
                        next[i] = r.Value;
                        none = false;
                    }
                }

                if (none)
                {
                    // If no rules apply, leave the symbol the same
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
            {
                return result.ToString();
            }

            return this.Yield(result.ToString(), iter - 1, rules);
        }

        #endregion
    }
}