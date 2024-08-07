﻿using P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Interfaces.IEntities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models
{
    public class ContractModality : IContractModality
    {
        #region Scalar Properties

        [Required]
        [ForeignKey("Contract Id")]
        public int ContractId { get; set; }

        [Required]
        [ForeignKey("Modality Id")]
        public int ModalityId { get; set; }

        #endregion

        #region Navigation Properties

        public virtual Contract Contract { get; set; }
        public virtual Modality Modality { get; set; }

        #endregion

    }
}
