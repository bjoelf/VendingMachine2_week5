using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public class Money
    {
        private static int[] _denominations;
        public static int[] Denominations { get; private set; }
        public Money()
        {
            _denominations = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        }
        public static bool Exist(int val)
        {
            int exists = Array.IndexOf(_denominations, val);
            if (exists < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static int[] GiveChange(int payout)
        {
            int[] change = new int[0];
            if (payout == 0) return change;

            int denSeq = _denominations.Length -1;
            do
            {
                if (payout < _denominations[denSeq]) {
                    denSeq--;
                }
                else
                {
                    Array.Resize(ref change, change.Length + 1);
                    change[change.Length-1] = _denominations[denSeq];
                    payout = payout - _denominations[denSeq];
                    if (payout == 0) return change;
                }
            } while (true);
        }
    }
}
