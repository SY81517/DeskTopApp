namespace ConsoleApplication1
{
    public interface ISequence
    {
        Response Execute(Request request);

        ResponseGeneric<TResult> Execute<T1, T2, TResult>(RequestGeneric<T1, T2> requestGeneric);
    }
}