﻿using P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Enums;
namespace P02_2_ASP.NET_Core_MVC_M01_ClaudiaSouza.Models
{
    public class GymModality : Interfaces.IGymModality
    {
        #region Scalar Properties
        public int ModalityID { get; set; }
        public EnumModalityType ModalityType { get; set; }
        #endregion

        #region Navigation Properties
        // Relantionship: GymModality 1 - N Membership
        public ICollection<Membership> Memberships { get; set; }
        #endregion

        #region Constructors
        public GymModality()
        {
            Memberships = new HashSet<Membership>();
        }
        #endregion
    }
}
