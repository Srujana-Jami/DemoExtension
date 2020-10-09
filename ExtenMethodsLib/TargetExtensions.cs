using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static ExtenMethods.Lib.Target;

namespace ExtenMethods.Lib
{
    public static class TargetExtensions
    {
        internal static void ExtendInetrnal(this InternalTarget target)
        {

        }

        public static string GetStandardizedId(this Target target)
        {
            return target.GetId().ToUpper();
        }
        
    }
}
