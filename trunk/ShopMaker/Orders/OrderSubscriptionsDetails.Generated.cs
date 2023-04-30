//Generated by PersistableBaseGenerator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
using MakerShop.Messaging;
using MakerShop.Orders;
using MakerShop.Utility;

namespace MakerShop.Orders
{
    /// <summary>
    /// This class represents a OrderSubscriptionsDetails object in the database.
    /// </summary>
    public partial class OrderSubscriptionsDetails : IPersistable
    {

        #region Constructors

        public OrderSubscriptionsDetails() { }

        public OrderSubscriptionsDetails(Int32 pOrderId, Int16 pPaymentTypeId)
        {
            this.OrderId = pOrderId;
            this.PaymentTypeId = pPaymentTypeId;

        }

        public static string GetColumnNames(string prefix)
        {
            if (string.IsNullOrEmpty(prefix)) prefix = string.Empty;
            else prefix = prefix + ".";
            List<string> columnNames = new List<string>();
            columnNames.Add(prefix + "OrderId");
            columnNames.Add(prefix + "PaymentTypeId");
            columnNames.Add(prefix + "PaymentAmount");
            columnNames.Add(prefix + "ShipMethodId");
            columnNames.Add(prefix + "ShipIsVisible");
            columnNames.Add(prefix + "PaymentDays");
            columnNames.Add(prefix + "NumberOfPayments");
            columnNames.Add(prefix + "CreateDate");
            columnNames.Add(prefix + "CreateUser");
            columnNames.Add(prefix + "ChangeDate");
            columnNames.Add(prefix + "ChangeUser");


            return string.Join(",", columnNames.ToArray());
        }

        public static void LoadDataReader(OrderSubscriptionsDetails pOrderSubscriptionsDetails, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA

            pOrderSubscriptionsDetails.OrderId = dr.GetInt32(0);

            pOrderSubscriptionsDetails.PaymentTypeId = dr.GetInt16(1);

            pOrderSubscriptionsDetails.PaymentAmount = dr.GetDecimal(2);

            pOrderSubscriptionsDetails.ShipMethodId = dr.GetInt32(3);

            pOrderSubscriptionsDetails.ShipIsVisible = dr.GetBoolean(4);

            pOrderSubscriptionsDetails.PaymentDays = dr.GetInt16(5);

            pOrderSubscriptionsDetails.NumberOfPayments = dr.GetInt16(6);

            pOrderSubscriptionsDetails.CreateDate = LocaleHelper.ToLocalTime(dr.GetDateTime(7));

            pOrderSubscriptionsDetails.CreateUser = dr.GetString(8);

            pOrderSubscriptionsDetails.ChangeDate = LocaleHelper.ToLocalTime(dr.GetDateTime(9));

            pOrderSubscriptionsDetails.ChangeUser = dr.GetString(10);


            pOrderSubscriptionsDetails.IsDirty = false;
        }

        #endregion

        #region Class Data

        private bool _IsDirty;

        public bool IsDirty
        {
            get { return this._IsDirty; }
            set { this._IsDirty = value; }
        }


        private Int32 _OrderId;

        [DataObjectField(true, false, false)]
        public Int32 OrderId
        {
            get { return this._OrderId; }
            set
            {
                if (this._OrderId != value)
                {
                    this._OrderId = value;
                    this.IsDirty = true;
                }
            }
        }


        private Int16 _PaymentTypeId;

        [DataObjectField(true, false, false)]
        public Int16 PaymentTypeId
        {
            get { return this._PaymentTypeId; }
            set
            {
                if (this._PaymentTypeId != value)
                {
                    this._PaymentTypeId = value;
                    this.IsDirty = true;
                }
            }
        }


        private Decimal _PaymentAmount;

        [DataObjectField(true, false, false)]
        public Decimal PaymentAmount
        {
            get { return this._PaymentAmount; }
            set
            {
                if (this._PaymentAmount != value)
                {
                    this._PaymentAmount = value;
                    this.IsDirty = true;
                }
            }
        }


        private Int32 _ShipMethodId;

        [DataObjectField(true, false, false)]
        public Int32 ShipMethodId
        {
            get { return this._ShipMethodId; }
            set
            {
                if (this._ShipMethodId != value)
                {
                    this._ShipMethodId = value;
                    this.IsDirty = true;
                }
            }
        }


        private Boolean _ShipIsVisible;

