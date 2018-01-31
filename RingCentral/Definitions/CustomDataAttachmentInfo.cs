namespace RingCentral
{
    public partial class CustomDataAttachmentInfo
    {
        // Link to custom data attachment
        public string @uri { get; set; }
        // Type of custom data attachment, see also MIME Types
        public string @contentType { get; set; }
    }
}
