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
    /// DataSource class for SubscriptionPlan objects
    /// </summary>
    public partial class SubscriptionPlanDataSource
    {
        /// <summary>
        /// Deletes a SubscriptionPlan object from the database
        /// </summary>
        /// <param name="subscriptionPlan">The SubscriptionPlan object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(SubscriptionPlan subscriptionPlan)
        {
            return subscriptionPlan.Delete();
        }

        /// <summary>
        /// Deletes a SubscriptionPlan object with given id from the database
        /// </summary>
        /// <param name="productId">Value of ProductId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 productId)
        {
            SubscriptionPlan subscriptionPlan = new SubscriptionPlan();
            if (subscriptionPlan.Load(productId)) return subscriptionPlan.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a SubscriptionPlan object to the database.
        /// </summary>
        /// <param name="subscriptionPlan">The SubscriptionPlan object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(SubscriptionPlan subscriptionPlan) { return subscriptionPlan.Save(); }

        /// <summary>
        /// Loads a SubscriptionPlan object for given Id from the database.
        /// </summary>
        /// <param name="productId">Value of ProductId of the object to load.</param>
        /// <returns>If the load is successful the newly loaded SubscriptionPlan object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlan Load(Int32 productId)
        {
            return SubscriptionPlanDataSource.Load(productId, true);
        }

        /// <summary>
        /// Loads a SubscriptionPlan object for given Id from the database.
        /// </summary>
        /// <param name="productId">Value of ProductId of the object to load.</param>
        /// <param name="useCache">If true tries to load object from cache first.</param>
        /// <returns>If the load is successful the newly loaded SubscriptionPlan object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlan Load(Int32 productId, bool useCache)
        {
            if (productId == 0) return null;
            SubscriptionPlan subscriptionPlan = null;
            string key = "SubscriptionPlan_" + productId.ToString();
            if (useCache)
            {
                subscriptionPlan = ContextCache.GetObject(key) as SubscriptionPlan;
                if (subscriptionPlan != null) return subscriptionPlan;
            }
            subscriptionPlan = new SubscriptionPlan();
            if (subscriptionPlan.Load(productId))
            {
                if (useCache) ContextCache.SetObject(key, subscriptionPlan);
                return subscriptionPlan;
            }
            return null;
        }

        /// <summary>
        /// Counts the number of SubscriptionPlan objects in result if retrieved using the given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the SubscriptionPlan objects that should be loaded.</param>
        /// <returns>The number of SubscriptionPlan objects matching the criteria</returns>
        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_SubscriptionPlans" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection  LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + SubscriptionPlan.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_SubscriptionPlans");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            SubscriptionPlanCollection results = new SubscriptionPlanCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        SubscriptionPlan subscriptionPlan = new SubscriptionPlan();
                        SubscriptionPlan.LoadDataReader(subscriptionPlan, dr);
                        results.Add(subscriptionPlan);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of SubscriptionPlan objects for the given GroupId in the database.
        /// <param name="groupId">The given GroupId</param>
        /// </summary>
        /// <returns>The Number of SubscriptionPlan objects for the given GroupId in the database.</returns>
        public static int CountForGroup(Int32 groupId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_SubscriptionPlans WHERE GroupId = @groupId");
            database.AddInParameter(selectCommand, "@groupId", System.Data.DbType.Int32, NullableData.DbNullify(groupId));
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects for the given GroupId from the database
        /// </summary>
        /// <param name="groupId">The given GroupId</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForGroup(Int32 groupId)
        {
            return LoadForGroup(groupId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects for the given GroupId from the database
        /// </summary>
        /// <param name="groupId">The given GroupId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForGroup(Int32 groupId, string sortExpression)
        {
            return LoadForGroup(groupId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects for the given GroupId from the database
        /// </summary>
        /// <param name="groupId">The given GroupId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForGroup(Int32 groupId, int maximumRows, int startRowIndex)
        {
            return LoadForGroup(groupId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects for the given GroupId from the database
        /// </summary>
        /// <param name="groupId">The given GroupId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForGroup(Int32 groupId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + SubscriptionPlan.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_SubscriptionPlans");
            selectQuery.Append(" WHERE GroupId = @groupId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@groupId", System.Data.DbType.Int32, NullableData.DbNullify(groupId));
            //EXECUTE THE COMMAND
            SubscriptionPlanCollection results = new SubscriptionPlanCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        SubscriptionPlan subscriptionPlan = new SubscriptionPlan();
                        SubscriptionPlan.LoadDataReader(subscriptionPlan, dr);
                        results.Add(subscriptionPlan);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of SubscriptionPlan objects for the given TaxCodeId in the database.
        /// <param name="taxCodeId">The given TaxCodeId</param>
        /// </summary>
        /// <returns>The Number of SubscriptionPlan objects for the given TaxCodeId in the database.</returns>
        public static int CountForTaxCode(Int32 taxCodeId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_SubscriptionPlans WHERE TaxCodeId = @taxCodeId");
            database.AddInParameter(selectCommand, "@taxCodeId", System.Data.DbType.Int32, NullableData.DbNullify(taxCodeId));
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects for the given TaxCodeId from the database
        /// </summary>
        /// <param name="taxCodeId">The given TaxCodeId</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForTaxCode(Int32 taxCodeId)
        {
            return LoadForTaxCode(taxCodeId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects for the given TaxCodeId from the database
        /// </summary>
        /// <param name="taxCodeId">The given TaxCodeId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForTaxCode(Int32 taxCodeId, string sortExpression)
        {
            return LoadForTaxCode(taxCodeId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects for the given TaxCodeId from the database
        /// </summary>
        /// <param name="taxCodeId">The given TaxCodeId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForTaxCode(Int32 taxCodeId, int maximumRows, int startRowIndex)
        {
            return LoadForTaxCode(taxCodeId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of SubscriptionPlan objects for the given TaxCodeId from the database
        /// </summary>
        /// <param name="taxCodeId">The given TaxCodeId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of SubscriptionPlan objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SubscriptionPlanCollection LoadForTaxCode(Int32 taxCodeId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + SubscriptionPlan.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_SubscriptionPlans");
            selectQuery.Append(" WHERE TaxCodeId = @taxCodeId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@taxCodeId", System.Data.DbType.Int32, NullableData.DbNullify(taxCodeId));
            //EXECUTE THE COMMAND
            SubscriptionPlanCollection results = new SubscriptionPlanCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        SubscriptionPlan subscriptionPlan = new SubscriptionPlan();
                        SubscriptionPlan.LoadDataReader(subscriptionPlan, dr);
                        results.Add(subscriptionPlan);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Updates/Saves the given SubscriptionPlan object to the database.
        /// </summary>
        /// <param name="subscriptionPlan">The SubscriptionPlan object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(SubscriptionPlan subscriptionPlan) { return subscriptionPlan.Save(); }

    }
}
