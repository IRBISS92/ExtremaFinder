using DevExpress.XtraCharts;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExtremaFinder.Models
{
    public class Problem
    {
        public string Function { get; set; }
        public int LowerLimit { get; set; }
        public int HigherLimit { get; set; }
    }
}