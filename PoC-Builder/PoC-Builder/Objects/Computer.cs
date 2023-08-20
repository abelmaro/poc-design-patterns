public class Computer
{
    public string? CPU { get; set; }
    public string? GPU { get; set; }
    public string? RAM { get; set; }

    public override string ToString()
    {
        return $"CPU: {CPU}\nGPU: {GPU}\nRAM: {RAM}\n";
    }
}