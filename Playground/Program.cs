using System;
using System.Linq;
using System.Threading.Tasks;
using Nito.AsyncEx;
using Realms;

namespace SimpleRealmWriter
{
    internal class Program
    {
        private const string RealmLocation = "C:\\Work\\example.realm";

        private static void Main(string[] args)
        {
            AsyncContext.Run(async () =>
            {
                var realm = Realm.GetInstance(RealmLocation);
                var counter = realm.All<MyCounter>().FirstOrDefault();
                if (counter == null)
                {
                    counter = new MyCounter();
                    realm.Write(() => realm.Add(counter));
                }
                counter.PropertyChanged += (s, e) =>
                {
                    Console.WriteLine($"Counter's {e.PropertyName} changed: {counter.Value}");
                };

                while (true)
                {
                    await Task.Delay(1000);
                    var tsr = ThreadSafeReference.Create(counter);
                    await Task.Run(() =>
                    {
                        using var bgRealm = Realm.GetInstance(RealmLocation);
                        var bgCounter = bgRealm.ResolveReference(tsr);
                        bgRealm.Write(() =>
                        {
                            bgCounter.Value++;
                        });
                    });

                    realm.Refresh(); // Locks up here

                    Console.WriteLine($"Counter: {counter.Value}");
                }
            });
        }
    }

    internal class MyCounter : RealmObject
    {
        public int Value { get; set; }
    }
}