namespace RingCentral
{
    public partial class DetailedPresenceEvent_ActiveCallInfo
    {
        // Internal identifier of a call
        public string @id { get; set; }
        // Call direction
        public string @direction { get; set; }
        // Phone number or extension number of a caller
        public string @from { get; set; }
        // Phone number or extension number of a callee
        public string @to { get; set; }
        // Telephony call status. See Telephony Status Values for detailed status description
        public string @telephonyStatus { get; set; }
        // Internal identifier of a call session
        public string @sessionId { get; set; }
        // Type of call termination. Supported for calls in 'NoCall' status. If the returned termination type is 'Intermediate' it means the call is not actually ended, the connection is established on one of the devices
        public string @terminationType { get; set; }
    }
}
