namespace CompositePattern;

public class File : FileSystemItem
{
    private readonly long _size;

    public File(string name, long size) : base(name)
    {
        _size = size;
    }

    public override void Display(int depth = 0)
    {
        Console.WriteLine($"{new string(' ', depth * 2)} {Name} ({_size} KB)");
    }

    public override long GetSize()
    {
        return _size;
    }
}