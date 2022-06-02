using CubeIntersection.Core.Entities.Base;

namespace CubeIntersection.Core.Interfaces
{
    public interface IBodyCollider
    {
        bool Collides(BodyBase body);
    }
}
