namespace ProcessFile.API.Providers.Interface
{
    public interface IHash
    {
        string GenerateHash(string password);
        bool CompareHash(string password, string hash);
    }
}
