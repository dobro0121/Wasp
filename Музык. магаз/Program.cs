using System;
using System.Collections.Generic;

namespace WASP
{
    internal class Program
    {
        public static void Main()
        {
            Store store = new Store("Disk shop", "ul. Pobedy, 27");
            List <Audio> audios = new List<Audio>();
            List <DVD> dvds = new List<DVD>();
            audios = store + new Audio("Lil Peep", "NY Studio", 10, "Moving On", "Rap");
            audios = store + new Audio("Billie Eilish", "LA Studio", 5, "Bury A Friend", "Rap");
            dvds = store + new DVD("Mikhalkov Nikita", "Mosfilm", 96, "His own among strangers, a stranger among his own", "istern");
            dvds = store + new DVD("Lourenz Bender", "A Band Apart", 154, "Pulp Fiction", "Black comedy, Foul play");
            Console.WriteLine(store.ToString());
            store.Dvds[0].Burn("Vladimir Menshov", "Mosfilm", "148", "Moscow doesn't believe in tears", "Melodrama");
            Console.WriteLine(store.Dvds[0].ToString());
            foreach(Audio audio in store.Audios)
            {
                Console.WriteLine($"{audio.Name} -> {audio.DiskSize}");
            }
            foreach(DVD dvd in store.Dvds)
            {
                Console.WriteLine($"{dvd.Name} -> {dvd.DiskSize}");
            }
            Console.ReadKey();
        }
    }
}
