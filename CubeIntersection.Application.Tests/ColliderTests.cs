namespace CubeIntersection.Application.Tests
{
    public class ColliderTests
    {
        ColliderBuilder Builder { get; set; } = new ColliderBuilder();

        [Fact]
        public void Collider_checks_nulls()
        {
            var collider = Builder.GetTwoBodyCollider();

            Assert.Throws<NonValidBodyException>(() => collider.Collides());           
        }
    }
}