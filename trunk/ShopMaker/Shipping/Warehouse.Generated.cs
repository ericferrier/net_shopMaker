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
using MakerShop.Products;
using MakerShop.Shipping;
using MakerShop.Stores;
using MakerShop.Utility;

namespace MakerShop.Shipping
{
    /// <summary>
    /// This class represents a Warehouse object in the database.
    /// </summary>
    public partial class Warehouse : IPersistable
    {

#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Warehouse() { }

        /// <summary>
        /// Constructor with primary key
        /// <param name="warehouseId">Value of WarehouseId.</param>
        /// </summary>
        public Warehouse(Int32 warehouseId)
        {
            this.WarehouseId = warehouseId;
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
          columnNames.Add(prefix + "WarehouseId");
          columnNames.Add(prefix + "StoreId");
          columnNames.Add(prefix + "Name");
          columnNames.Add(prefix + "Address1");
          columnNames.Add(prefix + "Address2");
          columnNames.Add(prefix + "City");
          columnNames.Add(prefix + "Province");
          columnNames.Add(prefix + "PostalCode");
          columnNames.Add(prefix + "CountryCode");
          columnNames.Add(prefix + "Phone");
          columnNames.Add(prefix + "Fax");
          columnNames.Add(prefix + "Email");
          return string.Join(",", columnNames.ToArray());
        }

        /// <summary>
        /// Loads the given Warehouse object from the given database data reader.
        /// </summary>
        /// <param name="warehouse">The Warehouse object to load.</param>
        /// <param name="dr">The database data reader to read data from.</param>
        public static void LoadDataReader(Warehouse warehouse, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA
            warehouse.WarehouseId = dr.GetInt32(0);
            warehouse.StoreId = dr.GetInt32(1);
            warehouse.Name = dr.GetString(2);
            warehouse.Address1 = NullableData.GetString(dr, 3);
            warehouse.Address2 = NullableData.GetString(dr, 4);
            warehouse.City = NullableData.GetString(dr, 5);
            warehouse.Province = NullableData.GetString(dr, 6);
            warehouse.PostalCode = NullableData.GetString(dr, 7);
            warehouse.CountryCode = NullableData.GetString(dr, 8);
            warehouse.Phone = NullableData.GetString(dr, 9);
            warehouse.Fax = NullableData.GetString(dr, 10);
            warehouse.Email = NullableData.GetString(dr, 11);
            warehouse.IsDirty = false;
        }

#endregion

        private Int32 _WarehouseId;
        private Int32 _StoreId;
        private String _Name = string.Empty;
        private String _Address1 = string.Empty;
        private String _Address2 = string.Empty;
        private String _City = string.Empty;
        private String _Province = string.Empty;
        private String _PostalCode = string.Empty;
        private String _CountryCode = string.Empty;
        private String _Phone = string.Empty;
        private String _Fax = string.Empty;
        private String _Email = string.Empty;
        private bool _IsDirty;

        /// <summary>
        /// WarehouseId
        /// </summary>
        [DataObjectField(true, true, false)]
        public Int32 WarehouseId
        {
            get { return this._WarehouseId; }
            set
            {
                if (this._WarehouseId != value)
                {
                    this._WarehouseId = value;
                    this.IsDirty = true;
                    this.EnsureChildProperties();
                }
            }
        }

