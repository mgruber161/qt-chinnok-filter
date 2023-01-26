#if GENERATEDCODE_ON
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTChinnok.Logic.Controllers.Base
{
    partial class ArtistsController
    {
        internal override IEnumerable<string> Includes => new string[] { nameof(Entities.Base.Artist.Albums) };
    }
}
#endif