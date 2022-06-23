namespace OOPExercise2.Classes
{
    
    public class GoldenEditionBook : Book
    {
        private const decimal BasePriceMultiplicator = 1.3M;
        public GoldenEditionBook(string title, string firstName, string secName, decimal price)
            : base(title, firstName, secName, price)
        {

        }

        public override decimal Price
        {
            get => base.Price * BasePriceMultiplicator;            
        }
    }
}
