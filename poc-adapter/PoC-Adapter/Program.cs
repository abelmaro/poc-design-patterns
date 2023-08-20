using PoC_Adapter.Adapters;
using PoC_Adapter.Libraries;

namespace PoC_Adapter
{ 
    public class Program
    {
        protected Program() { }
        static void Main(string[] args)
        {
            var oldLibrary = new LibraryAudioPlayerLegacy();
            var adapter = new AudioPlayerAdapter(oldLibrary);

            oldLibrary.PlayFile("12_05_2010_song_1.mp3");
            oldLibrary.StopFile();

            adapter.Play("song_2.mp3", "12_05_2009");
            adapter.Stop();

        }
    }
}