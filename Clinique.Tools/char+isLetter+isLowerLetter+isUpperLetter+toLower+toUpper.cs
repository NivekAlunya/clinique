﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Tools
{
    public static class CharExtension
    {
        public static bool isLetter(this char _char)
        {
            return 65 <= (int)_char && 90 >= (int)_char || 97 <= (int)_char && 122 >= (int)_char;
        }
        public static bool isLowerLetter(this char _char)
        {
            return 97 <= (int)_char && 122 >= (int)_char;
        }
        public static bool isUpperLetter(this char _char)
        {
            return 65 <= (int)_char && 90 >= (int)_char;
        }

        public static char toLower(this char _char)
        {
            return _char.isUpperLetter() ? (char)((int)_char + 32) : _char;
        }

        public static char toUpper(this char _char)
        {
            return _char.isLowerLetter()?(char)((int)_char - 32):_char;
        }


    }
}
