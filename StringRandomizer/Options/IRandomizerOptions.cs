using System;
namespace StringRandomizer.Options
{
    /// <summary>
    /// Randomizer options.
    /// </summary>
    public interface IRandomizerOptions
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="StringRandomizer.Options.IRandomizerOptions"/> has numbers.
        /// </summary>
        /// <value><c>true</c> if has numbers; otherwise, <c>false</c>.</value>
        bool HasNumbers { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="StringRandomizer.Options.IRandomizerOptions"/> has lower alphabets.
        /// </summary>
        /// <value><c>true</c> if has lower alphabets; otherwise, <c>false</c>.</value>
        bool HasLowerAlphabets { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="StringRandomizer.Options.IRandomizerOptions"/> has upper alphabets.
        /// </summary>
        /// <value><c>true</c> if has upper alphabets; otherwise, <c>false</c>.</value>
        bool HasUpperAlphabets { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="StringRandomizer.Options.IRandomizerOptions"/> has special chars.
        /// </summary>
        /// <value><c>true</c> if has special chars; otherwise, <c>false</c>.</value>
        bool HasSpecialChars { get; }
    }
}
