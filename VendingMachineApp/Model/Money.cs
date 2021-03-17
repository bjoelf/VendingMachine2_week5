using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public class Money
    {
        /// <summary>
        /// Money denominations should be defined as an array of integers (readonly).
        /// </summary>
        private static int[] _denominations;
        public static int[] Denominations { get; private set; }
        public Money()
        {
            _denominations = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        }
        public static bool Exist(int val)
        {
            //if (_denominations == null) {
            //    _denominations = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };
            //}

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




            return change;
        }
    }
}
