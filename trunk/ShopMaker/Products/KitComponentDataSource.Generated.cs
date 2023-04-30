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

namespace MakerShop.Products
{
    /// <summary>
    /// DataSource class for KitComponent objects
    /// </summary>
    public partial class KitComponentDataSource
    {
        /// <summary>
        /// Deletes a KitComponent object from the database
        /// </summary>
        /// <param name="kitComponent">The KitComponent object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(KitComponent kitComponent)
        {
            return kitComponent.Delete();
        }

        /// <summary>
        /// Deletes a KitComponent object with given id from the database
        /// </summary>
        /// <param name="kitComponentId">Value of KitComponentId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 kitComponentId)
        {
            KitComponent kitComponent = new KitComponent();
            if (kitComponent.Load(kitComponentId)) return kitComponent.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a KitComponent object to the database.
        /// </summary>
        /// <param name="kitComponent">The KitComponent object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(KitComponent kitComponent) { return kitComponent.Save(); }

        /// <summary>
        /// Loads a KitComponent object for given Id from the database.
        /// </summary>
        /// <param name="kitComponentId">Value of KitComponentId of the object to load.</param>
        /// <returns>If the load is successful the newly loaded KitComponent object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponent Load(Int32 kitComponentId)
        {
            return KitComponentDataSource.Load(kitComponentId, true);
        }

        /// <summary>
        /// Loads a KitComponent object for given Id from the database.
        /// </summary>
        /// <param name="kitComponentId">Value of KitComponentId of the object to load.</param>
        /// <param name="useCache">If true tries to load object from cache first.</param>
        /// <returns>If the load is successful the newly loaded KitComponent object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponent Load(Int32 kitComponentId, bool useCache)
        {
            if (kitComponentId == 0) return null;
            KitComponent kitComponent = null;
            string key = "KitComponent_" + kitComponentId.ToString();
            if (useCache)
            {
                kitComponent = ContextCache.GetObject(key) as KitComponent;
                if (kitComponent != null) return kitComponent;
            }
            kitComponent = new KitComponent();
            if (kitComponent.Load(kitComponentId))
            {
                if (useCache) ContextCache.SetObject(key, kitComponent);
                return kitComponent;
            }
            return null;
        }

        /// <summary>
        /// Counts the number of KitComponent objects in result if retrieved using the given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the KitComponent objects that should be loaded.</param>
        /// <returns>The number of KitComponent objects matching the criteria</returns>
        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_KitComponents" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of KitComponent objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <returns>A collection of KitComponent objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of KitComponent objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of KitComponent objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of KitComponent objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of KitComponent objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of KitComponent objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of KitComponent objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection  LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + KitComponent.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_KitComponents");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            KitComponentCollection results = new KitComponentCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        KitComponent kitComponent = new KitComponent();
                        KitComponent.LoadDataReader(kitComponent, dr);
                        results.Add(kitComponent);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of KitComponent objects associated with the given ProductId
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <returns>The number of KitComponent objects associated with with the given ProductId</returns>
        public static int CountForProduct(Int32 productId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_ProductKitComponents WHERE ProductId = @productId");
            database.AddInParameter(selectCommand, "@productId", System.Data.DbType.Int32, productId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }
        /// <summary>
        /// Loads the KitComponent objects associated with the given ProductId
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <returns>A collection of KitComponent objects associated with with the given ProductId</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForProduct(Int32 productId)
        {
            return KitComponentDataSource.LoadForProduct(productId, 0, 0, string.Empty);
        }
        /// <summary>
        /// Loads the KitComponent objects associated with the given ProductId
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of KitComponent objects associated with with the given ProductId</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForProduct(Int32 productId, string sortExpression)
        {
            return KitComponentDataSource.LoadForProduct(productId, 0, 0, sortExpression);
        }
        /// <summary>
        /// Loads the KitComponent objects associated with the given ProductId
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of KitComponent objects associated with with the given ProductId</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForProduct(Int32 productId, int maximumRows, int startRowIndex)
        {
            return KitComponentDataSource.LoadForProduct(productId, maximumRows, startRowIndex, string.Empty);
        }
        /// <summary>
        /// Loads the KitComponent objects associated with the given ProductId
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of KitComponent objects associated with with the given ProductId</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForProduct(Int32 productId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + KitComponent.GetColumnNames("ac_KitComponents"));
            selectQuery.Append(" FROM ac_KitComponents, ac_ProductKitComponents");
            selectQuery.Append(" WHERE ac_KitComponents.KitComponentId = ac_ProductKitComponents.KitComponentId");
            selectQuery.Append(" AND ac_ProductKitComponents.ProductId = @productId");
            selectQuery.Append(" AND StoreId = @storeId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@productId", System.Data.DbType.Int32, productId);
            database.AddInParameter(selectCommand, "@storeId", System.Data.DbType.Int32, Token.Instance.StoreId);
            //EXECUTE THE COMMAND
            KitComponentCollection results = new KitComponentCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        KitComponent kitComponent = new KitComponent();
                        KitComponent.LoadDataReader(kitComponent, dr);
                        results.Add(kitComponent);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of KitComponent objects for the current store.
        /// </summary>
        /// <returns>The Number of KitComponent objects in the current store.</returns>
        public static int CountForStore()
        {
            int storeId = Token.Instance.StoreId;
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_KitComponents WHERE StoreId = @storeId");
            database.AddInParameter(selectCommand, "@storeId", System.Data.DbType.Int32, storeId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of KitComponent objects for the current store from the database
        /// </summary>
        /// <returns>A collection of KitComponent objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForStore()
        {
            return LoadForStore(0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of KitComponent objects for the current store from the database. Sorts using the given sort exrpression.
        /// </summary>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of KitComponent objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForStore(string sortExpression)
        {
            return LoadForStore(0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of KitComponent objects for the current store from the database.
        /// </summary>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of KitComponent objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForStore(int maximumRows, int startRowIndex)
        {
            return LoadForStore(maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of KitComponent objects for the current store from the database. Sorts using the given sort exrpression.
        /// </summary>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of KitComponent objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static KitComponentCollection LoadForStore(int maximumRows, int startRowIndex, string sortExpression)
        {
            int storeId = Token.Instance.StoreId;
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + KitComponent.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_KitComponents");
            selectQuery.Append(" WHERE StoreId = @storeId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@storeId", System.Data.DbType.Int32, storeId);
            //EXECUTE THE COMMAND
            KitComponentCollection results = new KitComponentCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        KitComponent kitComponent = new KitComponent();
                        KitComponent.LoadDataReader(kitComponent, dr);
                        results.Add(kitComponent);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Updates/Saves the given KitComponent object to the database.
        /// </summary>
        /// <param name="kitComponent">The KitComponent object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(KitComponent kitComponent) { return kitComponent.Save(); }

    }
}
