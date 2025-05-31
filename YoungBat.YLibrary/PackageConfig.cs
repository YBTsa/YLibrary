namespace YoungBat.YLibrary
{
    public class PackageConfig(string name, string description, string author, List<string> files)
    {
        public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));
        public string Description { get; } = description ?? throw new ArgumentNullException(nameof(description));
        public string Author { get; } = author ?? throw new ArgumentNullException(nameof(author));
        public IReadOnlyList<string> Files { get; } = (files ?? throw new ArgumentNullException(nameof(files))).AsReadOnly();
    }
}
