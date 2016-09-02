namespace Commons.Security
{
    public interface IAccessControl
    {
        bool Authorize(string NetworkID, string Password);
    }
}