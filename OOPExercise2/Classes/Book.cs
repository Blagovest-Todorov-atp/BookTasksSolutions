using System.Text;

namespace OOPExercise2.Classes
{
    public class Book
    {
        private string _title;
        private string _authorFirstName;
        private string _authorSecName;
        private decimal _price;

        public Book(string title, string firstName, string secName, decimal price)
        {
            this.Title = title;
            this.AuthorFirstName = firstName;
            this.AuthorSecName = secName;
            this.Price = price;
        }

        public string Title 
        { 
            get => this._title;

            protected set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title is not valid!");
                }

                this._title = value;
            }
        }

        public string AuthorFirstName 
        {  
            get => this._authorFirstName;

            protected set 
            {
                this._authorFirstName = value;
            }
        }

        public string AuthorSecName 
        {
            get => this._authorSecName;

            protected set 
            {
                var firstLetter = value[0];

                if (Char.IsDigit(firstLetter))
                {
                    throw new ArgumentException("Autor not valid!");
                }

                this._authorSecName = value;

            } 
        }

        public virtual decimal Price 
        {
            get => this._price;

            protected set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this._price = value;
            } 
        }

       

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append($"FirstName : {this.AuthorFirstName}, SecName {this.AuthorSecName}");

        //    return sb.ToString();
        //}

        public override string ToString()       
            
        {           
            return $"{Environment.NewLine} Book Title : {this.Title}, " +
                $"{Environment.NewLine} Author -> FirstName: {this.AuthorFirstName}, SecName: {this.AuthorSecName} " +
                $"{Environment.NewLine} Price : {this.Price:F1}";
            
        }
    }
}
