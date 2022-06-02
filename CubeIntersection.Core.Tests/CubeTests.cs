namespace CubeIntersection.Core.Tests
{
    public class CubeTests
    {
        [Fact]
        public void Cube_Collides_With_Same_Position()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(0, 0, 0, 10, 10, 10);

            Assert.True(a.Collides(b));
            Assert.True(b.Collides(a));
        }

        [Fact]
        public void Cube_Collides_In_X_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(5, 0, 0, 10, 10, 10);

            Assert.True(a.Collides(b));
            Assert.True(b.Collides(a));
        }

        [Fact]
        public void Cube_Collides_Not_In_X_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(20, 0, 0, 10, 10, 10);

            Assert.False(a.Collides(b));
            Assert.False(b.Collides(a));
        }

        [Fact]
        public void Cube_Collides_In_Y_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(0, 5, 0, 10, 10, 10);

            Assert.True(a.Collides(b));
            Assert.True(b.Collides(a));
        }

        [Fact]
        public void Cube_Collides_Not_In_Y_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(0, 20, 0, 10, 10, 10);

            Assert.False(a.Collides(b));
            Assert.False(b.Collides(a));
        }

        [Fact]
        public void Cube_Collides_In_Z_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(0, 0, 5, 10, 10, 10);

            Assert.True(a.Collides(b));
            Assert.True(b.Collides(a));
        }

        [Fact]
        public void Cube_Collides_Not_In_Z_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(0, 0, 20, 10, 10, 10);

            Assert.False(a.Collides(b));
            Assert.False(b.Collides(a));
        }

        [Fact]
        public void Cube_Collides_In_X_And_Y_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(5, 5, 0, 10, 10, 10);

            Assert.True(a.Collides(b));
            Assert.True(b.Collides(a));
        }

        [Fact]
        public void Cube_Collides_In_X_And_Y_And_Z_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(5, 5, 5, 10, 10, 10);

            Assert.True(a.Collides(b));
            Assert.True(b.Collides(a));
        }

        [Fact]
        public void Cube_Not_Collides_In_X_And_Y_And_Z_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(5, 5, 20, 10, 10, 10);

            Assert.False(a.Collides(b));
            Assert.False(b.Collides(a));
        }

        [Fact]
        public void Cube_Not_Collides_Adjacent_In_X_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(10, 0, 0, 10, 10, 10);

            Assert.False(a.Collides(b));
            Assert.False(b.Collides(a));
        }

        [Fact]
        public void Cube_Not_Collides_Adjacent_In_Y_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(0, 10, 0, 10, 10, 10);

            Assert.False(a.Collides(b));
            Assert.False(b.Collides(a));
        }

        [Fact]
        public void Cube_Not_Collides_Adjacent_In_Z_Axis()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(0, 0, 10, 10, 10, 10);

            Assert.False(a.Collides(b));
            Assert.False(b.Collides(a));
        }

        [Fact]
        public void Cube_Intersects_Full_Volume()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(0, 0, 0, 10, 10, 10);

            Assert.Equal(a.Width * a.Height * a.Depth, a.Intersection(b));
            Assert.Equal(b.Width * b.Height * b.Depth, b.Intersection(a));
        }

        [Fact]
        public void Cube_Intersects_Half_Volume()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(0, 5, 0, 10, 10, 10);

            Assert.Equal((a.Width * a.Height * a.Depth) / 2, a.Intersection(b));
            Assert.Equal((b.Width * b.Height * b.Depth) / 2, b.Intersection(a));
        }

        [Fact]
        public void Cube_Intersects_Quarter_Volume()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(0, 5, 5, 10, 10, 10);

            Assert.Equal((a.Width * a.Height * a.Depth) / 4, a.Intersection(b));
            Assert.Equal((b.Width * b.Height * b.Depth) / 4, b.Intersection(a));
        }

        [Fact]
        public void Cube_Intersects_1_unit()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(9, 9, 9, 10, 10, 10);

            Assert.Equal(1.0f, a.Intersection(b));
            Assert.Equal(1.0f, b.Intersection(a));
        }

        [Fact]
        public void Cube_Intersects_0_Units_With_Non_Colliding()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(20, 0, 0, 10, 10, 10);

            Assert.Equal(0.0f, a.Intersection(b));
            Assert.Equal(0.0f, b.Intersection(a));
        }

        [Fact]
        public void Cube_Intersects_0_Units_With_Adjacent()
        {
            var a = new Cube(0, 0, 0, 10, 10, 10);
            var b = new Cube(10, 10, 10, 10, 10, 10);

            Assert.Equal(0.0f, a.Intersection(b));
            Assert.Equal(0.0f, b.Intersection(a));
        }
    }
}