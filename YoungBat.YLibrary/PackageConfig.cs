namespace YoungBat.YLibrary
{
    /// <summary>
    /// Easy Package Configuration Class for Package Class and Package Manager Class
    /// </summary>
    /// <param name="name">Package Name,can't be null</param>
    /// <param name="description">Package Description,can't be null</param>
    /// <param name="author">Package Author,can't be null</param>
    /// <param name="files">Package Files List,can't be null</param>
    public class PackageConfig(string name, string description, string author, List<string> files)
    {
        /// <summary>
        /// Package Name
        /// </summary>
        public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));
        /// <summary>
        /// Package Description
        /// </summary>
        public string Description { get; } = description ?? throw new ArgumentNullException(nameof(description));
        /// <summary>
        /// Package Author
        /// </summary>
        public string Author { get; } = author ?? throw new ArgumentNullException(nameof(author));
        /// <summary>
        /// Package Files List
        /// </summary>
        public IReadOnlyList<string> Files { get; } = (files ?? throw new ArgumentNullException(nameof(files))).AsReadOnly();
    }
}
