using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloWorld
{
    [Activity(Label = "HelloWorld", MainLauncher = true)]
    public class MainActivity : Activity
        {
            protected override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);

                // Set our view from the "main" layout resource
                SetContentView(Resource.Layout.Main);

                var button = FindViewById<Button>(Resource.Id.btn);
                var text = FindViewById<TextView>(Resource.Id.txt);
            
                button.Click += (s, o) => { text.Text = "Hello world"; };

            }
    }
}

