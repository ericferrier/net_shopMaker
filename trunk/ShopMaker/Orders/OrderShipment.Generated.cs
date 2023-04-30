//Generated by PersistableBaseGenerator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
using MakerShop.Orders;
using MakerShop.Shipping;
using MakerShop.Utility;

namespace MakerShop.Orders
{
    /// <summary>
    /// This class represents a OrderShipment object in the database.
    /// </summary>
    public partial class OrderShipment : IPersistable
    {

#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OrderShipment() { }

        /// <summary>
        /// Constructor with primary key
        /// <param name="orderShipmentId">Value of OrderShipmentId.</param>
        /// </summary>
        public OrderShipment(Int32 orderShipmentId)
        {
            this.OrderShipmentId = orderShipmentId;
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
          columnNames.Add(prefix + "OrderShipmentId");
          columnNames.Add(prefix + "OrderId");
          columnNames.Add(prefix + "WarehouseId");
          columnNames.Add(prefix + "ShipToFirstName");
          columnNames.Add(prefix + "ShipToLastName");
          columnNames.Add(prefix + "ShipToCompany");
          columnNames.Add(prefix + "ShipToAddress1");
          columnNames.Add(prefix + "ShipToAddress2");
          columnNames.Add(prefix + "ShipToCity");
          columnNames.Add(prefix + "ShipToProvince");
          columnNames.Add(prefix + "ShipToPostalCode");
          columnNames.Add(prefix + "ShipToCountryCode");
          columnNames.Add(prefix + "ShipToPhone");
          columnNames.Add(prefix + "ShipToFax");
          columnNames.Add(prefix + "ShipToEmail");
          columnNames.Add(prefix + "ShipToResidence");
          columnNames.Add(prefix + "ShipMethodId");
          columnNames.Add(prefix + "ShipMethodName");
          columnNames.Add(prefix + "ShipMessage");
          columnNames.Add(prefix + "ShipDate");
          return string.Join(",", columnNames.ToArray());
        }

        /// <summary>
        /// Loads the given OrderShipment object from the given database data reader.
        /// </summary>
        /// <param name="orderShipment">The OrderShipment object to load.</param>
        /// <param name="dr">The database data reader to read data from.</param>
        public static void LoadDataReader(OrderShipment orderShipment, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA
            orderShipment.OrderShipmentId = dr.GetInt32(0);
            orderShipment.OrderId = dr.GetInt32(1);
            orderShipment.WarehouseId = NullableData.GetInt32(dr, 2);
            orderShipment.ShipToFirstName = NullableData.GetString(dr, 3);
            orderShipment.ShipToLastName = NullableData.GetString(dr, 4);
            orderShipment.ShipToCompany = NullableData.GetString(dr, 5);
            orderShipment.ShipToAddress1 = NullableData.GetString(dr, 6);
            orderShipment.ShipToAddress2 = NullableData.GetString(dr, 7);
            orderShipment.ShipToCity = NullableData.GetString(dr, 8);
            orderShipment.ShipToProvince = NullableData.GetString(dr, 9);
            orderShipment.ShipToPostalCode = NullableData.GetString(dr, 10);
            orderShipment.ShipToCountryCode = NullableData.GetString(dr, 11);
            orderShipment.ShipToPhone = NullableData.GetString(dr, 12);
            orderShipment.ShipToFax = NullableData.GetString(dr, 13);
            orderShipment.ShipToEmail = NullableData.GetString(dr, 14);
            orderShipment.ShipToResidence = NullableData.GetBoolean(dr, 15);
            orderShipment.ShipMethodId = NullableData.GetInt32(dr, 16);
            orderShipment.ShipMethodName = NullableData.GetString(dr, 17);
            orderShipment.ShipMessage = NullableData.GetString(dr, 18);
            orderShipment.ShipDate = LocaleHelper.ToLocalTime(NullableData.GetDateTime(dr, 19));
            orderShipment.IsDirty = false;
        }

#endregion

