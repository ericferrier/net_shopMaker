//Generated by DataSourceBaseGenerator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
using MakerShop.Utility;

namespace MakerShop.Users
{
    /// <summary>
    /// DataSource class for WishlistItem objects
    /// </summary>
    public partial class WishlistItemDataSource
    {
        /// <summary>
        /// Deletes a WishlistItem object from the database
        /// </summary>
        /// <param name="wishlistItem">The WishlistItem object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(WishlistItem wishlistItem)
        {
            return wishlistItem.Delete();
        }

        /// <summary>
        /// Deletes a WishlistItem object with given id from the database
        /// </summary>
        /// <param name="wishlistItemId">Value of WishlistItemId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 wishlistItemId)
        {
            WishlistItem wishlistItem = new WishlistItem();
            if (wishlistItem.Load(wishlistItemId)) return wishlistItem.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a WishlistItem object to the database.
        /// </summary>
        /// <param name="wishlistItem">The WishlistItem object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(WishlistItem wishlistItem) { return wishlistItem.Save(); }

        /// <summary>
        /// Loads a WishlistItem object for given Id from the database.
        /// </summary>
        /// <param name="wishlistItemId">Value of WishlistItemId of the object to load.</param>
        /// <returns>If the load is successful the newly loaded WishlistItem object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItem Load(Int32 wishlistItemId)
        {
            return WishlistItemDataSource.Load(wishlistItemId, true);
        }

        /// <summary>
        /// Loads a WishlistItem object for given Id from the database.
        /// </summary>
        /// <param name="wishlistItemId">Value of WishlistItemId of the object to load.</param>
        /// <param name="useCache">If true tries to load object from cache first.</param>
        /// <returns>If the load is successful the newly loaded WishlistItem object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItem Load(Int32 wishlistItemId, bool useCache)
        {
            if (wishlistItemId == 0) return null;
            WishlistItem wishlistItem = null;
            string key = "WishlistItem_" + wishlistItemId.ToString();
            if (useCache)
            {
                wishlistItem = ContextCache.GetObject(key) as WishlistItem;
                if (wishlistItem != null) return wishlistItem;
            }
            wishlistItem = new WishlistItem();
            if (wishlistItem.Load(wishlistItemId))
            {
                if (useCache) ContextCache.SetObject(key, wishlistItem);
                return wishlistItem;
            }
            return null;
        }

        /// <summary>
        /// Counts the number of WishlistItem objects in result if retrieved using the given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the WishlistItem objects that should be loaded.</param>
        /// <returns>The number of WishlistItem objects matching the criteria</returns>
        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_WishlistItems" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection  LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + WishlistItem.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_WishlistItems");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            WishlistItemCollection results = new WishlistItemCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        WishlistItem wishlistItem = new WishlistItem();
                        WishlistItem.LoadDataReader(wishlistItem, dr);
                        results.Add(wishlistItem);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of WishlistItem objects for the given ProductId in the database.
        /// <param name="productId">The given ProductId</param>
        /// </summary>
        /// <returns>The Number of WishlistItem objects for the given ProductId in the database.</returns>
        public static int CountForProduct(Int32 productId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_WishlistItems WHERE ProductId = @productId");
            database.AddInParameter(selectCommand, "@productId", System.Data.DbType.Int32, productId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects for the given ProductId from the database
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForProduct(Int32 productId)
        {
            return LoadForProduct(productId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects for the given ProductId from the database
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForProduct(Int32 productId, string sortExpression)
        {
            return LoadForProduct(productId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects for the given ProductId from the database
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForProduct(Int32 productId, int maximumRows, int startRowIndex)
        {
            return LoadForProduct(productId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects for the given ProductId from the database
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForProduct(Int32 productId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + WishlistItem.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_WishlistItems");
            selectQuery.Append(" WHERE ProductId = @productId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@productId", System.Data.DbType.Int32, productId);
            //EXECUTE THE COMMAND
            WishlistItemCollection results = new WishlistItemCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        WishlistItem wishlistItem = new WishlistItem();
                        WishlistItem.LoadDataReader(wishlistItem, dr);
                        results.Add(wishlistItem);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of WishlistItem objects for the given WishlistId in the database.
        /// <param name="wishlistId">The given WishlistId</param>
        /// </summary>
        /// <returns>The Number of WishlistItem objects for the given WishlistId in the database.</returns>
        public static int CountForWishlist(Int32 wishlistId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_WishlistItems WHERE WishlistId = @wishlistId");
            database.AddInParameter(selectCommand, "@wishlistId", System.Data.DbType.Int32, wishlistId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects for the given WishlistId from the database
        /// </summary>
        /// <param name="wishlistId">The given WishlistId</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForWishlist(Int32 wishlistId)
        {
            return LoadForWishlist(wishlistId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects for the given WishlistId from the database
        /// </summary>
        /// <param name="wishlistId">The given WishlistId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForWishlist(Int32 wishlistId, string sortExpression)
        {
            return LoadForWishlist(wishlistId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects for the given WishlistId from the database
        /// </summary>
        /// <param name="wishlistId">The given WishlistId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForWishlist(Int32 wishlistId, int maximumRows, int startRowIndex)
        {
            return LoadForWishlist(wishlistId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItem objects for the given WishlistId from the database
        /// </summary>
        /// <param name="wishlistId">The given WishlistId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItem objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemCollection LoadForWishlist(Int32 wishlistId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + WishlistItem.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_WishlistItems");
            selectQuery.Append(" WHERE WishlistId = @wishlistId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@wishlistId", System.Data.DbType.Int32, wishlistId);
            //EXECUTE THE COMMAND
            WishlistItemCollection results = new WishlistItemCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        WishlistItem wishlistItem = new WishlistItem();
                        WishlistItem.LoadDataReader(wishlistItem, dr);
                        results.Add(wishlistItem);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Updates/Saves the given WishlistItem object to the database.
        /// </summary>
        /// <param name="wishlistItem">The WishlistItem object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(WishlistItem wishlistItem) { return wishlistItem.Save(); }

    }
}
