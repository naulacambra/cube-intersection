using CubeIntersection.Application.Exceptions;
using CubeIntersection.Application.Interfaces;
using CubeIntersection.Core.Interfaces;

namespace CubeIntersection.Application.Services
{
    /// <summary>
    /// Class to manage two bodies, and see how they interact with each other
    /// </summary>
    public class TwoBodyCollider : ICollider
    {
        public TwoBodyCollider()
        {

        }

        public TwoBodyCollider(IBodyCollider? a, IBodyCollider? b) : base()
        {
            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);

            this.A = a;
            this.B = b;
        }

        public IBodyCollider A { get; private set; }

        public IBodyCollider B { get; private set; }

        public void SetBodies(IBodyCollider? a, IBodyCollider? b)
        {
            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);

            this.A = a;
            this.B = b;
        }

        /// <summary>
        /// Validate collider's bodies are valid
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NonValidBodyException">Thrown if any collider's body are null</exception>
        public bool ValidateBodies()
        {
            ArgumentNullException.ThrowIfNull(this.A, nameof(this.A));
            ArgumentNullException.ThrowIfNull(this.B, nameof(this.B));

            return true;
        }

        /// <summary>
        /// Checks if collider's bodies collides between them
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NonValidBodyException">Thrown if any collider's body are not valid</exception>
        public bool Collides()
        {
            if (!this.ValidateBodies()) throw new NonValidBodyException();

            if (this.A.Collides(this.B)) return true;

            return false;
        }

        /// <summary>
        /// Returns intersection volume between collider's bodies
        /// </summary>
        /// <returns>Intersection volume</returns>
        /// <exception cref="NonValidBodyException">Thrown if any collider's body are not valid</exception>
        public float Intersection()
        {
            if (!this.ValidateBodies()) throw new NonValidBodyException();

            if (!this.A.Collides(this.B)) return 0.0f;

            return A.Intersection(this.B);
        }
    }
}
