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
    /// This class represents a ProductOption object in the database.
    /// </summary>
    public partial class ProductOption : IPersistable
    {

#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ProductOption() { }

        /// <summary>
        /// Constructor with primary key
        /// <param name="productId">Value of ProductId.</param>
        /// <param name="optionId">Value of OptionId.</param>
        /// </summary>
        public ProductOption(Int32 productId, Int32 optionId)
        {
            this.ProductId = productId;
            this.OptionId = optionId;
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
          columnNames.Add(prefix + "ProductId");
          columnNames.Add(prefix + "OptionId");
          columnNames.Add(prefix + "OrderBy");
          return string.Join(",", columnNames.ToArray());
        }

        /// <summary>
        /// Loads the given ProductOption object from the given database data reader.
        /// </summary>
        /// <param name="productOption">The ProductOption object to load.</param>
        /// <param name="dr">The database data reader to read data from.</param>
        public static void LoadDataReader(ProductOption productOption, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA
            productOption.ProductId = dr.GetInt32(0);
            productOption.OptionId = dr.GetInt32(1);
            productOption.OrderBy = dr.GetInt16(2);
            productOption.IsDirty = false;
        }

#endregion

        private Int32 _ProductId;
        private Int32 _OptionId;
        private Int16 _OrderBy = -1;
        private bool _IsDirty;

        /// <summary>
        /// ProductId
        /// </summary>
        [DataObjectField(true, false, false)]
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
        /// OptionId
        /// </summary>
        [DataObjectField(true, false, false)]
        public Int32 OptionId
        {
            get { return this._OptionId; }
            set
            {
                if (this._OptionId != value)
                {
                    this._OptionId = value;
                    this.IsDirty = true;
                    this._Option = null;
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
        /// Indicates whether this ProductOption object has changed since it was loaded from the database.
        /// </summary>
        public bool IsDirty
        {
            get { return this._IsDirty; }
            set { this._IsDirty = value; }
        }

#region Parents
        private Option _Option;
        private Product _Product;

        /// <summary>
        /// The Option object that this ProductOption object is associated with
        /// </summary>
        public Option Option
        {
            get
            {
                if (!this.OptionLoaded)
                {
                    this._Option = OptionDataSource.Load(this.OptionId);
                }
                return this._Option;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool OptionLoaded { get { return ((this._Option != null) && (this._Option.OptionId == this.OptionId)); } }

        /// <summary>
        /// The Product object that this ProductOption object is associated with
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
        /// Deletes this ProductOption object from the database.
        /// </summary>
        /// <returns><b>true</b> if delete successful, <b>false</b> otherwise.</returns>
        protected bool BaseDelete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM ac_ProductOptions");
            deleteQuery.Append(" WHERE ProductId = @productId AND OptionId = @optionId");
            Database database = Token.Instance.Database;
            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {
                database.AddInParameter(deleteCommand, "@ProductId", System.Data.DbType.Int32, this.ProductId);
                database.AddInParameter(deleteCommand, "@OptionId", System.Data.DbType.Int32, this.OptionId);
                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }

            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();
            return (recordsAffected > 0);
        }


        /// <summary>
        /// Load this ProductOption object from the database for the given primary key.
        /// </summary>
        /// <param name="productId">Value of ProductId of the object to load.</param>
        /// <param name="optionId">Value of OptionId of the object to load.</param>
        /// <returns><b>true</b> if load is successful, <b>false</b> otherwise</returns>
        public virtual bool Load(Int32 productId, Int32 optionId)
        {
            bool result = false;
            this.ProductId = productId;
            this.OptionId = optionId;
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_ProductOptions");
            selectQuery.Append(" WHERE ProductId = @productId AND OptionId = @optionId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@productId", System.Data.DbType.Int32, productId);
            database.AddInParameter(selectCommand, "@optionId", System.Data.DbType.Int32, optionId);
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
        /// Saves this ProductOption object to the database.
        /// </summary>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        protected SaveResult BaseSave()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                bool recordExists = true;
                
                if (this.OrderBy < 0) this.OrderBy = ProductOptionDataSource.GetNextOrderBy(this.ProductId);

                if (recordExists) {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM ac_ProductOptions");
                    selectQuery.Append(" WHERE ProductId = @productId AND OptionId = @optionId");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {
                        database.AddInParameter(selectCommand, "@ProductId", System.Data.DbType.Int32, this.ProductId);
                        database.AddInParameter(selectCommand, "@OptionId", System.Data.DbType.Int32, this.OptionId);
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
                    updateQuery.Append("UPDATE ac_ProductOptions SET ");
                    updateQuery.Append("OrderBy = @OrderBy");
                    updateQuery.Append(" WHERE ProductId = @ProductId AND OptionId = @OptionId");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {
                        database.AddInParameter(updateCommand, "@ProductId", System.Data.DbType.Int32, this.ProductId);
                        database.AddInParameter(updateCommand, "@OptionId", System.Data.DbType.Int32, this.OptionId);
                        database.AddInParameter(updateCommand, "@OrderBy", System.Data.DbType.Int16, this.OrderBy);
                        //RESULT IS NUMBER OF RECORDS AFFECTED
                        result = database.ExecuteNonQuery(updateCommand);
                    }
                }
                else
                {
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO ac_ProductOptions (ProductId, OptionId, OrderBy)");
                    insertQuery.Append(" VALUES (@ProductId, @OptionId, @OrderBy)");
                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {
                        database.AddInParameter(insertCommand, "@ProductId", System.Data.DbType.Int32, this.ProductId);
                        database.AddInParameter(insertCommand, "@OptionId", System.Data.DbType.Int32, this.OptionId);
                        database.AddInParameter(insertCommand, "@OrderBy", System.Data.DbType.Int16, this.OrderBy);
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

     }
}