namespace Register.Manegement.Application.Responses.UserRegister
{
    public class UserRegisterPostResponse : BaseResponse
    {
        public Guid AuthenticationLogin { get; set; }
        public Guid AuthenticationPassWord { get; set; }
    }
}
