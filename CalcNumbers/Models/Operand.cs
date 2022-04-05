using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcNumbers.Models
{
    public class Operand
    {
        public Operand()
        {

        }
        public string Add(int first, int secend)
        {
            return (first + secend).ToString();
        }
        public string Sub(int first, int secend)
        {
            return (first - secend).ToString();
        }
        public string Divide(int first, int secend)
        {
            if (secend != 0)
            {
                return (first / secend).ToString();

            }
            else
            {
                return "Cannot Divide By Zero";
            }
        }
        public string multiply(int first, int secend)
        {
            return (first * secend).ToString();
        }
    }
}