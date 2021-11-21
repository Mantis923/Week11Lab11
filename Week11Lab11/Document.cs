using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Lab11
{
    
    class Document
    {
        
        private string text;

        public string GetText()
        {
            return text;
        }

        public void SetText(string inputText)
        {
            text = inputText;
        }
        public override string ToString() { return text; }
    }
}
