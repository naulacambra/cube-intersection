using CubeIntersection.Core.Entities.Base;
using CubeIntersection.Core.Exceptions;

namespace CubeIntersection.Core.Entities
{
    public class Body : BodyBase
    {
        public Body(string position, string size)
        {
            var positionSplit = position.Split(", ").Select(i => i.Trim()).ToArray();
            if (positionSplit.Length != 3) throw new ArgumentException("Position must be defined by three parameters");

            this.ChangePosition(positionSplit[0], positionSplit[1], positionSplit[2]);

            var sizeSplit = size.Split(", ").Select(i => i.Trim()).ToArray();
            if (sizeSplit.Length < 1) throw new ArgumentMissingException("Size must be defined by at least one parameter");
            if (sizeSplit.Length == 2) throw new ArgumentMissingException("Size cannot be defined by only two parameters");

            if (size.Length == 1) this.ChangeSize(sizeSplit[0], sizeSplit[0], sizeSplit[0]);
            else this.ChangeSize(sizeSplit[0], sizeSplit[1], sizeSplit[2]);
        }

        public Body(int x, int y, int z, float width, float height, float depth)
        {
            this.ChangePosition(x, y, z);
            this.ChangeSize(width, height, depth);
        }

        private void ChangePosition(string sX, string sY, string sZ)
        {
            if (!int.TryParse(sX, out int iX)) throw new ArgumentOutOfRangeException(nameof(Body.X), "X is not an accepted value");
            if (!int.TryParse(sY, out int iY)) throw new ArgumentOutOfRangeException(nameof(Body.Y), "Y is not an accepted value");
            if (!int.TryParse(sZ, out int iZ)) throw new ArgumentOutOfRangeException(nameof(Body.Z), "Z is not an accepted value");

            this.ChangePosition(iX, iY, iZ);
        }

        private void ChangePosition(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        private void ChangeSize(string sWidth, string sHeight, string sDepth)
        {
            if (!float.TryParse(sWidth, out float iWidth)) throw new ArgumentOutOfRangeException(nameof(Body.Width), "Width is not an accepted value");
            if (!float.TryParse(sHeight, out float iHeight)) throw new ArgumentOutOfRangeException(nameof(Body.Height), "Height is not an accepted value");
            if (!float.TryParse(sDepth, out float iDepth)) throw new ArgumentOutOfRangeException(nameof(Body.Depth), "Depth is not an accepted value");

            this.ChangeSize(iWidth, iHeight, iDepth);
        }

        private void ChangeSize(float width, float height, float depth)
        {
            if (width < 0) throw new ArgumentOutOfRangeException(nameof(Body.Width), "Width cannot be negative");
            if (height < 0) throw new ArgumentOutOfRangeException(nameof(Body.Height), "Height cannot be negative");
            if (depth < 0) throw new ArgumentOutOfRangeException(nameof(Body.Depth), "Depth cannot be negative");

            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }
    }
}
