namespace CubeIntersection.Core.Exceptions
{
    public class ArgumentMissingException : ArgumentException
    {
        public ArgumentMissingException(string message) : base(message)
        {

        }

        public ArgumentMissingException(string message, string paramName) : base(message, paramName)
        {

        }
    }
}
