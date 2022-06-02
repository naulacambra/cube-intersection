using CubeIntersection.Core.Entities.Base;

namespace CubeIntersection.Core.Interfaces
{
    public interface IBodyCollider : IBody
    {
        bool Collides(IBodyCollider body);
    }
}
