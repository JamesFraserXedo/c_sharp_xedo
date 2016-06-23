﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace XedoFramework.Core.Contexts
{
    public class QuickTryOnContext
    {
        public string EnteredAddress1 { get; set; }
        public string EnteredAddress2 { get; set; }
        public string EnteredCity { get; set; }
        public string EnteredState { get; set; }
        public string EnteredStateCode { get; set; }
        public string EnteredZip { get; set; }

        public string ThePocketSquareColour { get; set; }
    }
}