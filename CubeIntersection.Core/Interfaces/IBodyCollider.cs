namespace CubeIntersection.Core.Interfaces
{
    public interface IBodyCollider : IBody
    {
        /// <summary>
        /// Determines if this IBodyCollider and body collides in any axis
        /// </summary>
        /// <param name="body">IBodyCollider with this have to check</param>
        /// <returns>True if they collide</returns>
        bool Collides(IBodyCollider body);

        /// <summary>
        /// Compute the volume of the intersection between this IBodyCollider and body
        /// </summary>
        /// <param name="body">IBodyCollider with this have to check</param>
        /// <returns>Volume of the intersection</returns>
        float Intersection(IBodyCollider body);
    }
}
