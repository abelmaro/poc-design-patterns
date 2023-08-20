namespace PoC_Adapter.Libraries
{
    public class LibraryAudioPlayerLegacy
    {
        public void PlayFile(string archivo)
        {
            Console.WriteLine($"Playing: {archivo}");
        }

        public void StopFile()
        {
            Console.WriteLine("Stopping player");
        }
    }
}
