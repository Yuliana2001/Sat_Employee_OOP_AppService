using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public decimal CommissionPercentage { get; set; }
        public decimal Sales { get; set; }
        #endregion

        #region Methods

        public CommissionEmployee()
        {
        }

        public override decimal GetValueToPay()
        {
            // Calculate the payment based on commission percentage and sales
            return (CommissionPercentage / 100) * Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Porcentaje de Comisión: {CommissionPercentage}%\n\t" +
                $"Ventas realizadas: {Sales:C2}\n\t";
        }

        #endregion

    }
}
