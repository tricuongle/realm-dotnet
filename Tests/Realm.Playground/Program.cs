using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Realms.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "playground.realm");
            var config = new RealmConfiguration(path);

            Realm.DeleteRealm(config);
            Realm instanceFactory() => Realm.GetInstance(config);

            new WriterThread(instanceFactory);

            using (var localRealm = instanceFactory())
            {
                var subscription = localRealm.All<TestObject>().SubscribeForNotifications((sender, changes, error) => { Console.WriteLine("got notification"); });
                // ^ removing this line will stop all deadlocks.

                while (true)
                {
                    localRealm.Refresh();
                    Console.Write(".");
                    Thread.Sleep(10);
                }
            }
        }

        private class TestObject : RealmObject
        {
            [PrimaryKey] public string ID { get; set; }

            public TestObject()
            {
                ID = Guid.NewGuid().ToString();
            }
        }

        private class WriterThread
        {
            public WriterThread(Func<Realm> instanceFactory)
            {
                Task.Factory.StartNew(() =>
                {
                    using (var localRealm = instanceFactory())
                    {
                        while (true)
                        {
                            var obj = new TestObject();

                            using (var transaction = localRealm.BeginWrite())
                            {
                                localRealm.Add(obj);
                                Console.WriteLine("Storing item from other thread");
                                transaction.Commit();
                            }

                            Thread.Sleep(50);
                        }
                    }
                }, TaskCreationOptions.LongRunning);
            }
        }
    }
}
