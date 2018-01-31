namespace RingCentral
{
    public partial class GetExtensionPhoneNumbersResponse
    {
        // List of phone numbers
        public PhoneNumberInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
