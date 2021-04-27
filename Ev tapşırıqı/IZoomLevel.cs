using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_tapşırıqı
{
    interface IZoomLevel
    {
        int Zoomlevel { get; set; }
        void ZoomIn();
        void ZoomOut();
    }
}
