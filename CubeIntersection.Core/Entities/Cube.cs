using CubeIntersection.Core.Entities.Base;
using CubeIntersection.Core.Interfaces;

namespace CubeIntersection.Core.Entities
{
    internal class Cube : BodyBase, ICollider
    {
        public bool Collides(BodyBase body)
        {
            throw new NotImplementedException();
        }
    }
}