        private Int32 _OrderShipmentId;
        private Int32 _OrderId;
        private Int32 _WarehouseId;
        private String _ShipToFirstName = string.Empty;
        private String _ShipToLastName = string.Empty;
        private String _ShipToCompany = string.Empty;
        private String _ShipToAddress1 = string.Empty;
        private String _ShipToAddress2 = string.Empty;
        private String _ShipToCity = string.Empty;
        private String _ShipToProvince = string.Empty;
        private String _ShipToPostalCode = string.Empty;
        private String _ShipToCountryCode = string.Empty;
        private String _ShipToPhone = string.Empty;
        private String _ShipToFax = string.Empty;
        private String _ShipToEmail = string.Empty;
        private Boolean _ShipToResidence;
        private Int32 _ShipMethodId;
        private String _ShipMethodName = string.Empty;
        private String _ShipMessage = string.Empty;
        private DateTime _ShipDate;
        private bool _IsDirty;

        /// <summary>
        /// OrderShipmentId
        /// </summary>
        [DataObjectField(true, true, false)]
        public Int32 OrderShipmentId
        {
            get { return this._OrderShipmentId; }
            set
            {
                if (this._OrderShipmentId != value)
                {
                    this._OrderShipmentId = value;
                    this.IsDirty = true;
                    this.EnsureChildProperties();
                }
            }
        }

        /// <summary>
        /// OrderId
        /// </summary>
        public Int32 OrderId
        {
            get { return this._OrderId; }
            set
            {
                if (this._OrderId != value)
                {
                    this._OrderId = value;
                    this.IsDirty = true;
                    this._Order = null;
                }
            }
        }

        /// <summary>
        /// WarehouseId
        /// </summary>
        public Int32 WarehouseId
        {
            get { return this._WarehouseId; }
            set
            {
                if (this._WarehouseId != value)
                {
                    this._WarehouseId = value;
                    this.IsDirty = true;
                    this._Warehouse = null;
                }
            }
        }

