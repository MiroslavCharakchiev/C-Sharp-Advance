using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Book //: IComparable<Book>
{
    public Book(string title, int age, params string[] authors)
    {
        this.Title = title;
        this.Year = age;
        this.Authors = new List<string>(authors);
    }

    public string Title { get; set; }
    public int Year { get; set; }
    public List<string> Authors { get; set; }

    //public int CompareTo(Book other)
    //{
    //    var result = Title.CompareTo(other.Title);
    //    if (result == 0)
    //    {
    //        result = other.Year.CompareTo(this.Year);
    //    }
    //    return result;
    //}

    public override string ToString()
    {
        return $"{this.Title} - {this.Year}";
    }
}
