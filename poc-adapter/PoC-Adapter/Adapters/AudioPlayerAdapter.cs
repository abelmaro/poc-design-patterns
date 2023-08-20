using PoC_Adapter.Interfaces;
using PoC_Adapter.Libraries;

namespace PoC_Adapter.Adapters
{
    public class AudioPlayerAdapter : IAudioPlayer
    {
        private LibraryAudioPlayerLegacy _player;

        public AudioPlayerAdapter(LibraryAudioPlayerLegacy player) { 
            _player = player;
        }

        public void Play(string file, string date)
        {
            string filename = $"{date}_{file}";
            _player.PlayFile(filename);
        }

        public void Stop()
        {
            _player.StopFile();
        }
    }
}
