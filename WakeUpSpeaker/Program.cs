using System.Diagnostics;
using AudioSwitcher.AudioApi.CoreAudio;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            // Parse command line arguments
            var parameters = args.Select(arg => arg.Split('='))
                                 .ToDictionary(parts => parts[0], parts => parts[1]);

            // Get the volume and duration from the parameters
            double volume = double.Parse(parameters["volume"]);
            int duration = int.Parse(parameters["duration"]);

            // Get the name of the executable file
            string exeName = Process.GetCurrentProcess().MainModule.FileName;
            Console.WriteLine($"{exeName}: Setting volume to {volume} for {duration} ms");

            // Get the default playback device
            var controller = new CoreAudioController();
            var device = controller.DefaultPlaybackDevice;

            // Store the original volume level
            double originalVolume = device.Volume;

            // Set the volume to the specified level
            device.Volume = volume;

            // Wait for the specified duration
            await Task.Delay(duration);

            // Restore the original volume
            device.Volume = originalVolume;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
