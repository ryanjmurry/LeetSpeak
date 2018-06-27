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
            else if (letter == 's' || letter == 'S')
            {
                return 'z';
            }
            else
            {
                return letter;
            }
        }

        public string ArrayReplace(string input)
        {
            char[] inputArray = input.ToCharArray();
            int start = 0;
            if (inputArray[start] == 's' || inputArray[start] == 'S')
            {
                start++;
            }
            for (int i = start; i < inputArray.Length; )
            {
                if ((inputArray[i] == 's' || inputArray[i] == 'S') && (inputArray[i - 1] == ' ' || inputArray[i - 1] == '\'' || inputArray[i - 1] == '\"'))
                {
                    i++;
                }
                else
                {
                    inputArray[i] = CharacterSwap(inputArray[i]);
                    i++;
                }
            }
            string result = string.Join("", inputArray);
            return result;
        }
    }
}
