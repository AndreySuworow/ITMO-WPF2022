using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcCreditApp1.Models
{
    public class Credit
    {
        // ID кредита
        public virtual int CreditId { get; set; }
        // Название
        [DisplayName("Название кредита")]
        public virtual string Head { get; set; }
        [DisplayName("Период кредита")]
        // Период, на который выдается кредит
        public virtual int Period { get; set; }
        // Максимальная сумма кредита
        [DisplayName("Макс. сумма кредита")]
        public virtual int Sum { get; set; }
        // Процентная ставка
        [DisplayName("Процентная ставка")]
        public virtual int Procent { get; set; }
    }
}