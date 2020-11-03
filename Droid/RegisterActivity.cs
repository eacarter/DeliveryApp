
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DeliveryApp.Droid
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {

        EditText registerEmailEditText, registerPasswordEditText, confirmPasswordEditText;
        Button submitButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register);

            registerEmailEditText = FindViewById<EditText>(Resource.Id.registerEmailEditText);
            registerPasswordEditText = FindViewById<EditText>(Resource.Id.registerPasswordEditText);
            confirmPasswordEditText = FindViewById<EditText>(Resource.Id.confirmEditText);
            submitButton = FindViewById<Button>(Resource.Id.submitButton);

            string email = Intent.GetStringExtra("email");
            registerEmailEditText.Text = email;

            submitButton.Click += SubmitButton_Click;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
