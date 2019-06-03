﻿using System.Collections.Generic;

namespace EP.Hangman.Logic.Models
{
    /// <summary>
    /// Response data model that user will see
    /// </summary>
    public class UserGameData
    {
        /// <summary>
        /// Property stores User's ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Property stores guessed letters
        /// </summary>
        public IEnumerable<string> CorrectLettersTempData { get; set; }

        /// <summary>
        /// Property stores user's attempts
        /// </summary>
        public int UserErrors { get; set; }

        /// <summary>
        /// Property stores alphabet letters 
        /// </summary>
        public IEnumerable<string> AlphabetTempData { get; set; }
    }
}