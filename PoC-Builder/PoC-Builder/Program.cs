using PoC_Builder.Builders;

namespace PoC_Builder
{
    public class Program
    {
        protected Program() { }
        static void Main()
        {
            ComputerBuilder builder = new ComputerBuilder();

            Computer gamingComputer = builder.BuildCPU("High-performance CPU")
                                                   .BuildGPU("Dedicated gaming GPU")
                                                   .BuildRAM("32GB DDR5 RAM")
                                                   .Build();

            Computer officeComputer = builder.BuildCPU("Basic CPU")
                                            .BuildGPU("Integrated GPU")
                                            .BuildRAM("8GB DDR4 RAM")
                                            .Build();

            Console.WriteLine("Gaming Computer:");
            Console.WriteLine(gamingComputer);

            Console.WriteLine("Office Computer:");
            Console.WriteLine(officeComputer);
        }
    }
}