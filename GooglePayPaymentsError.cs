using System.Text.Json.Serialization;

namespace BlazorGooglePay
{
    public class GooglePayPaymentsError
    {
        private GooglePayStatusCode StatusCode { get; set; }
        private string StatusMessage { get; set; } = null!;
    }
}