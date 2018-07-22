using Android.App;
using Android.Widget;
using Android.OS;

namespace TesteMeusPedidosLuizCarlos
{
    [Activity(Label = "TesteMeusPedidosLuizCarlos", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
                        SetContentView(Resource.Layout.Main);

            //Button button = FindViewById<Button>(Resource.Id.myButton);
            //button.Click += delegate { button.Text = $"{count++} clicks!"; };

        }
    }
}

