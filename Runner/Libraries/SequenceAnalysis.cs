using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Libraries
{
    class SequenceAnalysis
    {
        public string UppercaseChars(string input)
        {
            return new string(input.ToCharArray().Where(c => char.IsUpper(c)).ToArray());
        } 
    }
}
