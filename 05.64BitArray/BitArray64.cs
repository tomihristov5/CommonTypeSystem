namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("The Array has 64 bits!");
                }

                return ((int)(this.Number >> index) & 1);
            }
            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }
                if (value == 1)
                {
                    this.number = this.number | ((ulong)1 << index);
                }
                else
                {
                    this.number = this.number & (~((ulong)1 << index));
                }
            }
        }

        public override bool Equals(object obj)
        {
            var objAsNumber = obj as BitArray64;

            if (objAsNumber == null)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public static bool operator == (BitArray64 firstArray, BitArray64 secondArray)
        {
            return object.Equals(firstArray, secondArray);
        }

        public static bool operator != (BitArray64 firstArray, BitArray64 secondArray)
        {
            return !(object.Equals(firstArray, secondArray));
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
