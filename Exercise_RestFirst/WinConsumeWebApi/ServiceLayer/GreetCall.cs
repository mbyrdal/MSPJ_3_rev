namespace WinConsumeWebApi.ServiceLayer;
public class GreetCall {

    readonly GreetConnection _greetService;

    public GreetCall() {
        _greetService = new GreetConnection();
    }

    public async Task<string?> GetGreeting(string? name = null, int times = int.MinValue) {
        string? strFoundGreeting = null;

        // Build URL to Web API endpoint
        if (!string.IsNullOrEmpty(name)) {
            _greetService.UseUrl += "/" + name;
            if (times > 0) {
                _greetService.UseUrl += "/" + times;
            }
        }
        // Call Web API service and handle response incl. get content
        if (_greetService != null) {
            try {
                var apiResponse = await _greetService.CallServiceAsync();
                if (apiResponse.IsSuccessStatusCode) {
                    strFoundGreeting = await apiResponse.Content.ReadAsStringAsync();
                } else {
                    strFoundGreeting = "Service response failure";
                }
            }
            catch {
                strFoundGreeting = "Service call error";
            }
        }

        return strFoundGreeting;
    }

}
