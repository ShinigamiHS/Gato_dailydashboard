namespace dailydashboard_gateway.DTO
{
    public class BaseResponse<T> where T : class
    {
        public bool Success { get; set; }
        public IList<string>? Error { get; set; }

        public T Response { get; set; }

        public static BaseResponse<T> SuccessResponse(T Response)
        {
            return new BaseResponse<T>()
            {
                Success = true,
                Error = null,
                Response = Response
            };
        }

        public static BaseResponse<T> UnsuccessResponse(T Response, IList<string> Error)
        {
            return new BaseResponse<T>()
            {
                Success = false,
                Error = Error,
                Response = Response
            };
        }
    }
}
