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
    /// DataSource class for WishlistItemInput objects
    /// </summary>
    public partial class WishlistItemInputDataSource
    {
        /// <summary>
        /// Deletes a WishlistItemInput object from the database
        /// </summary>
        /// <param name="wishlistItemInput">The WishlistItemInput object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(WishlistItemInput wishlistItemInput)
        {
            return wishlistItemInput.Delete();
        }

        /// <summary>
        /// Deletes a WishlistItemInput object with given id from the database
        /// </summary>
        /// <param name="wishlistItemInputId">Value of WishlistItemInputId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 wishlistItemInputId)
        {
            WishlistItemInput wishlistItemInput = new WishlistItemInput();
            if (wishlistItemInput.Load(wishlistItemInputId)) return wishlistItemInput.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a WishlistItemInput object to the database.
        /// </summary>
        /// <param name="wishlistItemInput">The WishlistItemInput object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(WishlistItemInput wishlistItemInput) { return wishlistItemInput.Save(); }

        /// <summary>
        /// Loads a WishlistItemInput object for given Id from the database.
        /// </summary>
        /// <param name="wishlistItemInputId">Value of WishlistItemInputId of the object to load.</param>
        /// <returns>If the load is successful the newly loaded WishlistItemInput object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInput Load(Int32 wishlistItemInputId)
        {
            return WishlistItemInputDataSource.Load(wishlistItemInputId, true);
        }

        /// <summary>
        /// Loads a WishlistItemInput object for given Id from the database.
        /// </summary>
        /// <param name="wishlistItemInputId">Value of WishlistItemInputId of the object to load.</param>
        /// <param name="useCache">If true tries to load object from cache first.</param>
        /// <returns>If the load is successful the newly loaded WishlistItemInput object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInput Load(Int32 wishlistItemInputId, bool useCache)
        {
            if (wishlistItemInputId == 0) return null;
            WishlistItemInput wishlistItemInput = null;
            string key = "WishlistItemInput_" + wishlistItemInputId.ToString();
            if (useCache)
            {
                wishlistItemInput = ContextCache.GetObject(key) as WishlistItemInput;
                if (wishlistItemInput != null) return wishlistItemInput;
            }
            wishlistItemInput = new WishlistItemInput();
            if (wishlistItemInput.Load(wishlistItemInputId))
            {
                if (useCache) ContextCache.SetObject(key, wishlistItemInput);
                return wishlistItemInput;
            }
            return null;
        }

        /// <summary>
        /// Counts the number of WishlistItemInput objects in result if retrieved using the given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the WishlistItemInput objects that should be loaded.</param>
        /// <returns>The number of WishlistItemInput objects matching the criteria</returns>
        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_WishlistItemInputs" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection  LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + WishlistItemInput.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_WishlistItemInputs");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            WishlistItemInputCollection results = new WishlistItemInputCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        WishlistItemInput wishlistItemInput = new WishlistItemInput();
                        WishlistItemInput.LoadDataReader(wishlistItemInput, dr);
                        results.Add(wishlistItemInput);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of WishlistItemInput objects for the given InputFieldId in the database.
        /// <param name="inputFieldId">The given InputFieldId</param>
        /// </summary>
        /// <returns>The Number of WishlistItemInput objects for the given InputFieldId in the database.</returns>
        public static int CountForInputField(Int32 inputFieldId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_WishlistItemInputs WHERE InputFieldId = @inputFieldId");
            database.AddInParameter(selectCommand, "@inputFieldId", System.Data.DbType.Int32, inputFieldId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects for the given InputFieldId from the database
        /// </summary>
        /// <param name="inputFieldId">The given InputFieldId</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForInputField(Int32 inputFieldId)
        {
            return LoadForInputField(inputFieldId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects for the given InputFieldId from the database
        /// </summary>
        /// <param name="inputFieldId">The given InputFieldId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForInputField(Int32 inputFieldId, string sortExpression)
        {
            return LoadForInputField(inputFieldId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects for the given InputFieldId from the database
        /// </summary>
        /// <param name="inputFieldId">The given InputFieldId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForInputField(Int32 inputFieldId, int maximumRows, int startRowIndex)
        {
            return LoadForInputField(inputFieldId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects for the given InputFieldId from the database
        /// </summary>
        /// <param name="inputFieldId">The given InputFieldId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForInputField(Int32 inputFieldId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + WishlistItemInput.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_WishlistItemInputs");
            selectQuery.Append(" WHERE InputFieldId = @inputFieldId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@inputFieldId", System.Data.DbType.Int32, inputFieldId);
            //EXECUTE THE COMMAND
            WishlistItemInputCollection results = new WishlistItemInputCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        WishlistItemInput wishlistItemInput = new WishlistItemInput();
                        WishlistItemInput.LoadDataReader(wishlistItemInput, dr);
                        results.Add(wishlistItemInput);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of WishlistItemInput objects for the given WishlistItemId in the database.
        /// <param name="wishlistItemId">The given WishlistItemId</param>
        /// </summary>
        /// <returns>The Number of WishlistItemInput objects for the given WishlistItemId in the database.</returns>
        public static int CountForWishlistItem(Int32 wishlistItemId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_WishlistItemInputs WHERE WishlistItemId = @wishlistItemId");
            database.AddInParameter(selectCommand, "@wishlistItemId", System.Data.DbType.Int32, wishlistItemId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects for the given WishlistItemId from the database
        /// </summary>
        /// <param name="wishlistItemId">The given WishlistItemId</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForWishlistItem(Int32 wishlistItemId)
        {
            return LoadForWishlistItem(wishlistItemId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects for the given WishlistItemId from the database
        /// </summary>
        /// <param name="wishlistItemId">The given WishlistItemId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForWishlistItem(Int32 wishlistItemId, string sortExpression)
        {
            return LoadForWishlistItem(wishlistItemId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects for the given WishlistItemId from the database
        /// </summary>
        /// <param name="wishlistItemId">The given WishlistItemId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForWishlistItem(Int32 wishlistItemId, int maximumRows, int startRowIndex)
        {
            return LoadForWishlistItem(wishlistItemId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of WishlistItemInput objects for the given WishlistItemId from the database
        /// </summary>
        /// <param name="wishlistItemId">The given WishlistItemId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of WishlistItemInput objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static WishlistItemInputCollection LoadForWishlistItem(Int32 wishlistItemId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + WishlistItemInput.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_WishlistItemInputs");
            selectQuery.Append(" WHERE WishlistItemId = @wishlistItemId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@wishlistItemId", System.Data.DbType.Int32, wishlistItemId);
            //EXECUTE THE COMMAND
            WishlistItemInputCollection results = new WishlistItemInputCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        WishlistItemInput wishlistItemInput = new WishlistItemInput();
                        WishlistItemInput.LoadDataReader(wishlistItemInput, dr);
                        results.Add(wishlistItemInput);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Updates/Saves the given WishlistItemInput object to the database.
        /// </summary>
        /// <param name="wishlistItemInput">The WishlistItemInput object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(WishlistItemInput wishlistItemInput) { return wishlistItemInput.Save(); }

    }
}
