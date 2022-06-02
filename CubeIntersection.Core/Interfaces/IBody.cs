namespace CubeIntersection.Core.Interfaces
{
    public interface IBody
    {
        /// <summary>
        /// Body's position at X axis
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Body's position at Y axis
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Body's position at Z axis
        /// </summary>
        public int Z { get; set; }

        /// <summary>
        /// Width of the body
        /// </summary>
        public float Width { get; set; }

        /// <summary>
        /// Body's height
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// Body's depth
        /// </summary>
        public float Depth { get; set; }
    }
}
