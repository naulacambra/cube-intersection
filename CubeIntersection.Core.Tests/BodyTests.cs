namespace CubeIntersection.Core.Tests
{
    public class BodyTests
    {
        [Fact]
        public void Body_Constructor_Negative_Size()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Body(0, 0, 0, -1, -1, -1));
        }

        [Fact]
        public void Body_Constructor_Empty_Strings()
        {
            Assert.Throws<ArgumentException>(() => new Body("", ""));
        }

        [Fact]
        public void Body_Constructor_Negative_Size_Strings()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Body("0, 0, 0", "-1, -1, -1"));
        }

        [Fact]
        public void Body_Constructor_Missing_Strings_Arguments()
        {
            Assert.Throws<ArgumentMissingException>(() => new Body("0, 0, 0", "-1, -1"));
        }
    }
}