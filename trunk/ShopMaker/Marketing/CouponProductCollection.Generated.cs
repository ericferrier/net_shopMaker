namespace MakerShop.Marketing
{
    using System;
    using MakerShop.Common;
    /// <summary>
    /// This class implements a PersistentCollection of CouponProduct objects.
    /// </summary>
    public partial class CouponProductCollection : PersistentCollection<CouponProduct>
    {
        /// <summary>
        /// Gets the index of the CatalogNode object in this collection whose primary key
        /// matches the given value.
        /// </summary>
        /// <param name="couponId">Value of CouponId of the required object.</param>
        /// <param name="productId">Value of ProductId of the required object.</param>
        /// <returns>Index of the required object.</returns>
        public int IndexOf(Int32 couponId, Int32 productId)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((couponId == this[i].CouponId) && (productId == this[i].ProductId)) return i;
            }
            return -1;
        }
    }
}
