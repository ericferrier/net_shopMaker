namespace MakerShop.Products
{
    using System;
    using MakerShop.Common;
    /// <summary>
    /// This class implements a PersistentCollection of OptionChoice objects.
    /// </summary>
    public partial class OptionChoiceCollection : PersistentCollection<OptionChoice>
    {
        /// <summary>
        /// Gets the index of the CatalogNode object in this collection whose primary key
        /// matches the given value.
        /// </summary>
        /// <param name="optionChoiceId">Value of OptionChoiceId of the required object.</param>
        /// <returns>Index of the required object.</returns>
        public int IndexOf(Int32 optionChoiceId)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (optionChoiceId == this[i].OptionChoiceId) return i;
            }
            return -1;
        }
    }
}
