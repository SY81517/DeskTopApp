namespace ConsoleApplication1
{
    public class Request
    {
        public object UriParam { get; set; }
        public object Body { get; set; }
    }

    public class RequestGeneric<T1,T2>
    {
        public T1 UriParam { get; set; }
        public T2 Body { get; set; }
    }
}