        /// <summary>
        /// StoreId
        /// </summary>
        public Int32 StoreId
        {
            get { return this._StoreId; }
            set
            {
                if (this._StoreId != value)
                {
                    this._StoreId = value;
                    this.IsDirty = true;
                    this._Store = null;
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
        /// Address1
        /// </summary>
        public String Address1
        {
            get { return this._Address1; }
            set
            {
                if (this._Address1 != value)
                {
                    this._Address1 = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Address2
        /// </summary>
        public String Address2
        {
            get { return this._Address2; }
            set
            {
                if (this._Address2 != value)
                {
                    this._Address2 = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// City
        /// </summary>
        public String City
        {
            get { return this._City; }
            set
            {
                if (this._City != value)
                {
                    this._City = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Province
        /// </summary>
        public String Province
        {
            get { return this._Province; }
            set
            {
                if (this._Province != value)
                {
                    this._Province = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// PostalCode
        /// </summary>
        public String PostalCode
        {
            get { return this._PostalCode; }
            set
            {
                if (this._PostalCode != value)
                {
                    this._PostalCode = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// CountryCode
        /// </summary>
        public String CountryCode
        {
            get { return this._CountryCode; }
            set
            {
                if (this._CountryCode != value)
                {
                    this._CountryCode = value;
                    this.IsDirty = true;
                    this._Country = null;
                }
            }
        }

        /// <summary>
        /// Phone
        /// </summary>
        public String Phone
        {
            get { return this._Phone; }
            set
            {
                if (this._Phone != value)
                {
                    this._Phone = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Fax
        /// </summary>
        public String Fax
        {
            get { return this._Fax; }
            set
            {
                if (this._Fax != value)
                {
                    this._Fax = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        public String Email
        {
            get { return this._Email; }
            set
            {
                if (this._Email != value)
                {
                    this._Email = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Indicates whether this Warehouse object has changed since it was loaded from the database.
        /// </summary>
        public bool IsDirty
        {
            get
            {
                if (this._IsDirty) return true;
                if (this.BasketShipmentsLoaded && this.BasketShipments.IsDirty) return true;
                if (this.OrderShipmentsLoaded && this.OrderShipments.IsDirty) return true;
                if (this.ProductsLoaded && this.Products.IsDirty) return true;
                if (this.ShipMethodWarehousesLoaded && this.ShipMethodWarehouses.IsDirty) return true;
                return false;
            }
            set { this._IsDirty = value; }
        }

        /// <summary>
        /// Ensures that child objects of this Warehouse are properly associated with this Warehouse object.
        /// </summary>
        public virtual void EnsureChildProperties()
        {
            if (this.BasketShipmentsLoaded) { foreach (BasketShipment basketShipment in this.BasketShipments) { basketShipment.WarehouseId = this.WarehouseId; } }
            if (this.OrderShipmentsLoaded) { foreach (OrderShipment orderShipment in this.OrderShipments) { orderShipment.WarehouseId = this.WarehouseId; } }
            if (this.ProductsLoaded) { foreach (Product product in this.Products) { product.WarehouseId = this.WarehouseId; } }
            if (this.ShipMethodWarehousesLoaded) { foreach (ShipMethodWarehouse shipMethodWarehouse in this.ShipMethodWarehouses) { shipMethodWarehouse.WarehouseId = this.WarehouseId; } }
        }

#region Parents
        private Country _Country;
        private Store _Store;

        /// <summary>
        /// The Country object that this Warehouse object is associated with
        /// </summary>
        public Country Country
        {
            get
            {
                if (!this.CountryLoaded)
                {
                    this._Country = CountryDataSource.Load(this.CountryCode);
                }
                return this._Country;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool CountryLoaded { get { return ((this._Country != null) && (this._Country.CountryCode == this.CountryCode)); } }

        /// <summary>
        /// The Store object that this Warehouse object is associated with
        /// </summary>
        public Store Store
        {
            get
            {
                if (!this.StoreLoaded)
                {
                    this._Store = StoreDataSource.Load(this.StoreId);
                }
                return this._Store;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool StoreLoaded { get { return ((this._Store != null) && (this._Store.StoreId == this.StoreId)); } }

#endregion

#region Children
        private BasketShipmentCollection _BasketShipments;
        private OrderShipmentCollection _OrderShipments;
        private ProductCollection _Products;

        /// <summary>
        /// A collection of BasketShipment objects associated with this Warehouse object.
        /// </summary>
        public BasketShipmentCollection BasketShipments
        {
            get
            {
                if (!this.BasketShipmentsLoaded)
                {
                    this._BasketShipments = BasketShipmentDataSource.LoadForWarehouse(this.WarehouseId);
                }
                return this._BasketShipments;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool BasketShipmentsLoaded { get { return (this._BasketShipments != null); } }

        /// <summary>
        /// A collection of OrderShipment objects associated with this Warehouse object.
        /// </summary>
        public OrderShipmentCollection OrderShipments
        {
            get
            {
                if (!this.OrderShipmentsLoaded)
                {
                    this._OrderShipments = OrderShipmentDataSource.LoadForWarehouse(this.WarehouseId);
                }
                return this._OrderShipments;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool OrderShipmentsLoaded { get { return (this._OrderShipments != null); } }

        /// <summary>
        /// A collection of Product objects associated with this Warehouse object.
        /// </summary>
        public ProductCollection Products
        {
            get
            {
                if (!this.ProductsLoaded)
                {
                    this._Products = ProductDataSource.LoadForWarehouse(this.WarehouseId);
                }
                return this._Products;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool ProductsLoaded { get { return (this._Products != null); } }

#endregion

#region Associations
        private ShipMethodWarehouseCollection _ShipMethodWarehouses;

        /// <summary>
        /// A collection of ShipMethodWarehouse objects associated with this Warehouse object.
        /// </summary>
        public ShipMethodWarehouseCollection ShipMethodWarehouses
        {
            get
            {
                if (!this.ShipMethodWarehousesLoaded)
                {
                    this._ShipMethodWarehouses = ShipMethodWarehouseDataSource.LoadForWarehouse(this.WarehouseId);
                }
                return this._ShipMethodWarehouses;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool ShipMethodWarehousesLoaded { get { return (this._ShipMethodWarehouses != null); } }
#endregion

        /// <summary>
        /// Deletes this Warehouse object from the database.
        /// </summary>
        /// <returns><b>true</b> if delete successful, <b>false</b> otherwise.</returns>
        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM ac_Warehouses");
            deleteQuery.Append(" WHERE WarehouseId = @warehouseId");
            Database database = Token.Instance.Database;

            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null);
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {
                database.AddInParameter(deleteCommand, "@WarehouseId", System.Data.DbType.Int32, this.WarehouseId);
                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }
            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();

            return (recordsAffected > 0);
        }


        /// <summary>
        /// Load this Warehouse object from the database for the given primary key.
        /// </summary>
        /// <param name="warehouseId">Value of WarehouseId of the object to load.</param>
        /// <returns><b>true</b> if load is successful, <b>false</b> otherwise</returns>
        public virtual bool Load(Int32 warehouseId)
        {
            bool result = false;
            this.WarehouseId = warehouseId;
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_Warehouses");
            selectQuery.Append(" WHERE WarehouseId = @warehouseId");
            selectQuery.Append(" AND StoreId = @storeId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@warehouseId", System.Data.DbType.Int32, warehouseId);
            database.AddInParameter(selectCommand, "@storeId", System.Data.DbType.Int32, Token.Instance.StoreId);
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
        /// Saves this Warehouse object to the database.
        /// </summary>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        public virtual SaveResult Save()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                bool recordExists = true;
                
                //SET EMPTY STOREID TO CURRENT CONTEXT
                if (this.StoreId == 0) this.StoreId = Token.Instance.StoreId;
                if (this.WarehouseId == 0) recordExists = false;

                if (recordExists) {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM ac_Warehouses");
                    selectQuery.Append(" WHERE WarehouseId = @warehouseId");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {
                        database.AddInParameter(selectCommand, "@WarehouseId", System.Data.DbType.Int32, this.WarehouseId);
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
                    updateQuery.Append("UPDATE ac_Warehouses SET ");
                    updateQuery.Append("StoreId = @StoreId");
                    updateQuery.Append(", Name = @Name");
                    updateQuery.Append(", Address1 = @Address1");
                    updateQuery.Append(", Address2 = @Address2");
                    updateQuery.Append(", City = @City");
                    updateQuery.Append(", Province = @Province");
                    updateQuery.Append(", PostalCode = @PostalCode");
                    updateQuery.Append(", CountryCode = @CountryCode");
                    updateQuery.Append(", Phone = @Phone");
                    updateQuery.Append(", Fax = @Fax");
                    updateQuery.Append(", Email = @Email");
                    updateQuery.Append(" WHERE WarehouseId = @WarehouseId");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {
                        database.AddInParameter(updateCommand, "@WarehouseId", System.Data.DbType.Int32, this.WarehouseId);
                        database.AddInParameter(updateCommand, "@StoreId", System.Data.DbType.Int32, this.StoreId);
                        database.AddInParameter(updateCommand, "@Name", System.Data.DbType.String, this.Name);
                        database.AddInParameter(updateCommand, "@Address1", System.Data.DbType.String, NullableData.DbNullify(this.Address1));
                        database.AddInParameter(updateCommand, "@Address2", System.Data.DbType.String, NullableData.DbNullify(this.Address2));
                        database.AddInParameter(updateCommand, "@City", System.Data.DbType.String, NullableData.DbNullify(this.City));
                        database.AddInParameter(updateCommand, "@Province", System.Data.DbType.String, NullableData.DbNullify(this.Province));
                        database.AddInParameter(updateCommand, "@PostalCode", System.Data.DbType.String, NullableData.DbNullify(this.PostalCode));
                        database.AddInParameter(updateCommand, "@CountryCode", System.Data.DbType.String, NullableData.DbNullify(this.CountryCode));
                        database.AddInParameter(updateCommand, "@Phone", System.Data.DbType.String, NullableData.DbNullify(this.Phone));
                        database.AddInParameter(updateCommand, "@Fax", System.Data.DbType.String, NullableData.DbNullify(this.Fax));
                        database.AddInParameter(updateCommand, "@Email", System.Data.DbType.String, NullableData.DbNullify(this.Email));
                        //RESULT IS NUMBER OF RECORDS AFFECTED
                        result = database.ExecuteNonQuery(updateCommand);
                    }
                }
                else
                {
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO ac_Warehouses (StoreId, Name, Address1, Address2, City, Province, PostalCode, CountryCode, Phone, Fax, Email)");
                    insertQuery.Append(" VALUES (@StoreId, @Name, @Address1, @Address2, @City, @Province, @PostalCode, @CountryCode, @Phone, @Fax, @Email)");
                    insertQuery.Append("; SELECT Scope_Identity()");
                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {
                        database.AddInParameter(insertCommand, "@WarehouseId", System.Data.DbType.Int32, this.WarehouseId);
                        database.AddInParameter(insertCommand, "@StoreId", System.Data.DbType.Int32, this.StoreId);
                        database.AddInParameter(insertCommand, "@Name", System.Data.DbType.String, this.Name);
                        database.AddInParameter(insertCommand, "@Address1", System.Data.DbType.String, NullableData.DbNullify(this.Address1));
                        database.AddInParameter(insertCommand, "@Address2", System.Data.DbType.String, NullableData.DbNullify(this.Address2));
                        database.AddInParameter(insertCommand, "@City", System.Data.DbType.String, NullableData.DbNullify(this.City));
                        database.AddInParameter(insertCommand, "@Province", System.Data.DbType.String, NullableData.DbNullify(this.Province));
                        database.AddInParameter(insertCommand, "@PostalCode", System.Data.DbType.String, NullableData.DbNullify(this.PostalCode));
                        database.AddInParameter(insertCommand, "@CountryCode", System.Data.DbType.String, NullableData.DbNullify(this.CountryCode));
                        database.AddInParameter(insertCommand, "@Phone", System.Data.DbType.String, NullableData.DbNullify(this.Phone));
                        database.AddInParameter(insertCommand, "@Fax", System.Data.DbType.String, NullableData.DbNullify(this.Fax));
                        database.AddInParameter(insertCommand, "@Email", System.Data.DbType.String, NullableData.DbNullify(this.Email));
                        //RESULT IS NEW IDENTITY;
                        result = AlwaysConvert.ToInt(database.ExecuteScalar(insertCommand));
                        this._WarehouseId = result;
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
        /// Saves that child objects associated with this Warehouse object.
        /// </summary>
        public virtual void SaveChildren()
        {
            this.EnsureChildProperties();
            if (this.BasketShipmentsLoaded) this.BasketShipments.Save();
            if (this.OrderShipmentsLoaded) this.OrderShipments.Save();
            if (this.ProductsLoaded) this.Products.Save();
            if (this.ShipMethodWarehousesLoaded) this.ShipMethodWarehouses.Save();
        }

     }
}
