namespace CountryLibrary.Services.Interfaces
{
    //violate Interfcae Segregation Principle
    public interface IGeneralPrinter
    {
        void PrintColor();
        void PrintBlack();
        void Scan();
    }

    class EpsonModel1 : IGeneralPrinter
    {
        public void PrintColor()
        {
            Console.WriteLine("I can print color document.");
        }

        public void PrintBlack()
        {
            Console.WriteLine("I can print only black document");
        }

        public void Scan()
        {
            Console.WriteLine("I can scan");
        }
    }

    class CanonModel1 : IGeneralPrinter
    {
        public void PrintColor()
        {
            //I can't print color. I use toner. Only black is available.
            throw new NotImplementedException();
        }

        public void PrintBlack()
        {
            Console.WriteLine("I can print black document.");
        }

        public void Scan()
        {
            Console.WriteLine("I can scan the document");
        }
    }

    public interface IColorPrintable
    {
        void PrintColor();
    }

    public interface IBlackPintable
    {
        void PrintBlack();
    }

    public interface IScannable
    {
        void Scan();
    }

    public interface IBlackPrinter : IBlackPintable, IScannable { }
    public interface IColorPrinter : IBlackPrinter, IColorPrintable { }

    public class EpsonModel2 : IBlackPrinter
    {
        public void PrintBlack()
        {
            Console.WriteLine("I can print black");
        }

        public void Scan()
        {
            Console.WriteLine("I can scan");
        }
    }

    public class CannonModel2 : IColorPrinter
    {
        public void PrintColor()
        {
            Console.WriteLine("I can print color.");
        }
        public void PrintBlack()
        {
            Console.WriteLine("I can print black");
        }

        public void Scan()
        {
            Console.WriteLine("I can scan");
        }
    }
}
