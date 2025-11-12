namespace CompositePattern;

public class Directory : FileSystemItem
{
    private readonly List<FileSystemItem> _children = new List<FileSystemItem>();

    public Directory(string name) : base(name)
    {
    }

    public void Add(FileSystemItem item) 
    {
        _children.Add(item);
    }

    public void Remove(FileSystemItem item)
    {
        _children.Remove(item);
    }

    public override void Display(int depth = 0)
    {
        Console.WriteLine($"{new string(' ', depth * 2)} {Name}/");
        foreach (var child in _children)
        {
            child.Display(depth + 1);
        }
    }

    public override long GetSize()
    {
        long totalSize = 0;
        foreach (var child in _children) 
        {
            totalSize += child.GetSize();
        }

        return totalSize;
    }
}