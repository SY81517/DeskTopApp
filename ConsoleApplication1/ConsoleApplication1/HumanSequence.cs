using System;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    public class HumanSequence : ISequence
    {
        public Response Execute(Request request)
        {
            var response= new Response();
            var humanDto = new HumanDto()
            {
                Id = request.UriParam as string,
                Human = request.Body as Human,
            };
            var jsonString = JsonConvert.SerializeObject(humanDto);
            Console.WriteLine(jsonString);
            response.Result = AppResult.Ok;
            return response;
        }

        public ResponseGeneric<TResult> Execute<T1, T2, TResult>(RequestGeneric<T1, T2> requestGeneric)
        {
            var jsonString = JsonConvert.SerializeObject(requestGeneric.Body);
            Console.WriteLine(jsonString);
            var response = new ResponseGeneric<TResult>()
            {
                Result = AppResult.Ok,
            };
            return response;
        }
    }
}