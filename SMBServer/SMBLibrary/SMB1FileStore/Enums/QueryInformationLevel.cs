
namespace SMBLibrary.SMB1
{
    public enum QueryInformationLevel : ushort
    {
        SMB_INFO_STANDARD = 0x0001,            // LANMAN2.0
        SMB_INFO_QUERY_EA_SIZE = 0x0002,       // LANMAN2.0
        SMB_INFO_QUERY_EAS_FROM_LIST = 0x0003, // LANMAN2.0
        SMB_INFO_QUERY_ALL_EAS = 0x0004,       // LANMAN2.0
        SMB_INFO_IS_NAME_VALID = 0x0006,       // LANMAN2.0
        SMB_QUERY_FILE_BASIC_INFO = 0x0101,
        SMB_QUERY_FILE_STANDARD_INFO = 0x0102,
        SMB_QUERY_FILE_EA_INFO = 0x0103,
        SMB_QUERY_FILE_NAME_INFO = 0x0104,
        SMB_QUERY_FILE_ALL_INFO = 0x0107,
        SMB_QUERY_FILE_ALT_NAME_INFO = 0x0108,
        SMB_QUERY_FILE_STREAM_INFO = 0x0109,
        SMB_QUERY_FILE_COMPRESSION_INFO = 0x010B,
    }
}
