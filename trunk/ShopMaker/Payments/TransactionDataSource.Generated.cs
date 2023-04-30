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

namespace MakerShop.Payments
{
    /// <summary>
    /// DataSource class for Transaction objects
    /// </summary>
    public partial class TransactionDataSource
    {
        /// <summary>
        /// Deletes a Transaction object from the database
        /// </summary>
        /// <param name="transaction">The Transaction object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(Transaction transaction)
        {
            return transaction.Delete();
        }

        /// <summary>
        /// Deletes a Transaction object with given id from the database
        /// </summary>
        /// <param name="transactionId">Value of TransactionId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 transactionId)
        {
            Transaction transaction = new Transaction();
            if (transaction.Load(transactionId)) return transaction.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a Transaction object to the database.
        /// </summary>
        /// <param name="transaction">The Transaction object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(Transaction transaction) { return transaction.Save(); }

        /// <summary>
        /// Loads a Transaction object for given Id from the database.
        /// </summary>
        /// <param name="transactionId">Value of TransactionId of the object to load.</param>
        /// <returns>If the load is successful the newly loaded Transaction object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static Transaction Load(Int32 transactionId)
        {
            return TransactionDataSource.Load(transactionId, true);
        }

        /// <summary>
        /// Loads a Transaction object for given Id from the database.
        /// </summary>
        /// <param name="transactionId">Value of TransactionId of the object to load.</param>
        /// <param name="useCache">If true tries to load object from cache first.</param>
        /// <returns>If the load is successful the newly loaded Transaction object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static Transaction Load(Int32 transactionId, bool useCache)
        {
            if (transactionId == 0) return null;
            Transaction transaction = null;
            string key = "Transaction_" + transactionId.ToString();
            if (useCache)
            {
                transaction = ContextCache.GetObject(key) as Transaction;
                if (transaction != null) return transaction;
            }
            transaction = new Transaction();
            if (transaction.Load(transactionId))
            {
                if (useCache) ContextCache.SetObject(key, transaction);
                return transaction;
            }
            return null;
        }

        /// <summary>
        /// Counts the number of Transaction objects in result if retrieved using the given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the Transaction objects that should be loaded.</param>
        /// <returns>The number of Transaction objects matching the criteria</returns>
        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_Transactions" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of Transaction objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of Transaction objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of Transaction objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of Transaction objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection  LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //DEFAULT SORT EXPRESSION
            if (string.IsNullOrEmpty(sortExpression)) sortExpression = "TransactionDate";
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + Transaction.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_Transactions");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            TransactionCollection results = new TransactionCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        Transaction transaction = new Transaction();
                        Transaction.LoadDataReader(transaction, dr);
                        results.Add(transaction);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of Transaction objects for the given PaymentGatewayId in the database.
        /// <param name="paymentGatewayId">The given PaymentGatewayId</param>
        /// </summary>
        /// <returns>The Number of Transaction objects for the given PaymentGatewayId in the database.</returns>
        public static int CountForPaymentGateway(Int32 paymentGatewayId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_Transactions WHERE PaymentGatewayId = @paymentGatewayId");
            database.AddInParameter(selectCommand, "@paymentGatewayId", System.Data.DbType.Int32, NullableData.DbNullify(paymentGatewayId));
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of Transaction objects for the given PaymentGatewayId from the database
        /// </summary>
        /// <param name="paymentGatewayId">The given PaymentGatewayId</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForPaymentGateway(Int32 paymentGatewayId)
        {
            return LoadForPaymentGateway(paymentGatewayId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of Transaction objects for the given PaymentGatewayId from the database
        /// </summary>
        /// <param name="paymentGatewayId">The given PaymentGatewayId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForPaymentGateway(Int32 paymentGatewayId, string sortExpression)
        {
            return LoadForPaymentGateway(paymentGatewayId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of Transaction objects for the given PaymentGatewayId from the database
        /// </summary>
        /// <param name="paymentGatewayId">The given PaymentGatewayId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForPaymentGateway(Int32 paymentGatewayId, int maximumRows, int startRowIndex)
        {
            return LoadForPaymentGateway(paymentGatewayId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of Transaction objects for the given PaymentGatewayId from the database
        /// </summary>
        /// <param name="paymentGatewayId">The given PaymentGatewayId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForPaymentGateway(Int32 paymentGatewayId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //DEFAULT SORT EXPRESSION
            if (string.IsNullOrEmpty(sortExpression)) sortExpression = "TransactionDate";
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + Transaction.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_Transactions");
            selectQuery.Append(" WHERE PaymentGatewayId = @paymentGatewayId");
            selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@paymentGatewayId", System.Data.DbType.Int32, NullableData.DbNullify(paymentGatewayId));
            //EXECUTE THE COMMAND
            TransactionCollection results = new TransactionCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        Transaction transaction = new Transaction();
                        Transaction.LoadDataReader(transaction, dr);
                        results.Add(transaction);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of Transaction objects for the given PaymentId in the database.
        /// <param name="paymentId">The given PaymentId</param>
        /// </summary>
        /// <returns>The Number of Transaction objects for the given PaymentId in the database.</returns>
        public static int CountForPayment(Int32 paymentId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_Transactions WHERE PaymentId = @paymentId");
            database.AddInParameter(selectCommand, "@paymentId", System.Data.DbType.Int32, paymentId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of Transaction objects for the given PaymentId from the database
        /// </summary>
        /// <param name="paymentId">The given PaymentId</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForPayment(Int32 paymentId)
        {
            return LoadForPayment(paymentId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of Transaction objects for the given PaymentId from the database
        /// </summary>
        /// <param name="paymentId">The given PaymentId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForPayment(Int32 paymentId, string sortExpression)
        {
            return LoadForPayment(paymentId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of Transaction objects for the given PaymentId from the database
        /// </summary>
        /// <param name="paymentId">The given PaymentId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForPayment(Int32 paymentId, int maximumRows, int startRowIndex)
        {
            return LoadForPayment(paymentId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of Transaction objects for the given PaymentId from the database
        /// </summary>
        /// <param name="paymentId">The given PaymentId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Transaction objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TransactionCollection LoadForPayment(Int32 paymentId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //DEFAULT SORT EXPRESSION
            if (string.IsNullOrEmpty(sortExpression)) sortExpression = "TransactionDate";
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + Transaction.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_Transactions");
            selectQuery.Append(" WHERE PaymentId = @paymentId");
            selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@paymentId", System.Data.DbType.Int32, paymentId);
            //EXECUTE THE COMMAND
            TransactionCollection results = new TransactionCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        Transaction transaction = new Transaction();
                        Transaction.LoadDataReader(transaction, dr);
                        results.Add(transaction);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Updates/Saves the given Transaction object to the database.
        /// </summary>
        /// <param name="transaction">The Transaction object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(Transaction transaction) { return transaction.Save(); }

    }
}
