using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenerator
{
    public static class StringPlus
    {
        /// <summary>
        /// tab
        /// </summary>
        public const string tab = "\t";
        /// <summary>
        /// newline
        /// </summary>
        public const string newLine = "\r\n";

        public static StringBuilder AppendWithTab(this StringBuilder builder, int tabCount, string text)
        { 
            for (int i  = 1;tabCount > 0 && i <= tabCount; i++)
			{
			    builder.Append(tab);
			}
            return builder.AppendLine(text);
        }

        public static StringBuilder AppendWithNewline(this StringBuilder builder, string text)
        {
            return builder.AppendLine(text);
        }
    }
}
