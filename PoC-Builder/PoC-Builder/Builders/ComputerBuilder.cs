namespace PoC_Builder.Builders
{
    public class ComputerBuilder
    {
        private readonly Computer computer = new Computer();

        public ComputerBuilder BuildCPU(string cpu)
        {
            computer.CPU = cpu;
            return this;
        }

        public ComputerBuilder BuildGPU(string gpu)
        {
            computer.GPU = gpu;
            return this;
        }

        public ComputerBuilder BuildRAM(string ram)
        {
            computer.RAM = ram;
            return this;
        }

        public Computer Build()
        {
            return computer;
        }
    }
}