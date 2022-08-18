using System.Diagnostics.CodeAnalysis;

namespace ElegantObjectsSamples._2_6_be_immutable
{
    internal class CashEqualityComparer : IEqualityComparer<Cash>
    {
        public bool Equals(Cash? x, Cash? y)
        {
            return x?.Dollars == y?.Dollars;
        }

        public int GetHashCode([DisallowNull] Cash obj)
        {
            return obj.Dollars;
        }
    }
}
