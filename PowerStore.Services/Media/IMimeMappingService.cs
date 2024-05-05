using System;
using System.Collections.Generic;
using System.Text;

namespace PowerStore.Services.Media
{
    public partial interface IMimeMappingService
    {
        string Map(string fName);
    }
}
