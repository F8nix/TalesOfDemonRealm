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
        public Player playerReference;
        public static MapObject defaultObject = new MapObject();

        public void InitializeLocations() {
            mapPositions.Add(new Vector2(6, 0), MapObjectsLibrary.Wall);

            mapPositions.Add(new Vector2(5, -1), MapObjectsLibrary.Wall);
            mapPositions.Add(new Vector2(5, 0), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(5, 1), MapObjectsLibrary.Wall);

            mapPositions.Add(new Vector2(4, -2), MapObjectsLibrary.Wall);
            mapPositions.Add(new Vector2(4, -1), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(4, 0), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(4, 1), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(4, 2), MapObjectsLibrary.Wall);

            mapPositions.Add(new Vector2(3, -2), MapObjectsLibrary.Wall);
            mapPositions.Add(new Vector2(3, -1), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(3, 0), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(3, 1), MapObjectsLibrary.Wall);

            mapPositions.Add(new Vector2(2, -1), MapObjectsLibrary.Wall);
            mapPositions.Add(new Vector2(2, 0), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(2, 1), MapObjectsLibrary.Wall);

            mapPositions.Add(new Vector2(1, -2), MapObjectsLibrary.Wall);
            mapPositions.Add(new Vector2(1, -1), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(1, 0), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(1, 1), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(1, 2), MapObjectsLibrary.Wall);

            mapPositions.Add(new Vector2(0, -3), MapObjectsLibrary.Wall);
            mapPositions.Add(new Vector2(0, -2), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(0, -1), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(0, 0), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(0, 1), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(0, 2), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(0, 3), MapObjectsLibrary.Wall);

            mapPositions.Add(new Vector2(-1, -3), MapObjectsLibrary.Wall);
            mapPositions.Add(new Vector2(-1, -2), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(-1, -1), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(-1, 0), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(-1, 1), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(-1, 2), MapObjectsLibrary.Wall);

            mapPositions.Add(new Vector2(-2, -2), MapObjectsLibrary.Wall);
            mapPositions.Add(new Vector2(-2, -1), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(-2, 0), MapObjectsLibrary.Walkable);
            mapPositions.Add(new Vector2(-2, 1), MapObjectsLibrary.Wall);

            mapPositions.Add(new Vector2(-3, -1), MapObjectsLibrary.Wall);
            mapPositions.Add(new Vector2(-3, 0), MapObjectsLibrary.Wall);
        }

        public void MapPrint() {
            playerReference = new Player();
            int rows = 10;
            int columns = 17;
            for (int i = 0; i > -rows; i--) {
                Console.WriteLine("");
                Console.WriteLine("");
                for (int j = 0; j < columns; j++) {
                    Console.Write("  ");
                    if (j == 0 || j == columns - 1) {
                        if (i == 0 || i == -rows + 1)
                        {
                            Console.Write("#");
                        }
                        else {
                            Console.Write("|");
                        }
                        
                    } else {
                        if (i == 0 || i == -rows + 1)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Vector2 objectPositionChange = new Vector2(i + (rows/2),j - (columns / 2));
                            Console.Write(mapPositions.GetValueOrDefault(objectPositionChange + playerReference.playerPosition, defaultObject).mapSignature);
                        }
                    }
                }
            }
        }
    }
}


// ;=(0,0)      x
//          x   .   x
//      x   .   .   .   x
//      x   .   .   x
//          x   .   x
//      x   .   .   x   x
//  x   .   .   ;   .   .   x
//  x   .   .   .   .   x
//      x   .   .   x
//          x   x