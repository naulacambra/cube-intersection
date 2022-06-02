namespace CubeIntersection.Core.Tests
{
    public class CubeTests
    {
        [Fact]
        public void Cube_Constructor_Negative_Size()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Cube(0, 0, 0, -1, -1, -1));
        }

        [Fact]
        public void Cube_Constructor_Empty_Strings()
        {
            Assert.Throws<ArgumentException>(() => new Cube("", ""));
        }

        [Fact]
        public void Cube_Constructor_Negative_Size_Strings()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Cube("0, 0, 0", "-1, -1, -1"));
        }

        [Fact]
        public void Cube_Constructor_Missing_Strings_Arguments()
        {
            Assert.Throws<ArgumentMissingException>(() => new Cube("0, 0, 0", "-1, -1"));
        }
    }
}