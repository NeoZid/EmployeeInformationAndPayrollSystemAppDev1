using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EmployeeInformationAndPayrollSystemAppDev1
{
    internal class PayrollCalculator
    {
        public PayrollCalculator() { }

        public double CalculateGross(double hourlyRate, double hoursWorked) 
        {
            double total;
            double overTime;

            total = hourlyRate * hoursWorked;

            if (hoursWorked > 40)
            {
                overTime = hourlyRate * 1.5 * (hoursWorked - 40);
                return total + overTime;
            }

            return total;
        }

        public double CalculateNet(double grossPay) 
        {
            double netPay = grossPay - (grossPay * 0.15);
            return netPay;
        }
    }
}
