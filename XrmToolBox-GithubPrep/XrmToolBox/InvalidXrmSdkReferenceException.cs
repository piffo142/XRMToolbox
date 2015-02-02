﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrmToolBox
{
    [Serializable()]
    public class InvalidXrmSdkReferenceException : Exception
    {
        public InvalidXrmSdkReferenceException(string format, params object[] args) : base(String.Format(format, args))
        {
        }
    }
}
