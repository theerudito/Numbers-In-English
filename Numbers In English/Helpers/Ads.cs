using MarcTron.Plugin;

namespace NumbersInEnglish.Helpers
{
    public static class Ads
    {
        public static void ShowIntertiscal()
        {
            var idIntersticial = "ca-app-pub-7633493507240683/9106078997";

            CrossMTAdmob.Current.LoadInterstitial(idIntersticial);
        }

        public static bool IsIntertiscalLoaded()
        {
            return CrossMTAdmob.Current.IsInterstitialLoaded();
        }

        public static void ShowRewardedVideo()
        {
            var idVideo = "ca-app-pub-7633493507240683/4435650672";

            CrossMTAdmob.Current.LoadRewardedVideo(idVideo);
        }

        public static bool IsVideoLoaded()
        {
            return CrossMTAdmob.Current.IsRewardedVideoLoaded();
        }
    }
}
