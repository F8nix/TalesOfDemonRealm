using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_of_demon_realm
{
    class MapObjectsLibrary
    {
        public static MapObject Wall = new MapObject(true, "x");
        public static MapObject Walkable = new MapObject(false, "."); //nadpisywac potem . na, na przyklad E jak enemy, N jak Npc, I jak Into, O jak Out
    }
}
