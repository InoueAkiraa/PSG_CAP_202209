namespace ExameCap.Poco
{
    public class BilhetePoco
    {
        public int CodigoBilhete { get; set; }

        public int NumeroBilhete { get; set; }

        public string Assento { get; set; } = null!;

        public BilhetePoco() 
        { }
    }
}
