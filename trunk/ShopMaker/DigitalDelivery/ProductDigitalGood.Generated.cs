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
using MakerShop.Products;
using MakerShop.Utility;

namespace MakerShop.DigitalDelivery
{
    /// <summary>
    /// This class represents a ProductDigitalGood object in the database.
    /// </summary>
    public partial class ProductDigitalGood : IPersistable
    {

#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ProductDigitalGood() { }

        /// <summary>
        /// Constructor with primary key
        /// <param name="productDigitalGoodId">Value of ProductDigitalGoodId.</param>
        /// </summary>
        public ProductDigitalGood(Int32 productDigitalGoodId)
        {
            this.ProductDigitalGoodId = productDigitalGoodId;
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
          columnNames.Add(prefix + "ProductDigitalGoodId");
          columnNames.Add(prefix + "ProductId");
          columnNames.Add(prefix + "OptionList");
          columnNames.Add(prefix + "DigitalGoodId");
          columnNames.Add(prefix + "PaymentTypeId");
          columnNames.Add(prefix + "PaymentStatusId");
          return string.Join(",", columnNames.ToArray());
        }

        /// <summary>
        /// Loads the given ProductDigitalGood object from the given database data reader.
        /// </summary>
        /// <param name="productDigitalGood">The ProductDigitalGood object to load.</param>
        /// <param name="dr">The database data reader to read data from.</param>
        public static void LoadDataReader(ProductDigitalGood productDigitalGood, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA
            productDigitalGood.ProductDigitalGoodId = dr.GetInt32(0);
            productDigitalGood.ProductId = dr.GetInt32(1);
            productDigitalGood.OptionList = NullableData.GetString(dr, 2);
            productDigitalGood.DigitalGoodId = dr.GetInt32(3);
            productDigitalGood.PaymentTypeId = dr.GetInt16(4);
            productDigitalGood.PaymentStatusId = dr.GetInt16(5);
            productDigitalGood.IsDirty = false;
        }

#endregion

        private Int32 _ProductDigitalGoodId;
        private Int32 _ProductId;
        private String _OptionList = string.Empty;
        private Int32 _DigitalGoodId;
        private Int16 _PaymentTypeId;
        private Int16 _PaymentStatusId;
        private bool _IsDirty;