        [DataObjectField(true, false, false)]
        public Boolean ShipIsVisible
        {
            get { return this._ShipIsVisible; }
            set
            {
                if (this._ShipIsVisible != value)
                {
                    this._ShipIsVisible = value;
                    this.IsDirty = true;
                }
            }
        }


        private Int16 _PaymentDays;

        [DataObjectField(true, false, false)]
        public Int16 PaymentDays
        {
            get { return this._PaymentDays; }
            set
            {
                if (this._PaymentDays != value)
                {
                    this._PaymentDays = value;
                    this.IsDirty = true;
                }
            }
        }


        private Int16 _NumberOfPayments;

        [DataObjectField(true, false, false)]
        public Int16 NumberOfPayments
        {
            get { return this._NumberOfPayments; }
            set
            {
                if (this._NumberOfPayments != value)
                {
                    this._NumberOfPayments = value;
                    this.IsDirty = true;
                }
            }
        }


        private DateTime _CreateDate;

        [DataObjectField(true, false, false)]
        public DateTime CreateDate
        {
            get { return this._CreateDate; }
            set
            {
                if (this._CreateDate != value)
                {
                    this._CreateDate = value;
                    this.IsDirty = true;
                }
            }
        }


        private String _CreateUser;

        [DataObjectField(true, false, false)]
        public String CreateUser
        {
            get { return this._CreateUser; }
            set
            {
                if (this._CreateUser != value)
                {
                    this._CreateUser = value;
                    this.IsDirty = true;
                }
            }
        }


        private DateTime _ChangeDate;

        [DataObjectField(true, false, false)]
        public DateTime ChangeDate
        {
            get { return this._ChangeDate; }
            set
            {
                if (this._ChangeDate != value)
                {
                    this._ChangeDate = value;
                    this.IsDirty = true;
                }
            }
        }


        private String _ChangeUser;

        [DataObjectField(true, false, false)]
        public String ChangeUser
        {
            get { return this._ChangeUser; }
            set
            {
                if (this._ChangeUser != value)
                {
                    this._ChangeUser = value;
                    this.IsDirty = true;
                }
            }
        }



        #endregion



        #region CURD

        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM xm_OrderSubscriptionsDetails");
            deleteQuery.Append(" WHERE  OrderId = @OrderId AND  PaymentTypeId = @PaymentTypeId  ");
            Database database = Token.Instance.Database;
            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {

                database.AddInParameter(deleteCommand, "@OrderId", System.Data.DbType.Int32, this.OrderId);

                database.AddInParameter(deleteCommand, "@PaymentTypeId", System.Data.DbType.Int16, this.PaymentTypeId);

                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }

            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();

            return (recordsAffected > 0);
        }

        public virtual bool Load(Int32 pOrderId, Int16 pPaymentTypeId)
        {
            bool result = false;

            this.OrderId = pOrderId;

            this.PaymentTypeId = pPaymentTypeId;


            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM xm_OrderSubscriptionsDetails");
            selectQuery.Append(" WHERE  OrderId = @OrderId AND  PaymentTypeId = @PaymentTypeId  ");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());


            database.AddInParameter(selectCommand, "@OrderId", System.Data.DbType.Int32, this.OrderId);

            database.AddInParameter(selectCommand, "@PaymentTypeId", System.Data.DbType.Int16, this.PaymentTypeId);


