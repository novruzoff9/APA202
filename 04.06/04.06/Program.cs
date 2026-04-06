// DirectoryInfo, FileInfo, Directory, File

//string path = "C:\\Users\\User\\Desktop\\APA202\\04.06\\04.06\\NewFolder\\";
//DirectoryInfo directoryInfo = new DirectoryInfo(path);
//Console.WriteLine(directoryInfo.Name);
//Console.WriteLine(directoryInfo.FullName);
//Console.WriteLine(directoryInfo.Parent);
//Console.WriteLine(directoryInfo.Root);

//foreach (var directory in directoryInfo.GetDirectories())
//{
//    Console.WriteLine(directory.Name);
//    Console.WriteLine(directory.FullName);
//    Console.WriteLine(directory.Parent);
//    Console.WriteLine("----------------------");
//}

//string path = "C:\\Users\\User\\Desktop\\APA202\\04.06\\04.06\\NewFolder\\TestFolder\\";
//Directory.Delete(path, true);


//string path = "C:\\Users\\User\\Desktop\\APA202\\04.06\\04.06\\NewFolder\\Test2";
//DirectoryInfo directoryInfo = new DirectoryInfo(path);
//directoryInfo.Create();

//string path = "C:\\Users\\User\\Desktop\\APA202\\04.06\\04.06\\NewFolder\\test.txt";
//FileInfo fileInfo = new FileInfo(path);

//Console.WriteLine(fileInfo.Name);
//Console.WriteLine(fileInfo.Extension);
//Console.WriteLine(fileInfo.CreationTime);
//Console.WriteLine(fileInfo.LastWriteTime);
//Console.WriteLine(fileInfo.Length);

//string path = "C:\\Users\\User\\Desktop\\APA202\\04.06\\04.06\\NewFolder\\test2.txt";
//FileInfo fileInfo = new FileInfo(path);
//fileInfo.Create();

//string path = "C:\\Users\\User\\Desktop\\APA202\\04.06\\04.06\\NewFolder\\test.txt";
// FileStream, StreamReader, StreamWriter

//FileStream fileStream = new FileStream(path, FileMode.Open);
//StreamReader streamReader = new StreamReader(fileStream);
//string content = streamReader.ReadToEnd();
//Console.WriteLine(content);
//streamReader.Close();
//fileStream.Close();

//FileStream fileStream = new FileStream(path, FileMode.Append);
//StreamWriter writer = new StreamWriter(fileStream);
//writer.WriteLine("Hello world");
//writer.Close();
//fileStream.Close();



// Json, XML, Binary
// Serialization, Deserialization
using _04._06.Models;
using System.Text.Json;

//Book book1 = new Book()
//{
//    Id = 1,
//    Name = "Book 1"
//};
//string path = "C:\\Users\\User\\Desktop\\APA202\\04.06\\04.06\\NewFolder\\data.json";
//string json = JsonSerializer.Serialize(book1);
//FileStream fileStream = new FileStream(path, FileMode.Create);
//StreamWriter writer = new StreamWriter(fileStream);
//writer.WriteLine(json);
//writer.Close();
//fileStream.Close();

//FileStream fileStream = new FileStream(path, FileMode.Open);
//StreamReader reader = new StreamReader(fileStream);
//string content = reader.ReadToEnd();
//Book exsistBook = JsonSerializer.Deserialize<Book>(content);
//Console.WriteLine(exsistBook.Name);


//Book book1 = new Book()
//{
//    Id = 1,
//    Name = "Book 1"
//};
//Book book2 = new Book()
//{
//    Id = 2,
//    Name = "Book 2"
//};
//List<Book> books = new List<Book>() { book1, book2 };
//string json = JsonSerializer.Serialize(books);
//FileStream fileStream = new FileStream(path, FileMode.Create);
//StreamWriter writer = new StreamWriter(fileStream);
//writer.Write(json);
//writer.Close();
//fileStream.Close();

Book book5 = new Book()
{
    Id = 5,
    Name = "Book 5"
};

string path = "C:\\Users\\User\\Desktop\\APA202\\04.06\\04.06\\NewFolder\\data.json";
FileStream fileStream = new FileStream(path, FileMode.Open);
StreamReader reader = new StreamReader(fileStream);
string content = reader.ReadToEnd();
reader.Close();
List<Book> exsistBooks = JsonSerializer.Deserialize<List<Book>>(content);
exsistBooks.Add(book5);



using FileStream fileStream2 = new FileStream(path, FileMode.Create);
using StreamWriter writer = new StreamWriter(fileStream2);
string json = JsonSerializer.Serialize(exsistBooks);
writer.Write(json);

// IDisposable
// Json, Xml