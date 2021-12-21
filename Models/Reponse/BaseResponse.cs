namespace harvest_api.Models.Response
{
    public class Response<T>
    {
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public T Resource { get; private set; }

        public Response(T resource)
        {
            Success = true;
            Message = string.Empty;
            Resource = resource;
        }

        public Response(string message)
        {
            Success = false;
            Message = message;
            Resource = default;
        }
    }
}