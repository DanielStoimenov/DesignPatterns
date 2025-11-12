namespace DelegationPattern;

public class PrinterController
{
    private IPrinter _printer;

    public PrinterController(IPrinter printer)
    {
        _printer = printer;
    }

    // Можем да сменим принтера динамично
    public void SetPrinter(IPrinter printer)
    {
        _printer = printer;
        Console.WriteLine("Printer changed");
    }

    // Делегираме работата на принтера
    public void PrintDocument(string content)
    {
        Console.WriteLine("Preparing document...");
        _printer.Print(content);
        Console.WriteLine("Document printed successfully\n");
    }
}