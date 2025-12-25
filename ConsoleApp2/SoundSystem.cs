public class SoundSystem
{
    public void On() => Console.WriteLine("Звуковая система включена");
    public void Off() => Console.WriteLine("Звуковая система выключена");
    public void SetMode(string mode) => Console.WriteLine($"Режим звука: {mode}");
}