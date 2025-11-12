namespace CompositePattern;

public class Program
{
    //Какво е Composite Pattern?
    //    Composite е structural design pattern, който позволява да композирате обекти в дървовидни структури
    //    и да работите с тях като с индивидуални обекти.Клиентът третира еднакво единични обекти и композиции от обекти.
    //Основна идея
    //    Composite патърнът ви позволява да третирате един обект и група обекти по един и същи начин.
    static void Main(string[] args)
    {
        // Създаваме файлова структура
        var root = new Directory("root");

        var documents = new Directory("Documents");
        documents.Add(new File("resume.pdf", 250));
        documents.Add(new File("cover-letter.docx", 100));

        var photos = new Directory("Photos");
        photos.Add(new File("vacation.jpg", 2500));
        photos.Add(new File("family.jpg", 1800));

        var work = new Directory("Work");
        work.Add(new File("project.docx", 500));
        work.Add(new File("budget.xlsx", 300));

        var vacation = new Directory("Vacation2023");
        vacation.Add(new File("beach.jpg", 3000));
        vacation.Add(new File("mountains.jpg", 2800));
        photos.Add(vacation);

        root.Add(documents);
        root.Add(photos);
        root.Add(work);
        root.Add(new File("readme.txt", 10));

        // Показваме структурата
        root.Display();

        // Изчисляваме общия размер
        Console.WriteLine($"\nTotal size: {root.GetSize()} KB");
        Console.WriteLine($"Documents size: {documents.GetSize()} KB");
        Console.WriteLine($"Photos size: {photos.GetSize()} KB");
    }
}