namespace Task_5
{
    public abstract class Surgeon : IDoctor
    {
        public string FullName { get; }

        public int OperationsCount { get; protected set; }

        public abstract string Type { get; }

        public Surgeon(string fullName)
        {
            FullName = fullName;
            OperationsCount = 0;
        }

        public abstract string Diagnose(string[] symptoms);

        public abstract void Cure(string diagnose);

        public abstract void Operation(string diagnose);

        public override string ToString()
        {
            return FullName;
        }
    }
}
