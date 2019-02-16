using System.Collections.Generic;

namespace XunitCoreProj1.Common
{
    public class Configurations
    {

public static IEnumerable<object[]> BrowserData =>
            new List<object[]>
                {
                    new object[] {"Firefox"},
                    new object[] {"Chrome"},
                   new object[] {"Edge"},
                   /*  new object[] {"IE"} */
                };
    }

}