        /// <summary>
        /// ShipToFirstName
        /// </summary>
        public String ShipToFirstName
        {
            get { return this._ShipToFirstName; }
            set
            {
                if (this._ShipToFirstName != value)
                {
                    this._ShipToFirstName = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToLastName
        /// </summary>
        public String ShipToLastName
        {
            get { return this._ShipToLastName; }
            set
            {
                if (this._ShipToLastName != value)
                {
                    this._ShipToLastName = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToCompany
        /// </summary>
        public String ShipToCompany
        {
            get { return this._ShipToCompany; }
            set
            {
                if (this._ShipToCompany != value)
                {
                    this._ShipToCompany = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToAddress1
        /// </summary>
        public String ShipToAddress1
        {
            get { return this._ShipToAddress1; }
            set
            {
                if (this._ShipToAddress1 != value)
                {
                    this._ShipToAddress1 = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToAddress2
        /// </summary>
        public String ShipToAddress2
        {
            get { return this._ShipToAddress2; }
            set
            {
                if (this._ShipToAddress2 != value)
                {
                    this._ShipToAddress2 = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToCity
        /// </summary>
        public String ShipToCity
        {
            get { return this._ShipToCity; }
            set
            {
                if (this._ShipToCity != value)
                {
                    this._ShipToCity = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToProvince
        /// </summary>
        public String ShipToProvince
        {
            get { return this._ShipToProvince; }
            set
            {
                if (this._ShipToProvince != value)
                {
                    this._ShipToProvince = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToPostalCode
        /// </summary>
        public String ShipToPostalCode
        {
            get { return this._ShipToPostalCode; }
            set
            {
                if (this._ShipToPostalCode != value)
                {
                    this._ShipToPostalCode = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToCountryCode
        /// </summary>
        public String ShipToCountryCode
        {
            get { return this._ShipToCountryCode; }
            set
            {
                if (this._ShipToCountryCode != value)
                {
                    this._ShipToCountryCode = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToPhone
        /// </summary>
        public String ShipToPhone
        {
            get { return this._ShipToPhone; }
            set
            {
                if (this._ShipToPhone != value)
                {
                    this._ShipToPhone = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToFax
        /// </summary>
        public String ShipToFax
        {
            get { return this._ShipToFax; }
            set
            {
                if (this._ShipToFax != value)
                {
                    this._ShipToFax = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToEmail
        /// </summary>
        public String ShipToEmail
        {
            get { return this._ShipToEmail; }
            set
            {
                if (this._ShipToEmail != value)
                {
                    this._ShipToEmail = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipToResidence
        /// </summary>
        public Boolean ShipToResidence
        {
            get { return this._ShipToResidence; }
            set
            {
                if (this._ShipToResidence != value)
                {
                    this._ShipToResidence = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipMethodId
        /// </summary>
        public Int32 ShipMethodId
        {
            get { return this._ShipMethodId; }
            set
            {
                if (this._ShipMethodId != value)
                {
                    this._ShipMethodId = value;
                    this.IsDirty = true;
                    this._ShipMethod = null;
                }
            }
        }

        /// <summary>
        /// ShipMethodName
        /// </summary>
        public String ShipMethodName
        {
            get { return this._ShipMethodName; }
            set
            {
                if (this._ShipMethodName != value)
                {
                    this._ShipMethodName = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipMessage
        /// </summary>
        public String ShipMessage
        {
            get { return this._ShipMessage; }
            set
            {
                if (this._ShipMessage != value)
                {
                    this._ShipMessage = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ShipDate
        /// </summary>
        public DateTime ShipDate
        {
            get { return this._ShipDate; }
            set
            {
                if (this._ShipDate != value)
                {
                    this._ShipDate = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Indicates whether this OrderShipment object has changed since it was loaded from the database.
        /// </summary>
        public bool IsDirty
        {
            get
            {
                if (this._IsDirty) return true;
                if (this.OrderItemsLoaded && this.OrderItems.IsDirty) return true;
                if (this.TrackingNumbersLoaded && this.TrackingNumbers.IsDirty) return true;
                return false;
            }
            set { this._IsDirty = value; }
        }

        /// <summary>
        /// Ensures that child objects of this OrderShipment are properly associated with this OrderShipment object.
        /// </summary>
        public virtual void EnsureChildProperties()
        {
            if (this.OrderItemsLoaded) { foreach (OrderItem orderItem in this.OrderItems) { orderItem.OrderShipmentId = this.OrderShipmentId; } }
            if (this.TrackingNumbersLoaded) { foreach (TrackingNumber trackingNumber in this.TrackingNumbers) { trackingNumber.OrderShipmentId = this.OrderShipmentId; } }
        }

#region Parents
        private Order _Order;
        private ShipMethod _ShipMethod;
        private Warehouse _Warehouse;

        /// <summary>
        /// The Order object that this OrderShipment object is associated with
        /// </summary>
        public Order Order
        {
            get
            {
                if (!this.OrderLoaded)
                {
                    this._Order = OrderDataSource.Load(this.OrderId);
                }
                return this._Order;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool OrderLoaded { get { return ((this._Order != null) && (this._Order.OrderId == this.OrderId)); } }

        /// <summary>
        /// The ShipMethod object that this OrderShipment object is associated with
        /// </summary>
        public ShipMethod ShipMethod
        {
            get
            {
                if (!this.ShipMethodLoaded)
                {
                    this._ShipMethod = ShipMethodDataSource.Load(this.ShipMethodId);
                }
                return this._ShipMethod;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool ShipMethodLoaded { get { return ((this._ShipMethod != null) && (this._ShipMethod.ShipMethodId == this.ShipMethodId)); } }

        /// <summary>
        /// The Warehouse object that this OrderShipment object is associated with
        /// </summary>
        public Warehouse Warehouse
        {
            get
            {
                if (!this.WarehouseLoaded)
                {
                    this._Warehouse = WarehouseDataSource.Load(this.WarehouseId);
                }
                return this._Warehouse;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool WarehouseLoaded { get { return ((this._Warehouse != null) && (this._Warehouse.WarehouseId == this.WarehouseId)); } }

#endregion

#region Children
        private OrderItemCollection _OrderItems;
        private TrackingNumberCollection _TrackingNumbers;

        /// <summary>
        /// A collection of OrderItem objects associated with this OrderShipment object.
        /// </summary>
        public OrderItemCollection OrderItems
        {
            get
            {
                if (!this.OrderItemsLoaded)
                {
                    this._OrderItems = OrderItemDataSource.LoadForOrderShipment(this.OrderShipmentId);
                }
                return this._OrderItems;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool OrderItemsLoaded { get { return (this._OrderItems != null); } }

        /// <summary>
        /// A collection of TrackingNumber objects associated with this OrderShipment object.
        /// </summary>
        public TrackingNumberCollection TrackingNumbers
        {
            get
            {
                if (!this.TrackingNumbersLoaded)
                {
                    this._TrackingNumbers = TrackingNumberDataSource.LoadForOrderShipment(this.OrderShipmentId);
                }
                return this._TrackingNumbers;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool TrackingNumbersLoaded { get { return (this._TrackingNumbers != null); } }

#endregion

        /// <summary>
        /// Deletes this OrderShipment object from the database.
        /// </summary>
        /// <returns><b>true</b> if delete successful, <b>false</b> otherwise.</returns>
        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM ac_OrderShipments");
            deleteQuery.Append(" WHERE OrderShipmentId = @orderShipmentId");
            Database database = Token.Instance.Database;
            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {
                database.AddInParameter(deleteCommand, "@OrderShipmentId", System.Data.DbType.Int32, this.OrderShipmentId);
                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }

            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();
            return (recordsAffected > 0);
        }


        /// <summary>
        /// Load this OrderShipment object from the database for the given primary key.
        /// </summary>
        /// <param name="orderShipmentId">Value of OrderShipmentId of the object to load.</param>
        /// <returns><b>true</b> if load is successful, <b>false</b> otherwise</returns>
        public virtual bool Load(Int32 orderShipmentId)
        {
            bool result = false;
            this.OrderShipmentId = orderShipmentId;
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_OrderShipments");
            selectQuery.Append(" WHERE OrderShipmentId = @orderShipmentId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@orderShipmentId", System.Data.DbType.Int32, orderShipmentId);
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
        /// Saves this OrderShipment object to the database.
        /// </summary>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        public virtual SaveResult Save()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                bool recordExists = true;
                
                if (this.OrderShipmentId == 0) recordExists = false;

                if (recordExists) {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM ac_OrderShipments");
                    selectQuery.Append(" WHERE OrderShipmentId = @orderShipmentId");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {
                        database.AddInParameter(selectCommand, "@OrderShipmentId", System.Data.DbType.Int32, this.OrderShipmentId);
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
                    updateQuery.Append("UPDATE ac_OrderShipments SET ");
                    updateQuery.Append("OrderId = @OrderId");
                    updateQuery.Append(", WarehouseId = @WarehouseId");
                    updateQuery.Append(", ShipToFirstName = @ShipToFirstName");
                    updateQuery.Append(", ShipToLastName = @ShipToLastName");
                    updateQuery.Append(", ShipToCompany = @ShipToCompany");
                    updateQuery.Append(", ShipToAddress1 = @ShipToAddress1");
                    updateQuery.Append(", ShipToAddress2 = @ShipToAddress2");
                    updateQuery.Append(", ShipToCity = @ShipToCity");
                    updateQuery.Append(", ShipToProvince = @ShipToProvince");
                    updateQuery.Append(", ShipToPostalCode = @ShipToPostalCode");
                    updateQuery.Append(", ShipToCountryCode = @ShipToCountryCode");
                    updateQuery.Append(", ShipToPhone = @ShipToPhone");
                    updateQuery.Append(", ShipToFax = @ShipToFax");
                    updateQuery.Append(", ShipToEmail = @ShipToEmail");
                    updateQuery.Append(", ShipToResidence = @ShipToResidence");
                    updateQuery.Append(", ShipMethodId = @ShipMethodId");
                    updateQuery.Append(", ShipMethodName = @ShipMethodName");
                    updateQuery.Append(", ShipMessage = @ShipMessage");
                    updateQuery.Append(", ShipDate = @ShipDate");
                    updateQuery.Append(" WHERE OrderShipmentId = @OrderShipmentId");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {
                        database.AddInParameter(updateCommand, "@OrderShipmentId", System.Data.DbType.Int32, this.OrderShipmentId);
                        database.AddInParameter(updateCommand, "@OrderId", System.Data.DbType.Int32, this.OrderId);
                        database.AddInParameter(updateCommand, "@WarehouseId", System.Data.DbType.Int32, NullableData.DbNullify(this.WarehouseId));
                        database.AddInParameter(updateCommand, "@ShipToFirstName", System.Data.DbType.String, NullableData.DbNullify(this.ShipToFirstName));
                        database.AddInParameter(updateCommand, "@ShipToLastName", System.Data.DbType.String, NullableData.DbNullify(this.ShipToLastName));
                        database.AddInParameter(updateCommand, "@ShipToCompany", System.Data.DbType.String, NullableData.DbNullify(this.ShipToCompany));
                        database.AddInParameter(updateCommand, "@ShipToAddress1", System.Data.DbType.String, NullableData.DbNullify(this.ShipToAddress1));
                        database.AddInParameter(updateCommand, "@ShipToAddress2", System.Data.DbType.String, NullableData.DbNullify(this.ShipToAddress2));
                        database.AddInParameter(updateCommand, "@ShipToCity", System.Data.DbType.String, NullableData.DbNullify(this.ShipToCity));
                        database.AddInParameter(updateCommand, "@ShipToProvince", System.Data.DbType.String, NullableData.DbNullify(this.ShipToProvince));
                        database.AddInParameter(updateCommand, "@ShipToPostalCode", System.Data.DbType.String, NullableData.DbNullify(this.ShipToPostalCode));
                        database.AddInParameter(updateCommand, "@ShipToCountryCode", System.Data.DbType.String, NullableData.DbNullify(this.ShipToCountryCode));
                        database.AddInParameter(updateCommand, "@ShipToPhone", System.Data.DbType.String, NullableData.DbNullify(this.ShipToPhone));
                        database.AddInParameter(updateCommand, "@ShipToFax", System.Data.DbType.String, NullableData.DbNullify(this.ShipToFax));
                        database.AddInParameter(updateCommand, "@ShipToEmail", System.Data.DbType.String, NullableData.DbNullify(this.ShipToEmail));
                        database.AddInParameter(updateCommand, "@ShipToResidence", System.Data.DbType.Boolean, NullableData.DbNullify(this.ShipToResidence));
                        database.AddInParameter(updateCommand, "@ShipMethodId", System.Data.DbType.Int32, NullableData.DbNullify(this.ShipMethodId));
                        database.AddInParameter(updateCommand, "@ShipMethodName", System.Data.DbType.String, NullableData.DbNullify(this.ShipMethodName));
                        database.AddInParameter(updateCommand, "@ShipMessage", System.Data.DbType.String, NullableData.DbNullify(this.ShipMessage));
                        database.AddInParameter(updateCommand, "@ShipDate", System.Data.DbType.DateTime, NullableData.DbNullify(LocaleHelper.FromLocalTime(this.ShipDate)));
                        //RESULT IS NUMBER OF RECORDS AFFECTED
                        result = database.ExecuteNonQuery(updateCommand);
                    }
                }
                else
                {
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO ac_OrderShipments (OrderId, WarehouseId, ShipToFirstName, ShipToLastName, ShipToCompany, ShipToAddress1, ShipToAddress2, ShipToCity, ShipToProvince, ShipToPostalCode, ShipToCountryCode, ShipToPhone, ShipToFax, ShipToEmail, ShipToResidence, ShipMethodId, ShipMethodName, ShipMessage, ShipDate)");
                    insertQuery.Append(" VALUES (@OrderId, @WarehouseId, @ShipToFirstName, @ShipToLastName, @ShipToCompany, @ShipToAddress1, @ShipToAddress2, @ShipToCity, @ShipToProvince, @ShipToPostalCode, @ShipToCountryCode, @ShipToPhone, @ShipToFax, @ShipToEmail, @ShipToResidence, @ShipMethodId, @ShipMethodName, @ShipMessage, @ShipDate)");
                    insertQuery.Append("; SELECT Scope_Identity()");
                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {
                        database.AddInParameter(insertCommand, "@OrderShipmentId", System.Data.DbType.Int32, this.OrderShipmentId);
                        database.AddInParameter(insertCommand, "@OrderId", System.Data.DbType.Int32, this.OrderId);
                        database.AddInParameter(insertCommand, "@WarehouseId", System.Data.DbType.Int32, NullableData.DbNullify(this.WarehouseId));
                        database.AddInParameter(insertCommand, "@ShipToFirstName", System.Data.DbType.String, NullableData.DbNullify(this.ShipToFirstName));
                        database.AddInParameter(insertCommand, "@ShipToLastName", System.Data.DbType.String, NullableData.DbNullify(this.ShipToLastName));
                        database.AddInParameter(insertCommand, "@ShipToCompany", System.Data.DbType.String, NullableData.DbNullify(this.ShipToCompany));
                        database.AddInParameter(insertCommand, "@ShipToAddress1", System.Data.DbType.String, NullableData.DbNullify(this.ShipToAddress1));
                        database.AddInParameter(insertCommand, "@ShipToAddress2", System.Data.DbType.String, NullableData.DbNullify(this.ShipToAddress2));
                        database.AddInParameter(insertCommand, "@ShipToCity", System.Data.DbType.String, NullableData.DbNullify(this.ShipToCity));
                        database.AddInParameter(insertCommand, "@ShipToProvince", System.Data.DbType.String, NullableData.DbNullify(this.ShipToProvince));
                        database.AddInParameter(insertCommand, "@ShipToPostalCode", System.Data.DbType.String, NullableData.DbNullify(this.ShipToPostalCode));
                        database.AddInParameter(insertCommand, "@ShipToCountryCode", System.Data.DbType.String, NullableData.DbNullify(this.ShipToCountryCode));
                        database.AddInParameter(insertCommand, "@ShipToPhone", System.Data.DbType.String, NullableData.DbNullify(this.ShipToPhone));
                        database.AddInParameter(insertCommand, "@ShipToFax", System.Data.DbType.String, NullableData.DbNullify(this.ShipToFax));
                        database.AddInParameter(insertCommand, "@ShipToEmail", System.Data.DbType.String, NullableData.DbNullify(this.ShipToEmail));
                        database.AddInParameter(insertCommand, "@ShipToResidence", System.Data.DbType.Boolean, NullableData.DbNullify(this.ShipToResidence));
                        database.AddInParameter(insertCommand, "@ShipMethodId", System.Data.DbType.Int32, NullableData.DbNullify(this.ShipMethodId));
                        database.AddInParameter(insertCommand, "@ShipMethodName", System.Data.DbType.String, NullableData.DbNullify(this.ShipMethodName));
                        database.AddInParameter(insertCommand, "@ShipMessage", System.Data.DbType.String, NullableData.DbNullify(this.ShipMessage));
                        database.AddInParameter(insertCommand, "@ShipDate", System.Data.DbType.DateTime, NullableData.DbNullify(LocaleHelper.FromLocalTime(this.ShipDate)));
                        //RESULT IS NEW IDENTITY;
                        result = AlwaysConvert.ToInt(database.ExecuteScalar(insertCommand));
                        this._OrderShipmentId = result;
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
        /// Saves that child objects associated with this OrderShipment object.
        /// </summary>
        public virtual void SaveChildren()
        {
            this.EnsureChildProperties();
            if (this.OrderItemsLoaded) this.OrderItems.Save();
            if (this.TrackingNumbersLoaded) this.TrackingNumbers.Save();
        }

     }
}
