namespace ConsoleApplication1
{
    public class Response
    {
        public object Body { get; set; }
        public AppResult Result { get; set; }
    }

    public class ResponseGeneric<T>
    {
        public T Body { get; set; }
        public AppResult Result { get; set; }
    }
}