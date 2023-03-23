namespace RCIS_EP_2_3
{
    public class Calculation
    {
        private string? calculationLine;

        public string CalculationLine
        {
            get { return calculationLine; }
        }

        public Calculation(string? calculationLine)
        {
            this.calculationLine = calculationLine;
        }

        public void SetCalculationLine(string line)
        {
            calculationLine = line;
        }

        public string GetCalculationLine(string line)
        {
            return line;
        }

        public void SetLastSymbolCalculationLine ( char symbol)
        {
            calculationLine += Convert.ToString(symbol);
        }

        public char GetLastSymbol(string line)
        {
            char lastSymbol = Convert.ToChar(line.Substring(line.Length - 1));
            return lastSymbol;
        }
        
        public string DeleteLastSymbol(string line)
        {
            line = line.Substring(0, line.Length - 1);
            return line;
        }

    }
}
