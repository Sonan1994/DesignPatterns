namespace DesignPatterns.src.Creational.Factory_Method
{
    public class CellPhone
    {
        private readonly string name;
        private readonly float screenSize;

        public CellPhone(string name, float screenSize)
        {
            this.name = name;
            this.screenSize = screenSize;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
