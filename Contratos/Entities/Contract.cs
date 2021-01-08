using System;
using System.Collections.Generic;


namespace Contratos.Entities
{
    class Contract
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double totalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
            Installments = new List<Installment>();
        }
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
