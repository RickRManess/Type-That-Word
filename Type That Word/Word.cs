using System;
using System.Collections.Generic;
using System.Text;

namespace Type_That_Word
{
    class Word
    {

        public int lineNumber;
        public string sentence;

        public override string ToString()
        {
            return $"{sentence}";
        }
    }
}
