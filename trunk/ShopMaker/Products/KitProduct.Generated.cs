//Generated by PersistableBaseGenerator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
using MakerShop.Products;
using MakerShop.Utility;

namespace MakerShop.Products
{
    /// <summary>
    /// This class represents a KitProduct object in the database.
    /// </summary>
    public partial class KitProduct : IPersistable
    {

#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public KitProduct() { }

        /// <summary>
        /// Constructor with primary key
        /// <param name="kitProductId">Value of KitProductId.</param>
        /// </summary>
        public KitProduct(Int32 kitProductId)
        {
            this.KitProductId = kitProductId;
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
          columnNames.Add(prefix + "KitProductId");
          columnNames.Add(prefix + "KitComponentId");
          columnNames.Add(prefix + "ProductId");
          columnNames.Add(prefix + "OptionList");
          columnNames.Add(prefix + "Name");
          columnNames.Add(prefix + "Quantity");
          columnNames.Add(prefix + "Price");
          columnNames.Add(prefix + "PriceModeId");
          columnNames.Add(prefix + "Weight");
          columnNames.Add(prefix + "WeightModeId");
          columnNames.Add(prefix + "IsSelected");
          columnNames.Add(prefix + "OrderBy");
          return string.Join(",", columnNames.ToArray());
        }

        /// <summary>
        /// Loads the given KitProduct object from the given database data reader.
        /// </summary>
        /// <param name="kitProduct">The KitProduct object to load.</param>
        /// <param name="dr">The database data reader to read data from.</param>
        public static void LoadDataReader(KitProduct kitProduct, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA
            kitProduct.KitProductId = dr.GetInt32(0);
            kitProduct.KitComponentId = dr.GetInt32(1);
            kitProduct.ProductId = dr.GetInt32(2);
            kitProduct.OptionList = NullableData.GetString(dr, 3);
            kitProduct.Name = dr.GetString(4);
            kitProduct.Quantity = dr.GetInt16(5);
            kitProduct.Price = dr.GetDecimal(6);
            kitProduct.PriceModeId = dr.GetByte(7);
            kitProduct.Weight = dr.GetDecimal(8);
            kitProduct.WeightModeId = dr.GetByte(9);
            kitProduct.IsSelected = dr.GetBoolean(10);
            kitProduct.OrderBy = dr.GetInt16(11);
            kitProduct.IsDirty = false;
        }

#endregion

        private Int32 _KitProductId;
        private Int32 _KitComponentId;
        private Int32 _ProductId;
        private String _OptionList = string.Empty;
        private String _Name = string.Empty;
        private Int16 _Quantity;
        private LSDecimal _Price;
        private Byte _PriceModeId;
        private LSDecimal _Weight;
        private Byte _WeightModeId;
        private Boolean _IsSelected;
        private Int16 _OrderBy = -1;
        private bool _IsDirty;

