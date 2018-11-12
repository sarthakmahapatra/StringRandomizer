using System;
namespace StringRandomizer.Options
{
    /// <summary>
    /// Default randomizer options.
    /// </summary>
    public class DefaultRandomizerOptions : IRandomizerOptions
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:StringRandomizer.Options.DefaultRandomizerOptions"/> has numbers.
        /// </summary>
        /// <value><c>true</c> if has numbers; otherwise, <c>false</c>.</value>
        public bool HasNumbers => true;

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:StringRandomizer.Options.DefaultRandomizerOptions"/> has
        /// lower alphabets.
        /// </summary>
        /// <value><c>true</c> if has lower alphabets; otherwise, <c>false</c>.</value>
        public bool HasLowerAlphabets => false;

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:StringRandomizer.Options.DefaultRandomizerOptions"/> has
        /// upper alphabets.
        /// </summary>
        /// <value><c>true</c> if has upper alphabets; otherwise, <c>false</c>.</value>
        public bool HasUpperAlphabets => true;
    }
}
