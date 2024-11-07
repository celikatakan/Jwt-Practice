namespace Jwt_Practice.Types
{
    public class ServiceMessage
    {
        public string Message { get; set; }
        public bool IsSucceed { get; set; }
    }
    public class ServiceMessage<T>
    {
        public bool IsSucceed { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }
    }
}
