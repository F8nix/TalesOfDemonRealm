using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class MapObject
    {
        public bool isWall;
        public string mapSignature;
        //jakis event/sluchacz
        public MapObject(bool isWall, string mapSignature) {
            this.isWall = isWall;
            this.mapSignature = mapSignature;
        }
        public MapObject() { }
    }
}
