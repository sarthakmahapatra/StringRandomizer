using System;
namespace StringRandomizer.Options
{
    /// <summary>
    /// Default randomizer options.
    /// </summary>
    public class DefaultRandomizerOptions : IRandomizerOptions
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="StringRandomizer.Options.DefaultRandomizerOptions"/> has numbers.
        /// </summary>
        /// <value><c>true</c> if has numbers; otherwise, <c>false</c>.</value>
        public bool HasNumbers { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="StringRandomizer.Options.DefaultRandomizerOptions"/> has
        /// lower alphabets.
        /// </summary>
        /// <value><c>true</c> if has lower alphabets; otherwise, <c>false</c>.</value>
        public bool HasLowerAlphabets { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="StringRandomizer.Options.DefaultRandomizerOptions"/> has
        /// upper alphabets.
        /// </summary>
        /// <value><c>true</c> if has upper alphabets; otherwise, <c>false</c>.</value>
        public bool HasUpperAlphabets { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringRandomizer.Options.DefaultRandomizerOptions"/> class.
        /// </summary>
        /// <param name="hasNumbers">If set to <c>true</c> has numbers.</param>
        /// <param name="hasUpperAlphabets">If set to <c>true</c> has upper alphabets.</param>
        /// <param name="hasLowerAlphabets">If set to <c>true</c> has lower alphabets.</param>
        public DefaultRandomizerOptions(bool hasNumbers = true, bool hasUpperAlphabets =true, bool hasLowerAlphabets = false)
        {
            HasNumbers = hasNumbers;
            HasUpperAlphabets = hasUpperAlphabets;
            HasLowerAlphabets = hasLowerAlphabets;
        }
    }
}
