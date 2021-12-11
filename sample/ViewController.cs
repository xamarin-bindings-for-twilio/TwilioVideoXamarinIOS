using Foundation;
using System;
using UIKit;
using Twilio.Video.iOS;

namespace Sample
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            TwilioVideoSDK.LogLevel = TVILogLevel.All;

            var connectOptions = TVIConnectOptions.OptionsWithToken("token", builder =>
            {
                builder.RoomName = "roomName";
            });

            TwilioVideoSDK.ConnectWithOptions(connectOptions, RoomDelegate.Instance);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
