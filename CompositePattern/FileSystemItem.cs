namespace CompositePattern;

public abstract class FileSystemItem
{
    protected string Name { get; set; }

    protected FileSystemItem(string name) 
    {
        Name = name;
    }

    public abstract void Display(int depth = 0);
    public abstract long GetSize();
}