namespace Task_5
{
    public interface IDoctor
    {
        string FullName { get; }

        string Diagnose(string[] symptoms);

        void Cure(string diagnose);
    }
}
