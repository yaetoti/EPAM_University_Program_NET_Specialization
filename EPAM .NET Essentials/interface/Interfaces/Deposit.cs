using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Interfaces
{
    public abstract class Deposit : IComparable<Deposit>
    {
        public decimal Amount { get; }
        public int Period { get; }

        public Deposit(decimal amount, int period)
        {
            Amount = amount;
            Period = period;
        }

        public abstract decimal Income();

        public int CompareTo([AllowNull] Deposit other)
        {
            if (other is null)
            {
                return 0;
            }

            return (Amount + Income()).CompareTo(other.Amount + other.Income());
        }

        public override bool Equals(object obj)
        {
            if (obj is null || GetType() != obj.GetType())
            {
                return false;
            }

            return CompareTo((Deposit)obj) == 0;
        }

        public override int GetHashCode()
        {
            return (int)Amount;
        }

        public static bool operator ==(Deposit left, Deposit right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }
            else if (left is null || right is null)
            {
                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(Deposit left, Deposit right)
        {
            return !(left == right);
        }

        public static bool operator <(Deposit left, Deposit right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(Deposit left, Deposit right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator <=(Deposit left, Deposit right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >=(Deposit left, Deposit right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}
