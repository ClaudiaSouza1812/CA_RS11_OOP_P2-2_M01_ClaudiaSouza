﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Enums;
using P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Interfaces.IEntities;

namespace P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models
{
    public class Membership : IMembership
    {
        #region Scalar Properties
        [Key]
        [DisplayName("Membership Id")]
        public int MembershipId { get; set; }

        [Required(ErrorMessage = "Membership Name is required")]
        [Column(TypeName = "int")]
        [DisplayName("Membership Name")]
        [EnumDataType(typeof(EnumMembershipType))]
        public EnumMembershipType MembershipType { get; set; }

        [Required(ErrorMessage = "The field 'Discount' is mandatory.")]
        [Column(TypeName = "decimal(5,2)")]
        [Range(0, 20, ErrorMessage = "Discount must be between 0 and 20.")]
        public decimal Discount { get; set; }

        #endregion

        #region Navigation Properties


        public virtual ICollection<Contract> Contracts { get; set; }

        #endregion

        #region Constructors

        public Membership()
        {
            MembershipType = EnumMembershipType.Monthly;
            Contracts = new List<Contract>();
        }

        public Membership(EnumMembershipType membershipType, decimal discount) : this()
        {
            MembershipType = membershipType;
            Discount = discount;
        }

        #endregion

        
        
    }
}
