﻿using P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Enums;
using P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models;

namespace P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Interfaces.IEntities
{
    public interface IPayment
    {
        #region Scalar Properties

        int PaymentID { get; }
        int ContractId { get; }
        EnumPaymentType PaymentType { get; }
        decimal PaymentBaseValue { get; }
        decimal PaymentBaseRate { get; }
        decimal PaymentTotalValue { get; }
        DateTime PaymentDate { get; }

        #endregion

        #region Navigation Properties

        Contract Contract { get; }

        #endregion

    }
}
