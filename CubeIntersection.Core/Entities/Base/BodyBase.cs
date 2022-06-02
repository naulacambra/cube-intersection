namespace CubeIntersection.Core.Entities.Base
{
    public abstract class BodyBase
    {
        /// <summary>
        /// Body's position at X axis
        /// </summary>
        public int X { get; set; } = 0;

        /// <summary>
        /// Body's position at Y axis
        /// </summary>
        public int Y { get; set; } = 0;

        /// <summary>
        /// Body's position at Z axis
        /// </summary>
        public int Z { get; set; } = 0;

        /// <summary>
        /// Width of the body
        /// </summary>
        public float Width { get; set; } = 0.0f;

        /// <summary>
        /// Body's height
        /// </summary>
        public float Height { get; set; } = 0.0f;

        /// <summary>
        /// Body's depth
        /// </summary>
        public float Depth { get; set; } = 0.0f;
    }
}
