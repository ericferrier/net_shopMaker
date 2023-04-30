//Generated by PersistableBaseGenerator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
using MakerShop.DigitalDelivery;
using MakerShop.Orders;
using MakerShop.Utility;

namespace MakerShop.Orders
{
    /// <summary>
    /// This class represents a OrderItemDigitalGood object in the database.
    /// </summary>
    public partial class OrderItemDigitalGood : IPersistable
    {

#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OrderItemDigitalGood() { }

        /// <summary>
        /// Constructor with primary key
        /// <param name="orderItemDigitalGoodId">Value of OrderItemDigitalGoodId.</param>
        /// </summary>
        public OrderItemDigitalGood(Int32 orderItemDigitalGoodId)
        {
            this.OrderItemDigitalGoodId = orderItemDigitalGoodId;
        }

        /// <summary>
        /// Returns a coma separated list of column names in this database object.
        /// </summary>
        /// <param name="prefix">Prefix to use with column names. Leave null or empty for no prefix.</param>
        /// <returns>A coman separated list of column names for this database object.</returns>
        public static string GetColumnNames(string prefix)
        {
          if (string.IsNullOrEmpty(prefix)) prefix = string.Empty;
          else prefix = prefix + ".";
          List<string> columnNames = new List<string>();
          columnNames.Add(prefix + "OrderItemDigitalGoodId");
          columnNames.Add(prefix + "OrderItemId");
          columnNames.Add(prefix + "DigitalGoodId");
          columnNames.Add(prefix + "Name");
          columnNames.Add(prefix + "ActivationDate");
          columnNames.Add(prefix + "DownloadDate");
          columnNames.Add(prefix + "SerialKeyData");
          columnNames.Add(prefix + "DownloadCount");
          return string.Join(",", columnNames.ToArray());
        }

        /// <summary>
        /// Loads the given OrderItemDigitalGood object from the given database data reader.
        /// </summary>
        /// <param name="orderItemDigitalGood">The OrderItemDigitalGood object to load.</param>
        /// <param name="dr">The database data reader to read data from.</param>
        public static void LoadDataReader(OrderItemDigitalGood orderItemDigitalGood, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA
            orderItemDigitalGood.OrderItemDigitalGoodId = dr.GetInt32(0);
            orderItemDigitalGood.OrderItemId = dr.GetInt32(1);
            orderItemDigitalGood.DigitalGoodId = NullableData.GetInt32(dr, 2);
            orderItemDigitalGood.Name = NullableData.GetString(dr, 3);
            orderItemDigitalGood.ActivationDate = LocaleHelper.ToLocalTime(NullableData.GetDateTime(dr, 4));
            orderItemDigitalGood.DownloadDate = LocaleHelper.ToLocalTime(NullableData.GetDateTime(dr, 5));
            orderItemDigitalGood.SerialKeyData = NullableData.GetString(dr, 6);
            orderItemDigitalGood.DownloadCount = NullableData.GetInt32(dr, 7);
            orderItemDigitalGood.IsDirty = false;
        }

#endregion

        private Int32 _OrderItemDigitalGoodId;
        private Int32 _OrderItemId;
        private Int32 _DigitalGoodId;
        private Int32? _DownloadCount;
        private String _Name = string.Empty;
        private DateTime _ActivationDate;
        private DateTime _DownloadDate;
        private String _SerialKeyData = string.Empty;
        private bool _IsDirty;

        /// <summary>
        /// OrderItemDigitalGoodId
        /// </summary>
        [DataObjectField(true, true, false)]
        public Int32 OrderItemDigitalGoodId
        {
            get { return this._OrderItemDigitalGoodId; }
            set
            {
                if (this._OrderItemDigitalGoodId != value)
                {
                    this._OrderItemDigitalGoodId = value;
                    this.IsDirty = true;
                    this.EnsureChildProperties();
                }
            }
        }

        /// <summary>
        /// OrderItemId
        /// </summary>
        public Int32 OrderItemId
        {
            get { return this._OrderItemId; }
            set
            {
                if (this._OrderItemId != value)
                {
                    this._OrderItemId = value;
                    this.IsDirty = true;
                    this._OrderItem = null;
                }
            }
        }

        /// <summary>
        /// DigitalGoodId
        /// </summary>
        public Int32 DigitalGoodId
        {
            get { return this._DigitalGoodId; }
            set
            {
                if (this._DigitalGoodId != value)
                {
                    this._DigitalGoodId = value;
                    this.IsDirty = true;
                    this._DigitalGood = null;
                }
            }
        }

