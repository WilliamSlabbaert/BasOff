using System.Runtime.CompilerServices;

namespace _02BasOffBL.Reponse
{
    public class BaseResponse
    {
        public string Code { get; private set; }
        public string Message { get; private set; }
        public object ResponseBody { get; private set; }

        public BaseResponse FailedResponse(string message)
        {
            Code = "400";
            Message = message;
            ResponseBody = null;

            return this;
        }

        public BaseResponse SuccessResponse(string message, object response)
        {
            Code = "200";
            Message = message;
            ResponseBody = response;

            return this;
        }
    }
}
