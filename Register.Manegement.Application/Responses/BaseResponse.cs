using System.Collections;
namespace Register.Manegement.Application.Responses
{
    public class BaseResponse
    {
        public  bool Success { get; set; }
        public ICollection? Erros { get; set; }
        public BaseResponse() 
        {
            Success = true;
        }
        public BaseResponse(bool succes, ICollection erros) 
        {
            Success = succes;
            Erros = erros;
        }
    }
}
