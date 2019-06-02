﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EP.Hangman.Logic.Models
{
    /// <summary>
    /// Response data model that user will see
    /// </summary>
    public class HangmanDataResponse
    {
        /// <summary>
        /// Property stores guessed letters
        /// </summary>
        public IEnumerable<string> CorrectLettersTempData { get; set; }
        /// <summary>
        /// Property stores user's attempts
        /// </summary>
        public int UserAttempts { get; set; }
        /// <summary>
        /// Property stores alphabet letters 
        /// </summary>
        public IEnumerable<string> AlphabetTempData { get; set; }
    }
}