using WinConsumeWebApi.ServiceLayer;

namespace WinConsumeWebApi.ControlLayer {
    public class GreetCtrl {

        public async Task<string?> GetGreeting(GreetSituation inSit, string? inName, string? inNickName, int inTimes) {

            string? fetchedText = null;

            GreetCall hiService = new();

            switch (inSit) {
                case GreetSituation.NoInput:
                    fetchedText = await hiService.GetGreeting();
                    break;
                case GreetSituation.NameOnly:
                    if (inName != null) {
                        fetchedText = await hiService.GetGreeting(inName);
                    }
                    break;
                case GreetSituation.NameAndTimes:
                    if (inName != null) {
                        fetchedText = await hiService.GetGreeting(inName, null, inTimes);
                    }
                    break;
                case GreetSituation.NameAndNickName:
                    if (inName != null || inNickName != null)
                    {
                        fetchedText = await hiService.GetGreeting(inName, inNickName);
                    }
                    break;
                case GreetSituation.NameAndNickNameAndTimes:
                    if (inName != null || inNickName != null || inTimes > 0)
                    {
                        fetchedText = await hiService.GetGreeting(inName, inNickName, inTimes);
                    }
                    break;
            }

            return fetchedText;
        }

    }
}
