using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

namespace Numbers_In_English.Droid
{
    [Service(Exported = true)]
    public class ServiceTest : Service
    {
        public override void OnCreate()
        {
            base.OnCreate();
        }

        [return: GeneratedEnum]
        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            // Do the actual work here
            return StartCommandResult.NotSticky;
        }

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
        }

        [BroadcastReceiver(Exported = true)]
        [IntentFilter(new[] { Intent.ActionBootCompleted })]
        public class BootReceiver : BroadcastReceiver
        {
            public override void OnReceive(Context context, Intent intent)
            {

            }
        }
    }
}