        /// <summary>
        /// Name
        /// </summary>
        public String Name
        {
            get { return this._Name; }
            set
            {
                if (this._Name != value)
                {
                    this._Name = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ActivationDate
        /// </summary>
        public DateTime ActivationDate
        {
            get { return this._ActivationDate; }
            set
            {
                if (this._ActivationDate != value)
                {
                    this._ActivationDate = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// DownloadDate
        /// </summary>
        public DateTime DownloadDate
        {
            get { return this._DownloadDate; }
            set
            {
                if (this._DownloadDate != value)
                {
                    this._DownloadDate = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// SerialKeyData
        /// </summary>
        public String SerialKeyData
        {
            get { return this._SerialKeyData; }
            set
            {
                if (this._SerialKeyData != value)
                {
                    this._SerialKeyData = value;
                    this.IsDirty = true;
                }
            }
        }
        /// <summary>
        /// DownloadCount
        /// </summary>
        public Int32? DownloadCount
        {
            get {
                if (this._DownloadCount.HasValue)
                    return this._DownloadCount;
                else return 0;
            }
            set
            {
                if (this._DownloadCount != value)
                {
                    this._DownloadCount = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Indicates whether this OrderItemDigitalGood object has changed since it was loaded from the database.
        /// </summary>
        public bool IsDirty
        {
            get
            {
                if (this._IsDirty) return true;
                if (this.DownloadsLoaded && this.Downloads.IsDirty) return true;
                return false;
            }
            set { this._IsDirty = value; }
        }

        /// <summary>
        /// Ensures that child objects of this OrderItemDigitalGood are properly associated with this OrderItemDigitalGood object.
        /// </summary>
        public virtual void EnsureChildProperties()
        {
            if (this.DownloadsLoaded) { foreach (Download download in this.Downloads) { download.OrderItemDigitalGoodId = this.OrderItemDigitalGoodId; } }
        }

#region Parents
        private DigitalGood _DigitalGood;
        private OrderItem _OrderItem;

        /// <summary>
        /// The DigitalGood object that this OrderItemDigitalGood object is associated with
        /// </summary>
        public DigitalGood DigitalGood
        {
            get
            {
                if (!this.DigitalGoodLoaded)
                {
                    this._DigitalGood = DigitalGoodDataSource.Load(this.DigitalGoodId);
                }
                return this._DigitalGood;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool DigitalGoodLoaded { get { return ((this._DigitalGood != null) && (this._DigitalGood.DigitalGoodId == this.DigitalGoodId)); } }

        /// <summary>
        /// The OrderItem object that this OrderItemDigitalGood object is associated with
        /// </summary>
        public OrderItem OrderItem
        {
            get
            {
                if (!this.OrderItemLoaded)
                {
                    this._OrderItem = OrderItemDataSource.Load(this.OrderItemId);
                }
                return this._OrderItem;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool OrderItemLoaded { get { return ((this._OrderItem != null) && (this._OrderItem.OrderItemId == this.OrderItemId)); } }

#endregion

#region Children
        private DownloadCollection _Downloads;

        /// <summary>
        /// A collection of Download objects associated with this OrderItemDigitalGood object.
        /// </summary>
        public DownloadCollection Downloads
        {
            get
            {
                if (!this.DownloadsLoaded)
                {
                    this._Downloads = DownloadDataSource.LoadForOrderItemDigitalGood(this.OrderItemDigitalGoodId);
                }
                return this._Downloads;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool DownloadsLoaded { get { return (this._Downloads != null); } }

#endregion

        /// <summary>
        /// Deletes this OrderItemDigitalGood object from the database.
        /// </summary>
        /// <returns><b>true</b> if delete successful, <b>false</b> otherwise.</returns>
        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM ac_OrderItemDigitalGoods");
            deleteQuery.Append(" WHERE OrderItemDigitalGoodId = @orderItemDigitalGoodId");
            Database database = Token.Instance.Database;

            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {
                database.AddInParameter(deleteCommand, "@OrderItemDigitalGoodId", System.Data.DbType.Int32, this.OrderItemDigitalGoodId);
                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }

            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd(); 
            return (recordsAffected > 0);
        }


        /// <summary>
        /// Load this OrderItemDigitalGood object from the database for the given primary key.
        /// </summary>
        /// <param name="orderItemDigitalGoodId">Value of OrderItemDigitalGoodId of the object to load.</param>
        /// <returns><b>true</b> if load is successful, <b>false</b> otherwise</returns>
        public virtual bool Load(Int32 orderItemDigitalGoodId)
        {
            bool result = false;
            this.OrderItemDigitalGoodId = orderItemDigitalGoodId;
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_OrderItemDigitalGoods");
            selectQuery.Append(" WHERE OrderItemDigitalGoodId = @orderItemDigitalGoodId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@orderItemDigitalGoodId", System.Data.DbType.Int32, orderItemDigitalGoodId);
            //EXECUTE THE COMMAND
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                if (dr.Read())
                {
                    result = true;
                    LoadDataReader(this, dr);;
                }
                dr.Close();
            }
            return result;
        }

        /// <summary>
        /// Saves this OrderItemDigitalGood object to the database.
        /// </summary>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        public virtual SaveResult Save()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                bool recordExists = true;
                
                if (this.OrderItemDigitalGoodId == 0) recordExists = false;

                if (recordExists) {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM ac_OrderItemDigitalGoods");
                    selectQuery.Append(" WHERE OrderItemDigitalGoodId = @orderItemDigitalGoodId");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {
                        database.AddInParameter(selectCommand, "@OrderItemDigitalGoodId", System.Data.DbType.Int32, this.OrderItemDigitalGoodId);
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
                    updateQuery.Append("UPDATE ac_OrderItemDigitalGoods SET ");
                    updateQuery.Append("OrderItemId = @OrderItemId");
                    updateQuery.Append(", DigitalGoodId = @DigitalGoodId");
                    updateQuery.Append(", Name = @Name");
                    updateQuery.Append(", ActivationDate = @ActivationDate");
                    updateQuery.Append(", DownloadDate = @DownloadDate");
                    updateQuery.Append(", SerialKeyData = @SerialKeyData");
                    updateQuery.Append(", DownloadCount = @DownloadCount");
                    updateQuery.Append(" WHERE OrderItemDigitalGoodId = @OrderItemDigitalGoodId");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {
                        database.AddInParameter(updateCommand, "@OrderItemDigitalGoodId", System.Data.DbType.Int32, this.OrderItemDigitalGoodId);
                        database.AddInParameter(updateCommand, "@OrderItemId", System.Data.DbType.Int32, this.OrderItemId);
                        database.AddInParameter(updateCommand, "@DigitalGoodId", System.Data.DbType.Int32, NullableData.DbNullify(this.DigitalGoodId));
                        database.AddInParameter(updateCommand, "@Name", System.Data.DbType.String, NullableData.DbNullify(this.Name));
                        database.AddInParameter(updateCommand, "@ActivationDate", System.Data.DbType.DateTime, NullableData.DbNullify(LocaleHelper.FromLocalTime(this.ActivationDate)));
                        database.AddInParameter(updateCommand, "@DownloadDate", System.Data.DbType.DateTime, NullableData.DbNullify(LocaleHelper.FromLocalTime(this.DownloadDate)));
                        database.AddInParameter(updateCommand, "@SerialKeyData", System.Data.DbType.String, NullableData.DbNullify(this.SerialKeyData));
                        database.AddInParameter(updateCommand, "@DownloadCount", System.Data.DbType.Int32, this.DownloadCount);
                        //RESULT IS NUMBER OF RECORDS AFFECTED
                        result = database.ExecuteNonQuery(updateCommand);
                    }
                }
                else
                {
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO ac_OrderItemDigitalGoods (OrderItemId, DigitalGoodId, Name, ActivationDate, DownloadDate, SerialKeyData)");
                    insertQuery.Append(" VALUES (@OrderItemId, @DigitalGoodId, @Name, @ActivationDate, @DownloadDate, @SerialKeyData)");
                    insertQuery.Append("; SELECT Scope_Identity()");
                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {
                        database.AddInParameter(insertCommand, "@OrderItemDigitalGoodId", System.Data.DbType.Int32, this.OrderItemDigitalGoodId);
                        database.AddInParameter(insertCommand, "@OrderItemId", System.Data.DbType.Int32, this.OrderItemId);
                        database.AddInParameter(insertCommand, "@DigitalGoodId", System.Data.DbType.Int32, NullableData.DbNullify(this.DigitalGoodId));
                        database.AddInParameter(insertCommand, "@Name", System.Data.DbType.String, NullableData.DbNullify(this.Name));
                        database.AddInParameter(insertCommand, "@ActivationDate", System.Data.DbType.DateTime, NullableData.DbNullify(LocaleHelper.FromLocalTime(this.ActivationDate)));
                        database.AddInParameter(insertCommand, "@DownloadDate", System.Data.DbType.DateTime, NullableData.DbNullify(LocaleHelper.FromLocalTime(this.DownloadDate)));
                        database.AddInParameter(insertCommand, "@SerialKeyData", System.Data.DbType.String, NullableData.DbNullify(this.SerialKeyData));
                        database.AddInParameter(insertCommand, "@DownloadCount", System.Data.DbType.Int32, this.DownloadCount);
                        //RESULT IS NEW IDENTITY;
                        result = AlwaysConvert.ToInt(database.ExecuteScalar(insertCommand));
                        this._OrderItemDigitalGoodId = result;
                    }
                }
                this.SaveChildren();
                MakerShop.Stores.AuditEventDataSource.AuditInfoEnd(); 
                //OBJECT IS DIRTY IF NO RECORDS WERE UPDATED OR INSERTED
                this.IsDirty = (result == 0);
                if (this.IsDirty) { return SaveResult.Failed; }
                else { return (recordExists ? SaveResult.RecordUpdated : SaveResult.RecordInserted); }
            }

            //SAVE IS SUCCESSFUL IF OBJECT IS NOT DIRTY
            return SaveResult.NotDirty;
        }

        /// <summary>
        /// Saves that child objects associated with this OrderItemDigitalGood object.
        /// </summary>
        public virtual void SaveChildren()
        {
            this.EnsureChildProperties();
            if (this.DownloadsLoaded) this.Downloads.Save();
        }

     }
}
