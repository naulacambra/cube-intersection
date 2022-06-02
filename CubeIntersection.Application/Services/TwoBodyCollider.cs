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
        public TwoBodyCollider(IBodyCollider a, IBodyCollider b)
        {
            this.A = a;
            this.B = b;
        }

        public IBodyCollider A { get; set; }

        public IBodyCollider B { get; set; }

        public bool ValidateBodies()
        {
            throw new NotImplementedException();
        }

        public bool Collides()
        {
            if (!this.ValidateBodies()) throw new NonValidBodyException();

            throw new NotImplementedException();
        }
    }
}
