using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace DeliveryApp.Droid
{
    [Activity(Label = "DeliveryApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        EditText emailEditText, passwordEditText;
        Button signInButton, registerButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            emailEditText = FindViewById<EditText>(Resource.Id.emailEdittext);
            passwordEditText = FindViewById<EditText>(Resource.Id.passwordEdittext);

            signInButton = FindViewById<Button>(Resource.Id.signInButton);
            registerButton = FindViewById<Button>(Resource.Id.registerButton);


            signInButton.Click += SignInButton_Click;
            registerButton.Click += RegisterButton_Click;
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(RegisterActivity));
            intent.PutExtra("email", emailEditText.Text);
            StartActivity(intent);
        }

        private void SignInButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        
    }
}

