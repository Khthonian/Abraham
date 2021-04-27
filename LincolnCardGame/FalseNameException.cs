﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LincolnCardGame
{
    public class FalseNameException : Exception
    {
        public FalseNameException()
        {
        }

        public FalseNameException(string message)
            : base(message)
        {
        }

        public FalseNameException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
