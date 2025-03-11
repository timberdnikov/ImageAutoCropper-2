using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageAutoCropper
{
    public static class ExceptionHelper
    {
        public static int LineNumber(this Exception e)
        {
            int linenum = 0;
            try { linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(' '))); }
            catch { }
            return linenum;
        }
    }
}