            //EXECUTE THE COMMAND
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                if (dr.Read())
                {
                    result = true;
                    LoadDataReader(this, dr); ;
                }
                dr.Close();
            }
            return result;
        }

        public virtual SaveResult Save()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                bool recordExists = true;

                if (recordExists)
                {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM xm_OrderSubscriptionsDetails");
                    selectQuery.Append(" WHERE  OrderId = @OrderId AND  PaymentTypeId = @PaymentTypeId ");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {

                        database.AddInParameter(selectCommand, "@OrderId", System.Data.DbType.Int32, this.OrderId);

                        database.AddInParameter(selectCommand, "@PaymentTypeId", System.Data.DbType.Int16, this.PaymentTypeId);


                        if ((int)database.ExecuteScalar(selectCommand) == 0)
                        {
                            recordExists = false;
                        }
                    }
                }

                int result = 0;
                if (recordExists)
                {
                    //UPDATE
                    StringBuilder updateQuery = new StringBuilder();
                    updateQuery.Append("UPDATE xm_OrderSubscriptionsDetails SET ");

                    updateQuery.Append("PaymentAmount = @PaymentAmount,ShipMethodId = @ShipMethodId,ShipIsVisible = @ShipIsVisible,PaymentDays = @PaymentDays,NumberOfPayments = @NumberOfPayments,ChangeDate = @ChangeDate,ChangeUser = @ChangeUser");

                    updateQuery.Append(" WHERE  OrderId = @OrderId AND  PaymentTypeId = @PaymentTypeId ");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {


                        database.AddInParameter(updateCommand, "@OrderId", System.Data.DbType.Int32, this.OrderId);

                        database.AddInParameter(updateCommand, "@PaymentTypeId", System.Data.DbType.Int16, this.PaymentTypeId);

                        database.AddInParameter(updateCommand, "@PaymentAmount", System.Data.DbType.Decimal, this.PaymentAmount);

                        database.AddInParameter(updateCommand, "@ShipMethodId", System.Data.DbType.Int32, this.ShipMethodId);

                        database.AddInParameter(updateCommand, "@ShipIsVisible", System.Data.DbType.Boolean, this.ShipIsVisible);

                        database.AddInParameter(updateCommand, "@PaymentDays", System.Data.DbType.Int16, this.PaymentDays);

                        database.AddInParameter(updateCommand, "@NumberOfPayments", System.Data.DbType.Int16, this.NumberOfPayments);

                        database.AddInParameter(updateCommand, "@ChangeDate", System.Data.DbType.DateTime, this.ChangeDate);

                        database.AddInParameter(updateCommand, "@ChangeUser", System.Data.DbType.String, this.ChangeUser);


                        //RESULT IS NUMBER OF RECORDS AFFECTED
                        result = database.ExecuteNonQuery(updateCommand);
                    }
                }
                else
                {
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO xm_OrderSubscriptionsDetails (OrderId,PaymentTypeId,PaymentAmount,ShipMethodId,ShipIsVisible,PaymentDays,NumberOfPayments,CreateDate,CreateUser,ChangeDate,ChangeUser )");
                    insertQuery.Append(" VALUES (@OrderId,@PaymentTypeId,@PaymentAmount,@ShipMethodId,@ShipIsVisible,@PaymentDays,@NumberOfPayments,@CreateDate,@CreateUser,@ChangeDate,@ChangeUser )");



                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {

                        database.AddInParameter(insertCommand, "@OrderId", System.Data.DbType.Int32, this.OrderId);

                        database.AddInParameter(insertCommand, "@PaymentTypeId", System.Data.DbType.Int16, this.PaymentTypeId);

                        database.AddInParameter(insertCommand, "@PaymentAmount", System.Data.DbType.Decimal, this.PaymentAmount);

                        database.AddInParameter(insertCommand, "@ShipMethodId", System.Data.DbType.Int32, this.ShipMethodId);

                        database.AddInParameter(insertCommand, "@ShipIsVisible", System.Data.DbType.Boolean, this.ShipIsVisible);

                        database.AddInParameter(insertCommand, "@PaymentDays", System.Data.DbType.Int16, this.PaymentDays);

                        database.AddInParameter(insertCommand, "@NumberOfPayments", System.Data.DbType.Int16, this.NumberOfPayments);

                        database.AddInParameter(insertCommand, "@CreateDate", System.Data.DbType.DateTime, this.CreateDate);

                        database.AddInParameter(insertCommand, "@CreateUser", System.Data.DbType.String, this.CreateUser);

                        database.AddInParameter(insertCommand, "@ChangeDate", System.Data.DbType.DateTime, this.ChangeDate);

                        database.AddInParameter(insertCommand, "@ChangeUser", System.Data.DbType.String, this.ChangeUser);

                        //RESULT IS NUMBER OF RECORDS AFFECTED;
                        result = database.ExecuteNonQuery(insertCommand);



                    }
                }
                MakerShop.Stores.AuditEventDataSource.AuditInfoEnd(); 
                //OBJECT IS DIRTY IF NO RECORDS WERE UPDATED OR INSERTED
                this.IsDirty = (result == 0);
                if (this.IsDirty) { return SaveResult.Failed; }
                else { return (recordExists ? SaveResult.RecordUpdated : SaveResult.RecordInserted); }
            }

            //SAVE IS SUCCESSFUL IF OBJECT IS NOT DIRTY
            return SaveResult.NotDirty;
        }

        #endregion
    }
}
