using System;
using System.Collections.Generic;

namespace Translator
{
    public class LeetSpeak
    {
        public char CharacterSwap(char letter)
        {
            if (letter == 'e' || letter == 'E')
            {
                return '3';
            }
            else if (letter == 'o' || letter == 'O')
            {
                return '0';
            }
            else if (letter == 'I')
            {
                return '1';
            }
            else if (letter == 't' || letter == 'T')
            {
                return '7';
            }
            else
            {
                return letter;
            }
        }
    }
}