        /// <summary>
        /// KitProductId
        /// </summary>
        [DataObjectField(true, true, false)]
        public Int32 KitProductId
        {
            get { return this._KitProductId; }
            set
            {
                if (this._KitProductId != value)
                {
                    this._KitProductId = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// KitComponentId
        /// </summary>
        public Int32 KitComponentId
        {
            get { return this._KitComponentId; }
            set
            {
                if (this._KitComponentId != value)
                {
                    this._KitComponentId = value;
                    this.IsDirty = true;
                    this._KitComponent = null;
                }
            }
        }

        /// <summary>
        /// ProductId
        /// </summary>
        public Int32 ProductId
        {
            get { return this._ProductId; }
            set
            {
                if (this._ProductId != value)
                {
                    this._ProductId = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// OptionList
        /// </summary>
        public String OptionList
        {
            get { return this._OptionList; }
            set
            {
                if (this._OptionList != value)
                {
                    this._OptionList = value;
                    this.IsDirty = true;
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
        /// Quantity
        /// </summary>
        public Int16 Quantity
        {
            get { return this._Quantity; }
            set
            {
                if (this._Quantity != value)
                {
                    this._Quantity = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Price
        /// </summary>
        public LSDecimal Price
        {
            get { return this._Price; }
            set
            {
                if (this._Price != value)
                {
                    this._Price = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// PriceModeId
        /// </summary>
        public Byte PriceModeId
        {
            get { return this._PriceModeId; }
            set
            {
                if (this._PriceModeId != value)
                {
                    this._PriceModeId = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Weight
        /// </summary>
        public LSDecimal Weight
        {
            get { return this._Weight; }
            set
            {
                if (this._Weight != value)
                {
                    this._Weight = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// WeightModeId
        /// </summary>
        public Byte WeightModeId
        {
            get { return this._WeightModeId; }
            set
            {
                if (this._WeightModeId != value)
                {
                    this._WeightModeId = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// IsSelected
        /// </summary>
        public Boolean IsSelected
        {
            get { return this._IsSelected; }
            set
            {
                if (this._IsSelected != value)
                {
                    this._IsSelected = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// OrderBy
        /// </summary>
        public Int16 OrderBy
        {
            get { return this._OrderBy; }
            set
            {
                if (this._OrderBy != value)
                {
                    this._OrderBy = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Indicates whether this KitProduct object has changed since it was loaded from the database.
        /// </summary>
        public bool IsDirty
        {
            get { return this._IsDirty; }
            set { this._IsDirty = value; }
        }

#region Parents
        private KitComponent _KitComponent;

        /// <summary>
        /// The KitComponent object that this KitProduct object is associated with
        /// </summary>
        public KitComponent KitComponent
        {
            get
            {
                if (!this.KitComponentLoaded)
                {
                    this._KitComponent = KitComponentDataSource.Load(this.KitComponentId);
                }
                return this._KitComponent;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool KitComponentLoaded { get { return ((this._KitComponent != null) && (this._KitComponent.KitComponentId == this.KitComponentId)); } }

#endregion

        /// <summary>
        /// Deletes this KitProduct object from the database.
        /// </summary>
        /// <returns><b>true</b> if delete successful, <b>false</b> otherwise.</returns>
        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM ac_KitProducts");
            deleteQuery.Append(" WHERE KitProductId = @kitProductId");
            Database database = Token.Instance.Database;

            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null);
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {
                database.AddInParameter(deleteCommand, "@KitProductId", System.Data.DbType.Int32, this.KitProductId);
                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }

            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();
            return (recordsAffected > 0);
        }


        /// <summary>
        /// Load this KitProduct object from the database for the given primary key.
        /// </summary>
        /// <param name="kitProductId">Value of KitProductId of the object to load.</param>
        /// <returns><b>true</b> if load is successful, <b>false</b> otherwise</returns>
        public virtual bool Load(Int32 kitProductId)
        {
            bool result = false;
            this.KitProductId = kitProductId;
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_KitProducts");
            selectQuery.Append(" WHERE KitProductId = @kitProductId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@kitProductId", System.Data.DbType.Int32, kitProductId);
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
        /// Saves this KitProduct object to the database.
        /// </summary>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        public virtual SaveResult Save()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                bool recordExists = true;
                
                if (this.KitProductId == 0) recordExists = false;

                if (this.OrderBy < 0) this.OrderBy = KitProductDataSource.GetNextOrderBy(this.KitComponentId);

                if (recordExists) {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM ac_KitProducts");
                    selectQuery.Append(" WHERE KitProductId = @kitProductId");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {
                        database.AddInParameter(selectCommand, "@KitProductId", System.Data.DbType.Int32, this.KitProductId);
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
                    updateQuery.Append("UPDATE ac_KitProducts SET ");
                    updateQuery.Append("KitComponentId = @KitComponentId");
                    updateQuery.Append(", ProductId = @ProductId");
                    updateQuery.Append(", OptionList = @OptionList");
                    updateQuery.Append(", Name = @Name");
                    updateQuery.Append(", Quantity = @Quantity");
                    updateQuery.Append(", Price = @Price");
                    updateQuery.Append(", PriceModeId = @PriceModeId");
                    updateQuery.Append(", Weight = @Weight");
                    updateQuery.Append(", WeightModeId = @WeightModeId");
                    updateQuery.Append(", IsSelected = @IsSelected");
                    updateQuery.Append(", OrderBy = @OrderBy");
                    updateQuery.Append(" WHERE KitProductId = @KitProductId");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {
                        database.AddInParameter(updateCommand, "@KitProductId", System.Data.DbType.Int32, this.KitProductId);
                        database.AddInParameter(updateCommand, "@KitComponentId", System.Data.DbType.Int32, this.KitComponentId);
                        database.AddInParameter(updateCommand, "@ProductId", System.Data.DbType.Int32, this.ProductId);
                        database.AddInParameter(updateCommand, "@OptionList", System.Data.DbType.String, NullableData.DbNullify(this.OptionList));
                        database.AddInParameter(updateCommand, "@Name", System.Data.DbType.String, this.Name);
                        database.AddInParameter(updateCommand, "@Quantity", System.Data.DbType.Int16, this.Quantity);
                        database.AddInParameter(updateCommand, "@Price", System.Data.DbType.Decimal, this.Price);
                        database.AddInParameter(updateCommand, "@PriceModeId", System.Data.DbType.Byte, this.PriceModeId);
                        database.AddInParameter(updateCommand, "@Weight", System.Data.DbType.Decimal, this.Weight);
                        database.AddInParameter(updateCommand, "@WeightModeId", System.Data.DbType.Byte, this.WeightModeId);
                        database.AddInParameter(updateCommand, "@IsSelected", System.Data.DbType.Boolean, this.IsSelected);
                        database.AddInParameter(updateCommand, "@OrderBy", System.Data.DbType.Int16, this.OrderBy);
                        //RESULT IS NUMBER OF RECORDS AFFECTED
                        result = database.ExecuteNonQuery(updateCommand);
                    }
                }
                else
                {
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO ac_KitProducts (KitComponentId, ProductId, OptionList, Name, Quantity, Price, PriceModeId, Weight, WeightModeId, IsSelected, OrderBy)");
                    insertQuery.Append(" VALUES (@KitComponentId, @ProductId, @OptionList, @Name, @Quantity, @Price, @PriceModeId, @Weight, @WeightModeId, @IsSelected, @OrderBy)");
                    insertQuery.Append("; SELECT Scope_Identity()");
                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {
                        database.AddInParameter(insertCommand, "@KitProductId", System.Data.DbType.Int32, this.KitProductId);
                        database.AddInParameter(insertCommand, "@KitComponentId", System.Data.DbType.Int32, this.KitComponentId);
                        database.AddInParameter(insertCommand, "@ProductId", System.Data.DbType.Int32, this.ProductId);
                        database.AddInParameter(insertCommand, "@OptionList", System.Data.DbType.String, NullableData.DbNullify(this.OptionList));
                        database.AddInParameter(insertCommand, "@Name", System.Data.DbType.String, this.Name);
                        database.AddInParameter(insertCommand, "@Quantity", System.Data.DbType.Int16, this.Quantity);
                        database.AddInParameter(insertCommand, "@Price", System.Data.DbType.Decimal, this.Price);
                        database.AddInParameter(insertCommand, "@PriceModeId", System.Data.DbType.Byte, this.PriceModeId);
                        database.AddInParameter(insertCommand, "@Weight", System.Data.DbType.Decimal, this.Weight);
                        database.AddInParameter(insertCommand, "@WeightModeId", System.Data.DbType.Byte, this.WeightModeId);
                        database.AddInParameter(insertCommand, "@IsSelected", System.Data.DbType.Boolean, this.IsSelected);
                        database.AddInParameter(insertCommand, "@OrderBy", System.Data.DbType.Int16, this.OrderBy);
                        //RESULT IS NEW IDENTITY;
                        result = AlwaysConvert.ToInt(database.ExecuteScalar(insertCommand));
                        this._KitProductId = result;
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

     }
}
