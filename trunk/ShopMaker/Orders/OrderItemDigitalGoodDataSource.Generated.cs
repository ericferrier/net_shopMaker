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

namespace MakerShop.Orders
{
    /// <summary>
    /// DataSource class for OrderItemDigitalGood objects
    /// </summary>
    public partial class OrderItemDigitalGoodDataSource
    {
        /// <summary>
        /// Deletes a OrderItemDigitalGood object from the database
        /// </summary>
        /// <param name="orderItemDigitalGood">The OrderItemDigitalGood object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(OrderItemDigitalGood orderItemDigitalGood)
        {
            return orderItemDigitalGood.Delete();
        }

        /// <summary>
        /// Deletes a OrderItemDigitalGood object with given id from the database
        /// </summary>
        /// <param name="orderItemDigitalGoodId">Value of OrderItemDigitalGoodId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 orderItemDigitalGoodId)
        {
            OrderItemDigitalGood orderItemDigitalGood = new OrderItemDigitalGood();
            if (orderItemDigitalGood.Load(orderItemDigitalGoodId)) return orderItemDigitalGood.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a OrderItemDigitalGood object to the database.
        /// </summary>
        /// <param name="orderItemDigitalGood">The OrderItemDigitalGood object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(OrderItemDigitalGood orderItemDigitalGood) { return orderItemDigitalGood.Save(); }

        /// <summary>
        /// Loads a OrderItemDigitalGood object for given Id from the database.
        /// </summary>
        /// <param name="orderItemDigitalGoodId">Value of OrderItemDigitalGoodId of the object to load.</param>
        /// <returns>If the load is successful the newly loaded OrderItemDigitalGood object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGood Load(Int32 orderItemDigitalGoodId)
        {
            return OrderItemDigitalGoodDataSource.Load(orderItemDigitalGoodId, true);
        }

        /// <summary>
        /// Loads a OrderItemDigitalGood object for given Id from the database.
        /// </summary>
        /// <param name="orderItemDigitalGoodId">Value of OrderItemDigitalGoodId of the object to load.</param>
        /// <param name="useCache">If true tries to load object from cache first.</param>
        /// <returns>If the load is successful the newly loaded OrderItemDigitalGood object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGood Load(Int32 orderItemDigitalGoodId, bool useCache)
        {
            if (orderItemDigitalGoodId == 0) return null;
            OrderItemDigitalGood orderItemDigitalGood = null;
            string key = "OrderItemDigitalGood_" + orderItemDigitalGoodId.ToString();
            if (useCache)
            {
                orderItemDigitalGood = ContextCache.GetObject(key) as OrderItemDigitalGood;
                if (orderItemDigitalGood != null) return orderItemDigitalGood;
            }
            orderItemDigitalGood = new OrderItemDigitalGood();
            if (orderItemDigitalGood.Load(orderItemDigitalGoodId))
            {
                if (useCache) ContextCache.SetObject(key, orderItemDigitalGood);
                return orderItemDigitalGood;
            }
            return null;
        }

        /// <summary>
        /// Counts the number of OrderItemDigitalGood objects in result if retrieved using the given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the OrderItemDigitalGood objects that should be loaded.</param>
        /// <returns>The number of OrderItemDigitalGood objects matching the criteria</returns>
        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_OrderItemDigitalGoods" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection  LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + OrderItemDigitalGood.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_OrderItemDigitalGoods");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            OrderItemDigitalGoodCollection results = new OrderItemDigitalGoodCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        OrderItemDigitalGood orderItemDigitalGood = new OrderItemDigitalGood();
                        OrderItemDigitalGood.LoadDataReader(orderItemDigitalGood, dr);
                        results.Add(orderItemDigitalGood);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of OrderItemDigitalGood objects for the given DigitalGoodId in the database.
        /// <param name="digitalGoodId">The given DigitalGoodId</param>
        /// </summary>
        /// <returns>The Number of OrderItemDigitalGood objects for the given DigitalGoodId in the database.</returns>
        public static int CountForDigitalGood(Int32 digitalGoodId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_OrderItemDigitalGoods WHERE DigitalGoodId = @digitalGoodId");
            database.AddInParameter(selectCommand, "@digitalGoodId", System.Data.DbType.Int32, NullableData.DbNullify(digitalGoodId));
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects for the given DigitalGoodId from the database
        /// </summary>
        /// <param name="digitalGoodId">The given DigitalGoodId</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForDigitalGood(Int32 digitalGoodId)
        {
            return LoadForDigitalGood(digitalGoodId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects for the given DigitalGoodId from the database
        /// </summary>
        /// <param name="digitalGoodId">The given DigitalGoodId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForDigitalGood(Int32 digitalGoodId, string sortExpression)
        {
            return LoadForDigitalGood(digitalGoodId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects for the given DigitalGoodId from the database
        /// </summary>
        /// <param name="digitalGoodId">The given DigitalGoodId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForDigitalGood(Int32 digitalGoodId, int maximumRows, int startRowIndex)
        {
            return LoadForDigitalGood(digitalGoodId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects for the given DigitalGoodId from the database
        /// </summary>
        /// <param name="digitalGoodId">The given DigitalGoodId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForDigitalGood(Int32 digitalGoodId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + OrderItemDigitalGood.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_OrderItemDigitalGoods");
            selectQuery.Append(" WHERE DigitalGoodId = @digitalGoodId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@digitalGoodId", System.Data.DbType.Int32, NullableData.DbNullify(digitalGoodId));
            //EXECUTE THE COMMAND
            OrderItemDigitalGoodCollection results = new OrderItemDigitalGoodCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        OrderItemDigitalGood orderItemDigitalGood = new OrderItemDigitalGood();
                        OrderItemDigitalGood.LoadDataReader(orderItemDigitalGood, dr);
                        results.Add(orderItemDigitalGood);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of OrderItemDigitalGood objects for the given OrderItemId in the database.
        /// <param name="orderItemId">The given OrderItemId</param>
        /// </summary>
        /// <returns>The Number of OrderItemDigitalGood objects for the given OrderItemId in the database.</returns>
        public static int CountForOrderItem(Int32 orderItemId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_OrderItemDigitalGoods WHERE OrderItemId = @orderItemId");
            database.AddInParameter(selectCommand, "@orderItemId", System.Data.DbType.Int32, orderItemId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects for the given OrderItemId from the database
        /// </summary>
        /// <param name="orderItemId">The given OrderItemId</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForOrderItem(Int32 orderItemId)
        {
            return LoadForOrderItem(orderItemId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects for the given OrderItemId from the database
        /// </summary>
        /// <param name="orderItemId">The given OrderItemId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForOrderItem(Int32 orderItemId, string sortExpression)
        {
            return LoadForOrderItem(orderItemId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects for the given OrderItemId from the database
        /// </summary>
        /// <param name="orderItemId">The given OrderItemId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForOrderItem(Int32 orderItemId, int maximumRows, int startRowIndex)
        {
            return LoadForOrderItem(orderItemId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of OrderItemDigitalGood objects for the given OrderItemId from the database
        /// </summary>
        /// <param name="orderItemId">The given OrderItemId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of OrderItemDigitalGood objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderItemDigitalGoodCollection LoadForOrderItem(Int32 orderItemId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + OrderItemDigitalGood.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_OrderItemDigitalGoods");
            selectQuery.Append(" WHERE OrderItemId = @orderItemId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@orderItemId", System.Data.DbType.Int32, orderItemId);
            //EXECUTE THE COMMAND
            OrderItemDigitalGoodCollection results = new OrderItemDigitalGoodCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        OrderItemDigitalGood orderItemDigitalGood = new OrderItemDigitalGood();
                        OrderItemDigitalGood.LoadDataReader(orderItemDigitalGood, dr);
                        results.Add(orderItemDigitalGood);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Updates/Saves the given OrderItemDigitalGood object to the database.
        /// </summary>
        /// <param name="orderItemDigitalGood">The OrderItemDigitalGood object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(OrderItemDigitalGood orderItemDigitalGood) { return orderItemDigitalGood.Save(); }

    }
}
