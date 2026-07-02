namespace APA202Api.Services;

public interface IOtpService
{
    Task SendOtp(string code);
}

public class EmailOtpService : IOtpService
{
    public Task SendOtp(string code)
    {
        //
        //
        return Task.CompletedTask;
    }
}

public class SmsOtpService : IOtpService
{
    public Task SendOtp(string code)
    {
        //
        //
        return Task.CompletedTask;
    }
}
