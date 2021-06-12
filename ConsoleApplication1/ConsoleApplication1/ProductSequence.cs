using System;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    class ProductSequence : ISequence
    {
        public Response Execute(Request request)
        {
            var response= new Response();
            var jsonString = JsonConvert.SerializeObject(request.Body as Product);
            Console.WriteLine(jsonString);
            response.Result = AppResult.Ok;
            return response;
        }
        public ResponseGeneric<TResult> Execute<T1,T2,TResult>(RequestGeneric<T1,T2> request)
        {
            var jsonString = JsonConvert.SerializeObject(request.Body);
            Console.WriteLine(jsonString);
            var response= new ResponseGeneric<TResult>()
            {
                Result = AppResult.Ok,
                Body = JsonConvert.DeserializeObject<TResult>(jsonString)
            };
            return response;
        }

    }
}