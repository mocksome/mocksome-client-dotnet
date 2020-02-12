using Mocksome.Client.Query;

namespace Mocksome.Client
{
    public static class Queries
    {
        public static Header Header(string key, string value)
        {
            return new Header(key, value);
        }

        public static Path Path(string path)
        {
            return new Path(path);
        }

        public static Method Method(string method)
        {
            return new Method(method);
        }

        public static Body Body()
        {
            return new Body();
        }
    }
}
