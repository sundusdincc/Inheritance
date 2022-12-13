namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlilar beslenir.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlilar solunum yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlilar boşaltım yapar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlilar uyaranlara tepki verir.");
        }

        
    }
}