using CubeIntersection.Core.Entities.Base;
using CubeIntersection.Core.Interfaces;

namespace CubeIntersection.Core.Entities
{
    public class Cube : Body, ICollider
    {
        public Cube()
        {

        }

        public Cube(string position, string size) : base(position, size)
        {
        }

        public Cube(int x, int y, int z, float width, float height, float depth) : base(x, y, z, width, height, depth)
        {
        }

        public bool Collides(BodyBase body)
        {
            throw new NotImplementedException();
        }
    }
}
