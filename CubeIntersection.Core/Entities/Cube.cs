using CubeIntersection.Core.Entities.Base;
using CubeIntersection.Core.Interfaces;

namespace CubeIntersection.Core.Entities
{
    public class Cube : Body, IBodyCollider
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

        public bool Collides(IBodyCollider body)
        {
            var distanceX = Math.Abs(this.X - body.X);
            var distanceY = Math.Abs(this.Y - body.Y);
            var distanceZ = Math.Abs(this.Z - body.Z);

            var xAxis = distanceX < (this.Width / 2) + (body.Width / 2);
            var yAxis = distanceY < (this.Height / 2) + (body.Height / 2);
            var zAxis = distanceZ < (this.Depth / 2) + (body.Depth / 2);

            return xAxis && yAxis && zAxis;
        }
    }
}
