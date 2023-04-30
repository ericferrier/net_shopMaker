using System;
using MakerShop.Common;
using MakerShop.Orders;
using MakerShop.Shipping;
using MakerShop.Users;

namespace MakerShop.Taxes
{
    /// <summary>
    /// This class represents a tax rule
    /// </summary>
    public partial class TaxRule
    {
        /// <summary>
        /// Gets or sets the filter rule for the associated group list
        /// </summary>
        public FilterRule GroupRule
        {
            get { return (FilterRule)this.GroupRuleId; }
            set { this.GroupRuleId = (byte)value; }
        }

        /// <summary>
        /// Gets the tax code that should be set for line items generated by this rule
        /// </summary>
        public TaxCode TaxCode
        {
            get
            {
                if (_TaxCodeId == 0) return null;
                return TaxCodeDataSource.Load(_TaxCodeId);
            }
        }

        /// <summary>
        /// Gets or sets the rounding method that should be used for this tax rule
        /// </summary>
        public RoundingRule RoundingRule
        {
            get { return (RoundingRule)this.RoundingRuleId; }
            set { this.RoundingRuleId = (byte)value; }
        }

        /// <summary>
        /// Determines in a tax applies based on the given addresses.
        /// </summary>
        /// <param name="billingAddress">The billing address</param>
        /// <param name="shippingAddress">The shipping address</param>
        /// <returns>True if the tax applies to the given addresses</returns>
        /// <remarks>This method determines which address to use based on nexus, and indicates whether the tax applies for the given set.</remarks>
        public bool AppliesToAddress(TaxAddress billingAddress, TaxAddress shippingAddress)
        {
            //SHORTCUT IF THERE IS NO ZONE FILTER
            if (this.TaxRuleShipZones.Count == 0) return true;
            if (this.UseBillingAddress) return AppliesToAddress(billingAddress);
            return AppliesToAddress(shippingAddress);
        }

        /// <summary>
        /// Determines in a tax applies based on the given address.
        /// </summary>
        /// <param name="address">The address used to determine tax liability</param>
        /// <returns>True if the tax applies to the given address</returns>
        /// <remarks>This method does not check nexus, it only decides whether the shipzone filter is met by the given address.</remarks>
        public bool AppliesToAddress(TaxAddress address)
        {
            if (this.TaxRuleShipZones.Count == 0) return true;
            ShipZoneCollection shipZones = address.ShipZones;
            foreach (ShipZone zone in shipZones)
            {
                if (this.TaxRuleShipZones.IndexOf(this.TaxRuleId, zone.ShipZoneId) > -1)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Determines in a tax applies based on the given address.
        /// </summary>
        /// <param name="address">The address used to determine tax liability</param>
        /// <returns>True if the tax applies to the given address</returns>
        /// <remarks>This method does not check nexus, it only decides whether the shipzone filter is met by the given address.</remarks>
        public bool AppliesToAddress(Address address)
        {
            return AppliesToAddress(new TaxAddress(address.CountryCode, address.ProvinceId, address.PostalCode));
        }

        /// <summary>
        /// Indicates whether this rule applies to the given tax code.
        /// </summary>
        /// <param name="taxCodeId">Tax code to check against the rule.</param>
        /// <returns>True if the rule applies to the given tax code; false otherwise.</returns>
        public bool AppliesToTaxCode(int taxCodeId)
        {
            foreach (TaxRuleTaxCode tc in this.TaxRuleTaxCodes)
            {
                if (tc.TaxCodeId.Equals(taxCodeId)) return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether the tax rule applies to the user based on group filter
        /// </summary>
        /// <param name="user">The user to check</param>
        /// <returns>True if the tax rule meets the group filter requirement, false otherwise.</returns>
        public bool AppliesToUser(User user)
        {
            //SHORTCUT FOR NO GROUP FILTER
            if (this.GroupRule == FilterRule.All) return true;
            //SEE IF USER IS IN LINKED GROUP
            bool userInLinkedGroup = false;
            if (user != null)
            {
                for (int i = 0; i < user.UserGroups.Count && !userInLinkedGroup; i++)
                {
                    if (this.TaxRuleGroups.IndexOf(this.TaxRuleId, user.UserGroups[i].GroupId) > -1)
                        userInLinkedGroup = true;
                }
            }
            //IF INCLUDE RULE, USER MUST BE IN LINKED GROUP
            if (this.GroupRule == FilterRule.IncludeSelected) return userInLinkedGroup;
            //EXCLUDE RULE, USER MUST NOT BE IN LINKED GROUP
            return !userInLinkedGroup;
        }
    }
}