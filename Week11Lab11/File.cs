using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Lab11
{
    class File: Document      // file is derived from document not from email
    {
        private string pathName;

        public string GetPathName()
        {
            return pathName;
        }

        public void SetpathName(string path)
        {
            pathName = path;
        }


        public override string ToString()
        {
            return "the path name is " + pathName + " The text is " + GetText();
        }

    }

   
}
