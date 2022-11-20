using System;

internal class Book
{
	private string bookName;
	private string bookAuthor;
	private string bookId;
	private string bookType;
	public string BookName
	{
		get
		{
			return bookName;
		}

		set
		{
			bookName = value;
		}
	}

	public string BookAuthor
	{
		get
		{
			return bookAuthor;
		}

		set
		{
			bookAuthor = value;
		}
	}

	public string BookId
	{
		get
		{
			return bookId;
		}

		set
		{
			bookId = value;
		}
	}

	public string BookType
	{
		get
		{
			return bookType;
		}

		set
		{
			bookType = value;
		}
	}

	public Book(string a, string b, string c, string d)
	{
		bookName = a;
		bookAuthor = b;
		bookId = c;
		bookType = d;
		Console.WriteLine("Par Book Created");
	}

	public void ShowBookInfo()
	{
		Console.WriteLine("Book Name: {0}", bookName);
		Console.WriteLine("Book Author: {0}", bookAuthor);
		Console.WriteLine("Book ID: {0}", bookId);
		Console.WriteLine("Book Type: {0}", bookType);
	}
}

internal class Library
{
	private string libName;
	private string libAddress;
	private Book[] listOfBook = new Book[1];
	public string LibName
	{
		get
		{
			return libName;
		}

		set
		{
			libName = value;
		}
	}

	public string LibAddress
	{
		get
		{
			return libAddress;
		}

		set
		{
			libAddress = value;
		}
	}

	public Book[] ListOfBook
	{
		get
		{
			return listOfBook;
		}

		set
		{
			listOfBook = value;
		}
	}

	public Library(string a, string b, int c)
	{
		libName = a;
		libAddress = b;
		listOfBook = new Book[c];
		Console.WriteLine("Par Library Created");
	}

	public void AddNewBook(Book book)
	{
		for (int i = 0; i < listOfBook.Length; i++)
		{
			if (listOfBook[i] == null)
			{
				listOfBook[i] = book;
				Console.WriteLine("Book Added to the Library");
				break;
			}
		}
	}

	public void ShowLibInfo()
	{
		Console.WriteLine("Library Name: {0}", libName);
		Console.WriteLine("Library Address: {0}", libAddress);
		for (int i = 0; i < listOfBook.Length; i++)
		{
			if (listOfBook[i] != null)
			{
				listOfBook[i].ShowBookInfo();
			}
		}
	}
}

internal class Contact
{
	private string personName;
	private int age;
	private string mobileNumber;
	private char gender;
	public string PersonName
	{
		get
		{
			return personName;
		}

		set
		{
			personName = value;
		}
	}

	public int Age
	{
		get
		{
			return age;
		}

		set
		{
			age = value;
		}
	}

	public string MobileNumber
	{
		get
		{
			return mobileNumber;
		}

		set
		{
			mobileNumber = value;
		}
	}

	public char Gender
	{
		get
		{
			return gender;
		}

		set
		{
			gender = value;
		}
	}

	public Contact(string a, int b, string c, char d)
	{
		personName = a;
		age = b;
		mobileNumber = c;
		gender = d;
		Console.WriteLine("Par Contact Created");
	}

	public void ShowContactInfo()
	{
		Console.WriteLine("Person Name: {0}", personName);
		Console.WriteLine("Age: {0}", age);
		Console.WriteLine("Mobile Number: {0}", mobileNumber);
		Console.WriteLine("Gender: {0}", gender);
	}
}

internal class ContactBook
{
	private string ownerName;
	private string ownerAddress;
	private Contact[] listOfContact = new Contact[1];
	public string OwnerName
	{
		get
		{
			return ownerName;
		}

		set
		{
			ownerName = value;
		}
	}

	public string OwnerAddress
	{
		get
		{
			return ownerAddress;
		}

		set
		{
			ownerAddress = value;
		}
	}

	public Contact[] ListOfContact
	{
		get
		{
			return listOfContact;
		}

		set
		{
			listOfContact = value;
		}
	}

	public ContactBook(string a, string b, int c)
	{
		ownerName = a;
		ownerAddress = b;
		listOfContact = new Contact[c];
		Console.WriteLine("Par Contact Book Created");
	}

	public void AddContact(Contact con)
	{
		for (int i = 0; i < listOfContact.Length; i++)
		{
			if (listOfContact[i] == null)
			{
				listOfContact[i] = con;
				Console.WriteLine("Contact Added to the Library");
				break;
			}
		}
	}

	public void ShowInfo()
	{
		Console.WriteLine("Owner Name: {0}", ownerName);
		Console.WriteLine("Owner Address: {0}", ownerAddress);
		for (int i = 0; i < listOfContact.Length; i++)
		{
			if (listOfContact[i] != null)
			{
				listOfContact[i].ShowContactInfo();
			}
		}
	}
}

internal class Program
{
	public static void Main()
	{
		Book b1 = new Book("Minecraft: The Island", "Max Brooks", "F-13-5-645", "HardCover");
		Book b2 = new Book("Minecraft: The Crash", "Tracey Baptiste", "F-13-6-784", "HardCover");
		
		Console.WriteLine();
		b2.ShowBookInfo();
		Console.WriteLine();
		
		Library l = new Library("Jarir BookStore", "Kilo=3, Nuzlah Al-Sharaqia, Jeddah", 20);
		l.AddNewBook(b1);
		l.AddNewBook(b2);
		l.AddNewBook(new Book("Minecraft: The Lost Journals", "Mur Lafferty", "F-14-9-777", "PaperBack"));
		
		Console.WriteLine();
		l.ShowLibInfo();
		
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine();
		
		Contact c1 = new Contact("Sakib", 23, "01698546515", 'M');
		Contact c2 = new Contact("Mridul", 21, "01853219111", 'M');
		
		Console.WriteLine();
		c2.ShowContactInfo();
		Console.WriteLine();
		
		ContactBook cb = new ContactBook("Tanbir", "23/5, East Rampura, Dhaka", 3);
		cb.AddContact(c1);
		cb.AddContact(c2);
		cb.AddContact(new Contact("Hojifa", 22, "01848215484", 'M'));
		
		Console.WriteLine();
		cb.ShowInfo();
	}
}
