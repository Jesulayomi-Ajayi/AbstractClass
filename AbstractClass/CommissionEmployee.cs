using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class CommissionEmployee : Employee
    {
        private decimal grossSales;
        private decimal commissionRate;
        public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate) 
            : base(first, last, ssn)
        {
            GrossSales = sales;
            CommissionRate = rate;
        }
        
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value >= 0)
                    grossSales = value;
                else
                    throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales must be >= 0");
            }
        }
        
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value > 0 && value < 1)
                    commissionRate = value;
                else
                    throw new ArgumentOutOfRangeException("CommissionRate", value, "CommissionRate must be > 0 and < 1");
            }
        }

        public override decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}", "commission employee", base.ToString(), "gross sales", GrossSales, "commission rate", CommissionRate);
        }
    }
}
