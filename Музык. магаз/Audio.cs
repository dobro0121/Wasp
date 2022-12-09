using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    public class Audio : Disk
    {
        string artist, recordingStudio;
        int songsNumber;
        public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre) : base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
        }
        public override int DiskSize { get => songsNumber * 8; }
        public override void Burn(params string[] values)
        {
            try
            {
                artist = values[0];
                recordingStudio = values[1];
                songsNumber = Convert.ToInt32(values[2]);
                name = values[3];
                genre = values[4];
                burnCount++;
            }catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Недостаточно параметров");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены некорректные параметры");
            }
        }
        public override string ToString()
        {
            return $"Name - {name}, genre - {genre}, artist - {artist}, recording studio - {recordingStudio}, count of songs - {songsNumber}, count of burns - {burnCount}";
        }
    }
}
