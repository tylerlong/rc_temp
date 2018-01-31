namespace RingCentral
{
    public partial class CallQueueInfo
    {
        // Target percentage of calls that must be answered by agents within the service level time threshold
        public long? @slaGoal { get; set; }
        // Period of time in seconds that is considered to be an acceptable service level
        public long? @slaThresholdSeconds { get; set; }
        // If 'True' abandoned calls (hanged up prior to being served) are included into service level calculation
        public bool? @includeAbandonedCalls { get; set; }
        // Period of time in seconds specifying abandoned calls duration - calls that are shorter will not be included into the calculation of service level.; zero value means that abandoned calls of any duration will be included into calculation
        public long? @abandonedThresholdSeconds { get; set; }
    }
}
