//Generated by DataSourceBaseGenerator_Assn

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
namespace MakerShop.Marketing
{

    /// <summary>
    /// DataSource class for CategoryVolumeDiscount objects
    /// </summary>
    public partial class CategoryVolumeDiscountDataSource
    {
        /// <summary>
        /// Deletes a CategoryVolumeDiscount object from the database
        /// </summary>
        /// <param name="categoryVolumeDiscount">The CategoryVolumeDiscount object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(CategoryVolumeDiscount categoryVolumeDiscount)
        {
            return categoryVolumeDiscount.Delete();
        }

        /// <summary>
        /// Deletes a CategoryVolumeDiscount object with given id from the database
        /// </summary>
        /// <param name="categoryId">Value of CategoryId of the object to delete.</param>
        /// <param name="volumeDiscountId">Value of VolumeDiscountId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 categoryId, Int32 volumeDiscountId)
        {
            CategoryVolumeDiscount categoryVolumeDiscount = new CategoryVolumeDiscount();
            if (categoryVolumeDiscount.Load(categoryId, volumeDiscountId)) return categoryVolumeDiscount.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a CategoryVolumeDiscount object to the database.
        /// </summary>
        /// <param name="categoryVolumeDiscount">The CategoryVolumeDiscount object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(CategoryVolumeDiscount categoryVolumeDiscount) { return categoryVolumeDiscount.Save(); }

        /// <summary>
        /// Load a CategoryVolumeDiscount object for the given primary key from the database.
        /// </summary>
        /// <param name="categoryId">Value of CategoryId of the object to load.</param>
        /// <param name="volumeDiscountId">Value of VolumeDiscountId of the object to load.</param>
        /// <returns>The loaded CategoryVolumeDiscount object.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CategoryVolumeDiscount Load(Int32 categoryId, Int32 volumeDiscountId)
        {
            CategoryVolumeDiscount categoryVolumeDiscount = new CategoryVolumeDiscount();
            categoryVolumeDiscount.CategoryId = categoryId;
            categoryVolumeDiscount.VolumeDiscountId = volumeDiscountId;
            categoryVolumeDiscount.IsDirty = false;
            return categoryVolumeDiscount;
        }

        /// <summary>
        /// Loads a collection of CategoryVolumeDiscount objects for the given criteria for Category from the database.
        /// </summary>
        /// <param name="categoryId">Value of CategoryId of the object to load.</param>
        /// <returns>A collection of CategoryVolumeDiscount objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CategoryVolumeDiscountCollection LoadForCategory(Int32 categoryId)
        {
            CategoryVolumeDiscountCollection CategoryVolumeDiscounts = new CategoryVolumeDiscountCollection();
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT VolumeDiscountId");
            selectQuery.Append(" FROM ac_CategoryVolumeDiscounts");
            selectQuery.Append(" WHERE CategoryId = @categoryId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@categoryId", System.Data.DbType.Int32, categoryId);
            //EXECUTE THE COMMAND
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read())
                {
                    CategoryVolumeDiscount categoryVolumeDiscount = new CategoryVolumeDiscount();
                    categoryVolumeDiscount.CategoryId = categoryId;
                    categoryVolumeDiscount.VolumeDiscountId = dr.GetInt32(0);
                    CategoryVolumeDiscounts.Add(categoryVolumeDiscount);
                }
                dr.Close();
            }
            return CategoryVolumeDiscounts;
        }

        /// <summary>
        /// Loads a collection of CategoryVolumeDiscount objects for the given criteria for VolumeDiscount from the database.
        /// </summary>
        /// <param name="volumeDiscountId">Value of VolumeDiscountId of the object to load.</param>
        /// <returns>A collection of CategoryVolumeDiscount objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CategoryVolumeDiscountCollection LoadForVolumeDiscount(Int32 volumeDiscountId)
        {
            CategoryVolumeDiscountCollection CategoryVolumeDiscounts = new CategoryVolumeDiscountCollection();
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT CategoryId");
            selectQuery.Append(" FROM ac_CategoryVolumeDiscounts");
            selectQuery.Append(" WHERE VolumeDiscountId = @volumeDiscountId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@volumeDiscountId", System.Data.DbType.Int32, volumeDiscountId);
            //EXECUTE THE COMMAND
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read())
                {
                    CategoryVolumeDiscount categoryVolumeDiscount = new CategoryVolumeDiscount();
                    categoryVolumeDiscount.VolumeDiscountId = volumeDiscountId;
                    categoryVolumeDiscount.CategoryId = dr.GetInt32(0);
                    CategoryVolumeDiscounts.Add(categoryVolumeDiscount);
                }
                dr.Close();
            }
            return CategoryVolumeDiscounts;
        }

        /// <summary>
        /// Updates/Saves the given CategoryVolumeDiscount object to the database.
        /// </summary>
        /// <param name="categoryVolumeDiscount">The CategoryVolumeDiscount object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(CategoryVolumeDiscount categoryVolumeDiscount) { return categoryVolumeDiscount.Save(); }

    }
}