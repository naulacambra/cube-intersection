using CubeIntersection.Core.Entities.Base;

namespace CubeIntersection.Application.Interfaces
{
    internal interface ICollider
    {
        bool ValidateBodies();

        bool Collides();

        float Intersection();
    }
}
