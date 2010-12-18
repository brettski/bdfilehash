// Enums for BD File Hash
namespace BDFileHash
{
    public enum HashType
    {
        NONE,
        MD5,
        SHA1,
        SHA256,
        SHA512
    }
    
    enum CompareStatus
    {
        clear,
        different,
        same
    }
}