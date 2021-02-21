using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gov.Uk.Net.Library.Enums
{
    public class HTMLEnums
    {
        public enum HeadingLevel
        {
            h1 = 0, // Default
            h2,
            h3,
            h4,
            h5,
            h6
        }

        public enum ButtonType
        {
            input = 0, // Default
            button,
            a
        }
    }
}
