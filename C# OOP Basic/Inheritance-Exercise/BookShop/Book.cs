using System;
using System.Linq;
using System.Text;

namespace BookShop
{
   public class Book
   {
        private string title;
        private string author;
        private decimal price;

       public Book(string author,string title,decimal price)
       {
           this.Author = author;
           this.Title = title;
           this.Price = price;
       }
        public virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0.0m)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }


        public string Author
        {
            get { return this.author; }
            set
            {
                //string pattern = @"^[A-Za-z]+\s[A-Za-z]+";
                //var regex = new Regex(pattern);
                //var match = regex.Match(value);
                var tokens = value.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Length == 2 )
                {
                    var arr = tokens[1].ToCharArray();
                    if (arr[0] >= 48 && 58 > arr[0])
                    {
                      throw new ArgumentException("Author not valid!");

                    }
                }
                this.author = value;
            }
        }


        public string Title
        {
            get { return this.title; }
            set
            {
                if (value.Length < 3 )
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }
       public override string ToString()
       {
           var sb = new StringBuilder();
           sb.Append("Type: ").AppendLine(this.GetType().Name)
               .Append("Title: ").AppendLine(this.Title)
               .Append("Author: ").AppendLine(this.Author)
               .Append("Price: ").Append($"{this.Price:f1}")
               .AppendLine();

           return sb.ToString();
       }


    }
}
