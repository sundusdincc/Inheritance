namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
    }

    public  class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }
        public void SurunerekHareket()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

     public  class Kuşlar:Hayvanlar
    {
        public Kuşlar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar.");
        }
    }
}