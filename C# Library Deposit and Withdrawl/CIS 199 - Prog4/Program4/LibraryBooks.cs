using System;


//LibraryBooks base class
public class LibraryBooks
{
    private string _title;
    private string _author;
    private string _publisher;
    private int _year;
    private string _callNumber;
    private bool _checkedOut;

    //title property
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }//end title property


    //author property
    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }//end author property

    //publisher property
    public string Publisher
    {
        get { return _publisher; }
        set { _publisher = value; }
    }//end publisher property


    //year property
    public int Year
    {
        get { return _year; }
        set
        {
            if (value > 0)
                _year = value;//validation
            else
                _year = 2018;//default
        }
    }//end year property


    //callnumber property
    public string CallNumber
    {
        get { return _callNumber; }
        set { _callNumber = value; }
    }//end callnumber property


    //checked out property
    public bool CheckedOut
    {
        get { return _checkedOut; }
        set { _checkedOut = value; }
    }//end checked out property

    //six-parameter constructor
    public LibraryBooks(string title, string author, string publisher, int year,
        string callNumber, bool checkedOut)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        Year = year;
        CallNumber = callNumber;
        CheckedOut = checkedOut;
    }//end six-parameter LibraryBooks constructor


    //return string representation of LibraryBooks object
    public override string ToString()
    {
        return $"Title: {Title}{Environment.NewLine}" +
            $"Author: {Author}{Environment.NewLine}" +
            $"Publisher: {Publisher}{Environment.NewLine}" +
            $"Year: {Year}{Environment.NewLine}" +
            $"Call Number: {CallNumber}{Environment.NewLine}" +
            $"Checked Out Status: {CheckedOut}{Environment.NewLine}";
    }//end method ToString


    //Checks out a book when called
    public void CheckOut()
    {
        this.CheckedOut = true;
    }

    //Returns a book to shelf when called
    public void ReturnToShelf()
    {
        this.CheckedOut = false;
    }

    //Returns a boolean determined on the availablitity of the book
    public bool IsCheckedOut()
    {
        if (this.CheckedOut == true)
        {
            return true;
        }
        else
            return false;
    }

}