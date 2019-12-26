using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Information
{
    public class Employee
    {
        private string employeeName;
        private double basicAmount, houseRent, medicalAllowance;
        private double rent, medicalCost, totalCost;

        public Employee(string employeeName, double basicAmount, double houseRent, double medicalAllowance)
        {
            this.employeeName = employeeName;
            this.basicAmount = basicAmount;
            this.houseRent = houseRent;
            this.medicalAllowance = medicalAllowance;
        }

        public double HouseRent(double houseRentPercent)
        {
            this.rent = (houseRentPercent * basicAmount) / 100;
            return rent;
        }

        public double MedicalAllowance(double medicalAllowancePercent)
        {
            this.medicalCost = (medicalAllowancePercent * basicAmount) / 100;
            return medicalCost;
        }

        public string GetBalanceInfomation()
        {
            this.totalCost = basicAmount + rent + medicalCost;
            string info = employeeName + ", your have: " + totalCost + " tk.";
            return info;
        }

        //public bool BasicAmount(double basicAmount)
        //{
        //    basicAmount = basicAmount + basicAmount;
        //    return true;
        //}

        //public bool HouseRent(double houseRentPercent)
        //{
        //    houseRent = houseRent + ((houseRentPercent * basicAmount) / 100);
        //    return true;
        //}

        //public bool MedicalAllowance(double medicalAllowancePercent)
        //{
        //    medicalAllowance = medicalAllowance + ((medicalAllowancePercent * basicAmount) / 100);
        //    return true;
        //}

        //public string GetBalanceInfo()
        //{
        //    double total = basicAmount + houseRent + medicalAllowance;
        //    string info = employeeName + ", your have: " + total + " tk.";
        //    return info;
        //}
    }
}