        /// <summary>
        /// ProductDigitalGoodId
        /// </summary>
        [DataObjectField(true, true, false)]
        public Int32 ProductDigitalGoodId
        {
            get { return this._ProductDigitalGoodId; }
            set
            {
                if (this._ProductDigitalGoodId != value)
                {
                    this._ProductDigitalGoodId = value;
                    this.IsDirty = true;
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
                    this._Product = null;
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
        /// PaymentTypeId
        /// </summary>
        public Int16 PaymentTypeId
        {
            get { return this._PaymentTypeId; }
            set
            {
                if (this._PaymentTypeId != value)
                {
                    this._PaymentTypeId = value;
                    this.IsDirty = true;
                    this._DigitalGood = null;
                }
            }
        }
        /// <summary>
        /// PaymentTypeId
        /// </summary>
        public Int16 PaymentStatusId
        {
            get { return this._PaymentStatusId; }
            set
            {
                if (this._PaymentStatusId != value)
                {
                    this._PaymentStatusId = value;
                    this.IsDirty = true;
                    this._DigitalGood = null;
                }
            }
        }
        /// <summary>
        /// Indicates whether this ProductDigitalGood object has changed since it was loaded from the database.
        /// </summary>
        public bool IsDirty
        {
            get { return this._IsDirty; }
            set { this._IsDirty = value; }
        }

#region Parents
        private DigitalGood _DigitalGood;
        private Product _Product;

        /// <summary>
        /// The DigitalGood object that this ProductDigitalGood object is associated with
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
        /// The Product object that this ProductDigitalGood object is associated with
        /// </summary>
        public Product Product
        {
            get
            {
                if (!this.ProductLoaded)
                {
                    this._Product = ProductDataSource.Load(this.ProductId);
                }
                return this._Product;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool ProductLoaded { get { return ((this._Product != null) && (this._Product.ProductId == this.ProductId)); } }

#endregion

        /// <summary>
        /// Deletes this ProductDigitalGood object from the database.
        /// </summary>
        /// <returns><b>true</b> if delete successful, <b>false</b> otherwise.</returns>
        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM ac_ProductDigitalGoods");
            deleteQuery.Append(" WHERE ProductDigitalGoodId = @productDigitalGoodId");
            Database database = Token.Instance.Database;

            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {
                database.AddInParameter(deleteCommand, "@ProductDigitalGoodId", System.Data.DbType.Int32, this.ProductDigitalGoodId);
                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }
            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();
            return (recordsAffected > 0);
        }


        /// <summary>
        /// Load this ProductDigitalGood object from the database for the given primary key.
        /// </summary>
        /// <param name="productDigitalGoodId">Value of ProductDigitalGoodId of the object to load.</param>
        /// <returns><b>true</b> if load is successful, <b>false</b> otherwise</returns>
        public virtual bool Load(Int32 productDigitalGoodId)
        {
            bool result = false;
            this.ProductDigitalGoodId = productDigitalGoodId;
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_ProductDigitalGoods");
            selectQuery.Append(" WHERE ProductDigitalGoodId = @productDigitalGoodId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@productDigitalGoodId", System.Data.DbType.Int32, productDigitalGoodId);
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
        /// Saves this ProductDigitalGood object to the database.
        /// </summary>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        public virtual SaveResult Save()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                bool recordExists = true;
                
                if (this.ProductDigitalGoodId == 0) recordExists = false;

                if (recordExists) {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM ac_ProductDigitalGoods");
                    selectQuery.Append(" WHERE ProductDigitalGoodId = @productDigitalGoodId");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {
                        database.AddInParameter(selectCommand, "@ProductDigitalGoodId", System.Data.DbType.Int32, this.ProductDigitalGoodId);
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
                    updateQuery.Append("UPDATE ac_ProductDigitalGoods SET ");
                    updateQuery.Append("ProductId = @ProductId");
                    updateQuery.Append(", OptionList = @OptionList");
                    updateQuery.Append(", DigitalGoodId = @DigitalGoodId");
                    updateQuery.Append(", PaymentTypeId = @PaymentTypeId");
                    updateQuery.Append(", PaymentStatusId = @PaymentStatusId");
                    updateQuery.Append(" WHERE ProductDigitalGoodId = @ProductDigitalGoodId");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {
                        database.AddInParameter(updateCommand, "@ProductDigitalGoodId", System.Data.DbType.Int32, this.ProductDigitalGoodId);
                        database.AddInParameter(updateCommand, "@ProductId", System.Data.DbType.Int32, this.ProductId);
                        database.AddInParameter(updateCommand, "@OptionList", System.Data.DbType.String, NullableData.DbNullify(this.OptionList));
                        database.AddInParameter(updateCommand, "@DigitalGoodId", System.Data.DbType.Int32, this.DigitalGoodId);
                        database.AddInParameter(updateCommand, "@PaymentTypeId", System.Data.DbType.Int16, this.PaymentTypeId);
                        database.AddInParameter(updateCommand, "@PaymentStatusId", System.Data.DbType.Int16, this.PaymentStatusId);
                        //RESULT IS NUMBER OF RECORDS AFFECTED
                        result = database.ExecuteNonQuery(updateCommand);
                    }
                }
                else
                {
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO ac_ProductDigitalGoods (ProductId, OptionList, DigitalGoodId, PaymentTypeId, PaymentStatusId)");
                    insertQuery.Append(" VALUES (@ProductId, @OptionList, @DigitalGoodId, @PaymentTypeId, @PaymentStatusId)");
                    insertQuery.Append("; SELECT Scope_Identity()");
                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {
                        database.AddInParameter(insertCommand, "@ProductDigitalGoodId", System.Data.DbType.Int32, this.ProductDigitalGoodId);
                        database.AddInParameter(insertCommand, "@ProductId", System.Data.DbType.Int32, this.ProductId);
                        database.AddInParameter(insertCommand, "@OptionList", System.Data.DbType.String, NullableData.DbNullify(this.OptionList));
                        database.AddInParameter(insertCommand, "@DigitalGoodId", System.Data.DbType.Int32, this.DigitalGoodId);
                        database.AddInParameter(insertCommand, "@PaymentTypeId", System.Data.DbType.Int16, this.PaymentTypeId);
                        database.AddInParameter(insertCommand, "@PaymentStatusId", System.Data.DbType.Int16, this.PaymentStatusId);
                        //RESULT IS NEW IDENTITY;
                        result = AlwaysConvert.ToInt(database.ExecuteScalar(insertCommand));
                        this._ProductDigitalGoodId = result;
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