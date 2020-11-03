using System;

using UIKit;

namespace DeliveryApp.iOS
{
    public partial class ViewController : UIViewController
    {

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            helloButtons.TouchUpInside += HelloButtons_TouchUpInside;


        }

        private void HelloButtons_TouchUpInside(object sender, EventArgs e)
        {
            var alert = UIAlertController.Create("Hello", $"Hello {nameTextField.Text}", UIAlertControllerStyle.Alert);

            var cancelAction = UIAlertAction.Create("Hello", UIAlertActionStyle.Cancel, null);

            alert.AddAction(cancelAction);

            PresentViewController(alert, true, null);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

     
    }
}
