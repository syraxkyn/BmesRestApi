using System.Net;

namespace BmesRestApi.Messages.Response
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Messages=new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public List<string> Messages;
    }
}
