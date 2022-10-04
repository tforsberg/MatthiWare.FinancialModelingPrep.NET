using System.Runtime.Serialization;

namespace MatthiWare.FinancialModelingPrep.Model
{
    public enum Period
    {
        [EnumMember(Value = "quarter")]
        Quarter,

        [EnumMember(Value = "annual")]
        Annual,
    }

    public enum HistoricalPricingPeriod
    {
        OneMinute,
        FiveMinute,
        FifteenMinute,
        ThirtyMinute,
        OneHour,
        FourHour
    }
}
