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
        public void Body_Constructor_Null_Position()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => new Body(null, ""));

            Assert.Equal("Position", exception.ParamName);
        }

        [Fact]
        public void Body_Constructor_Null_Size()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => new Body("", null));

            Assert.Equal("Size", exception.ParamName);
        }

        [Fact]
        public void Body_Constructor_Empty_Strings()
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Body("", ""));

            Assert.Equal("Position", exception.ParamName);
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