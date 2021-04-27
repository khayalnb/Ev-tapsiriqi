using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_tapşırıqı
{
    class Silah
    {
        public int TotalPistolCount { get; set; }
        public int CurrentPistolCount { get; set; }
        public float PistolType { get; set; }
        public void Shoot() { } 
        public void Reload() { }

    }
    class P92 : Silah
    {

    }

    class M416 : Silah, IZoomLevel, ChangeMode
    {
        public int Zoomlevel { get ; set; }
        public ShootMode shootmode { get; set; }

        public void changeMode()
        {
            throw new NotImplementedException();
        }

        public void ZoomIn()
        {
            throw new NotImplementedException();
        }

        public void ZoomOut()
        {
            throw new NotImplementedException();
        }
        class Mk14 : Silah, IZoomLevel,ChangeMode
        {
            public int Zoomlevel { get; set; }
            public ShootMode shootmode { get ; set; }

            public void changeMode()
            {
                throw new NotImplementedException();
            }

            public void ZoomIn()
            {
                throw new NotImplementedException();
            }

            public void ZoomOut()
            {
                throw new NotImplementedException();
            }
        }
    }
    class M24 : Silah, IZoomLevel
    {
        public int Zoomlevel { get ; set ; }

        public void ZoomIn()
        {
            throw new NotImplementedException();
        }

        public void ZoomOut()
        {
            throw new NotImplementedException();
        }
    }
}
   