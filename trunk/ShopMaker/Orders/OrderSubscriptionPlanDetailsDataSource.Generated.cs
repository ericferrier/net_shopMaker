//Generated by DataSourceBaseGenerator_Assn

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
namespace MakerShop.Orders
{

    /// <summary>
    /// DataSource class for OrderSubscriptionsDetailsDataSource objects
    /// </summary>
    public partial class OrderSubscriptionPlanDetailsDataSource
    {
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(OrderSubscriptionPlanDetails pOrderSubscriptionPlanDetails)
        {
            return pOrderSubscriptionPlanDetails.Delete();
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 pOrderId, Int16 pPaymentTypeId)
        {
            OrderSubscriptionPlanDetails varOrderSubscriptionPlanDetails = new OrderSubscriptionPlanDetails();
            if (varOrderSubscriptionPlanDetails.Load(pOrderId, pPaymentTypeId)) return varOrderSubscriptionPlanDetails.Delete();
            return false;
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(OrderSubscriptionPlanDetails pOrderSubscriptionPlanDetails) { return pOrderSubscriptionPlanDetails.Save(); }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderSubscriptionPlanDetails Load(Int32 pOrderId, Int16 pPaymentTypeId)
        {
            OrderSubscriptionPlanDetails varOrderSubscriptionPlanDetails = new OrderSubscriptionPlanDetails();
            if (varOrderSubscriptionPlanDetails.Load(pOrderId, pPaymentTypeId)) return varOrderSubscriptionPlanDetails;
            return null;
        }

        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM xm_OrderSubscriptionPlanDetails" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderSubscriptionPlanDetailsCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderSubscriptionPlanDetailsCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderSubscriptionPlanDetailsCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static OrderSubscriptionPlanDetailsCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //DEFAULT SORT EXPRESSION
            if (string.IsNullOrEmpty(sortExpression)) sortExpression = "PaymentTypeId";
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + OrderSubscriptionPlanDetails.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM xm_OrderSubscriptionPlanDetails");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            OrderSubscriptionPlanDetailsCollection results = new OrderSubscriptionPlanDetailsCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        OrderSubscriptionPlanDetails varOrderSubscriptionPlanDetails = new OrderSubscriptionPlanDetails();
                        OrderSubscriptionPlanDetails.LoadDataReader(varOrderSubscriptionPlanDetails, dr);
                        results.Add(varOrderSubscriptionPlanDetails);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(OrderSubscriptionPlanDetails pOrderSubscriptionPlanDetails) { return pOrderSubscriptionPlanDetails.Save(); }
    }
}

