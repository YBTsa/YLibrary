namespace YoungBat.YLibrary
{
    /// <summary>
    /// Package manager class
    /// </summary>
    /// <param name="packagePath">Location of the package</param>
    public class PackageManager(string packagePath)
    {
        private readonly string _packagePath = packagePath;
    }
}
