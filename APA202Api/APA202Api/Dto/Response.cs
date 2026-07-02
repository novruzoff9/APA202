using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APA202Api.Dto;

public class ResponseModel<T>
{
    public T Data { get; set; }
    public int StatusCode { get; set; }
    public bool IsSuccess { get; set; }
    public List<string> Errors { get; set; }

    public static ResponseModel<T> Success(T? data = default)
    {
        return new ResponseModel<T>()
        {
            Data = data,
            StatusCode = 200,
            IsSuccess = true,
            Errors = null
        };
    }

    public static ResponseModel<T> Error(string errorMesage)
    {
        return new ResponseModel<T>()
        {
            Data = default,
            StatusCode = 400,
            IsSuccess = false,
            Errors = [errorMesage]
        };
    }

    public static ResponseModel<T> Error(List<string> errorMesage)
    {
        return new ResponseModel<T>()
        {
            Data = default,
            StatusCode = 400,
            IsSuccess = false,
            Errors = errorMesage
        };
    }
}
