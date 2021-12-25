using System.Linq;

namespace Task_5
{
    public class Neurosurgeon : Surgeon
    {
        public override string Type => "Нейро";

        public int TrepanationSkullCount { get; private set; }

        public int LobotomyCount { get; private set; }

        public Neurosurgeon(string fullName) : base(fullName)
        {
            TrepanationSkullCount = 0;
            LobotomyCount = 0;
        }

        public override string Diagnose(string[] symptoms)
        {
            if (symptoms.Contains("Опухоль на МРТ"))
                return "Опухоль";
            if (symptoms.Contains("Эпилептический припадок"))
                return "Эпилепсия";

            return null;
        }

        public override void Cure(string diagnose) {}

        public override void Operation(string diagnose)
        {
            switch (diagnose)
            {
                case "Опухоль":
                    TrepanationSkull();
                    break;
                case "Эпилепсия":
                    Lobotomy();
                    break;
            }
        }

        private void TrepanationSkull()
        {
            OperationsCount++;
            TrepanationSkullCount++;
        }

        private void Lobotomy()
        {
            OperationsCount++;
            LobotomyCount++;
        }
    }
}
