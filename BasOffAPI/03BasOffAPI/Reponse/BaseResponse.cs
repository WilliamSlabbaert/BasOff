namespace Reponse
{
    public class BaseResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public object ResponseBody { get; set; }

        public BaseResponse(string code, string message, object responseBody)
        {
            Code = code;
            Message = message;
            ResponseBody = responseBody;
        }
    }
}
