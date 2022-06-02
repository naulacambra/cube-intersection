using CubeIntersection.Core.Entities.Base;

namespace CubeIntersection.Core.Interfaces
{
    public interface ICollider
    {
        bool Collides(BodyBase body);
    }
}
