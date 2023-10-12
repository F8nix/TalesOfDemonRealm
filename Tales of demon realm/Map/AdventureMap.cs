using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class AdventureMap
    {
        public Dictionary<Vector2, MapObject> mapPositions = new Dictionary<Vector2, MapObject>();

        public void AddLocation() {
            mapPositions.Add(new Vector2(6, 0), MapObjectsLibrary.Wall);
            mapPositions.Add(new Vector2(0,0), MapObjectsLibrary.Wall);
        }
    }
}


// X=(0,0)      x
//          x   .   x
//      x   .   .   .   x
//      x   .   .   x
//          x   .   x
//      x   .   .   x   x
//  x   .   .   X   .   .   x
//  x   .   .   .   .   x
//      x   .   .   x
//          x   x