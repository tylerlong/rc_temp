namespace RingCentral
{
    public partial class DeviceInfo_ExtensionInfo
    {
        // Internal identifier of an extension
        public string @id { get; set; }
        // Canonical URI of an extension
        public string @uri { get; set; }
        // Number of department extension
        public string @extensionNumber { get; set; }
        // For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
        public string @partnerId { get; set; }
    }
}
