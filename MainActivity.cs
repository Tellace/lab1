using Android.App;
using Android.OS;
using Android.Widget;
using System.Collections.Generic;
using static App3.Droid.Resource;
using App3;
using App3.Droid; // ("App3" - пространство імен проекту)



namespace AnimalApp
{
    [Activity(Label = "MainActivity", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            List<Animal> animals = new List<Animal>
            {
                new Animal { ImageResourceId = Resource.Drawable.animal1, Name = "Cat", Description = "A fluffy domestic animal." },
                new Animal { ImageResourceId = Resource.Drawable.animal2, Name = "Dog", Description = "A loyal companion." },
                new Animal { ImageResourceId = Resource.Drawable.animal3, Name = "Bird", Description = "A chirpy feathered friend." }
            };

            ListView listView = FindViewById<ListView>(Resource.Id.listView);
            AnimalAdapter adapter = new AnimalAdapter(this, animals);
            listView.Adapter = (IListAdapter)adapter;

            listView.ItemClick += (sender, e) =>
            {
                Animal selectedAnimal = animals[e.Position];
                var intent = new Android.Content.Intent(this, typeof(AnimalDetailActivity));
                intent.PutExtra("AnimalName", selectedAnimal.Name);
                intent.PutExtra("AnimalDescription", selectedAnimal.Description);
                StartActivity(intent);
            };
        }
    }
}
