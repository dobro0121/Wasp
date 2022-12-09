using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    internal class Store
    {
        string storeName, address;
        List<Audio> audios;
        List<DVD> dvds;
        public Store(string storeName, string address)
        {
            this.storeName = storeName;
            this.address = address;
            audios = new List<Audio>();
            dvds = new List<DVD>();
        }
        public List<Audio> Audios
        {
            get { return audios; }
        }
        public List <DVD> Dvds
        {
            get { return dvds; }
        }
        public static List <Audio> operator+(Store store, Audio audio)
        {
            store.audios.Add(audio);
            return store.audios;
        }
        public static List<Audio> operator -(Store store, Audio audio)
        {
            store.audios.Remove(audio);
            return store.audios;
        }
        public static List<DVD> operator +(Store store, DVD dvd)
        {
            store.dvds.Add(dvd);
            return store.dvds;
        }
        public static List<DVD> operator -(Store store, DVD dvd)
        {
            store.dvds.Remove(dvd);
            return store.dvds;
        }
        public override string ToString()
        {
            string result = "Audio disks:\n";
            foreach(Audio audio in audios)
            {
                result +=audio.ToString() + "\n";
            }
            result += "DVD's:\n";
            foreach (DVD dvd in dvds)
            {
                result += dvd.ToString() + "\n";
            }
            return result;
        }
    }
}
