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
using MakerShop.Stores;
using MakerShop.Utility;

namespace MakerShop.DigitalDelivery
{
    /// <summary>
    /// This class represents a Readme object in the database.
    /// </summary>
    public partial class Readme : IPersistable
    {

#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Readme() { }

        /// <summary>
        /// Constructor with primary key
        /// <param name="readmeId">Value of ReadmeId.</param>
        /// </summary>
        public Readme(Int32 readmeId)
        {
            this.ReadmeId = readmeId;
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
          columnNames.Add(prefix + "ReadmeId");
          columnNames.Add(prefix + "StoreId");
          columnNames.Add(prefix + "DisplayName");
          columnNames.Add(prefix + "ReadmeText");
          columnNames.Add(prefix + "IsHTML");
          return string.Join(",", columnNames.ToArray());
        }

        /// <summary>
        /// Loads the given Readme object from the given database data reader.
        /// </summary>
        /// <param name="readme">The Readme object to load.</param>
        /// <param name="dr">The database data reader to read data from.</param>
        public static void LoadDataReader(Readme readme, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA
            readme.ReadmeId = dr.GetInt32(0);
            readme.StoreId = dr.GetInt32(1);
            readme.DisplayName = dr.GetString(2);
            readme.ReadmeText = dr.GetString(3);
            readme.IsHTML = dr.GetBoolean(4);
            readme.IsDirty = false;
        }

#endregion

        private Int32 _ReadmeId;
        private Int32 _StoreId;
        private String _DisplayName = string.Empty;
        private String _ReadmeText = string.Empty;
        private Boolean _IsHTML;
        private bool _IsDirty;

        /// <summary>
        /// ReadmeId
        /// </summary>
        [DataObjectField(true, true, false)]
        public Int32 ReadmeId
        {
            get { return this._ReadmeId; }
            set
            {
                if (this._ReadmeId != value)
                {
                    this._ReadmeId = value;
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
        /// DisplayName
        /// </summary>
        public String DisplayName
        {
            get { return this._DisplayName; }
            set
            {
                if (this._DisplayName != value)
                {
                    this._DisplayName = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ReadmeText
        /// </summary>
        public String ReadmeText
        {
            get { return this._ReadmeText; }
            set
            {
                if (this._ReadmeText != value)
                {
                    this._ReadmeText = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// IsHTML
        /// </summary>
        public Boolean IsHTML
        {
            get { return this._IsHTML; }
            set
            {
                if (this._IsHTML != value)
                {
                    this._IsHTML = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Indicates whether this Readme object has changed since it was loaded from the database.
        /// </summary>
        public bool IsDirty
        {
            get
            {
                if (this._IsDirty) return true;
                if (this.DigitalGoodsLoaded && this.DigitalGoods.IsDirty) return true;
                return false;
            }
            set { this._IsDirty = value; }
        }

        /// <summary>
        /// Ensures that child objects of this Readme are properly associated with this Readme object.
        /// </summary>
        public virtual void EnsureChildProperties()
        {
            if (this.DigitalGoodsLoaded) { foreach (DigitalGood digitalGood in this.DigitalGoods) { digitalGood.ReadmeId = this.ReadmeId; } }
        }

#region Parents
        private Store _Store;

        /// <summary>
        /// The Store object that this Readme object is associated with
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
        private DigitalGoodCollection _DigitalGoods;

        /// <summary>
        /// A collection of DigitalGood objects associated with this Readme object.
        /// </summary>
        public DigitalGoodCollection DigitalGoods
        {
            get
            {
                if (!this.DigitalGoodsLoaded)
                {
                    this._DigitalGoods = DigitalGoodDataSource.LoadForReadme(this.ReadmeId);
                }
                return this._DigitalGoods;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool DigitalGoodsLoaded { get { return (this._DigitalGoods != null); } }

#endregion

        /// <summary>
        /// Deletes this Readme object from the database.
        /// </summary>
        /// <returns><b>true</b> if delete successful, <b>false</b> otherwise.</returns>
        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM ac_Readmes");
            deleteQuery.Append(" WHERE ReadmeId = @readmeId");
            Database database = Token.Instance.Database;
            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {
                database.AddInParameter(deleteCommand, "@ReadmeId", System.Data.DbType.Int32, this.ReadmeId);
                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }
            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();
            return (recordsAffected > 0);
        }


        /// <summary>
        /// Load this Readme object from the database for the given primary key.
        /// </summary>
        /// <param name="readmeId">Value of ReadmeId of the object to load.</param>
        /// <returns><b>true</b> if load is successful, <b>false</b> otherwise</returns>
        public virtual bool Load(Int32 readmeId)
        {
            bool result = false;
            this.ReadmeId = readmeId;
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_Readmes");
            selectQuery.Append(" WHERE ReadmeId = @readmeId");
            selectQuery.Append(" AND StoreId = @storeId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@readmeId", System.Data.DbType.Int32, readmeId);
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
        /// Saves this Readme object to the database.
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
                if (this.ReadmeId == 0) recordExists = false;

                if (recordExists) {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM ac_Readmes");
                    selectQuery.Append(" WHERE ReadmeId = @readmeId");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {
                        database.AddInParameter(selectCommand, "@ReadmeId", System.Data.DbType.Int32, this.ReadmeId);
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
                    updateQuery.Append("UPDATE ac_Readmes SET ");
                    updateQuery.Append("StoreId = @StoreId");
                    updateQuery.Append(", DisplayName = @DisplayName");
                    updateQuery.Append(", ReadmeText = @ReadmeText");
                    updateQuery.Append(", IsHTML = @IsHTML");
                    updateQuery.Append(" WHERE ReadmeId = @ReadmeId");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {
                        database.AddInParameter(updateCommand, "@ReadmeId", System.Data.DbType.Int32, this.ReadmeId);
                        database.AddInParameter(updateCommand, "@StoreId", System.Data.DbType.Int32, this.StoreId);
                        database.AddInParameter(updateCommand, "@DisplayName", System.Data.DbType.String, this.DisplayName);
                        database.AddInParameter(updateCommand, "@ReadmeText", System.Data.DbType.String, this.ReadmeText);
                        database.AddInParameter(updateCommand, "@IsHTML", System.Data.DbType.Boolean, this.IsHTML);
                        //RESULT IS NUMBER OF RECORDS AFFECTED
                        result = database.ExecuteNonQuery(updateCommand);
                    }
                }
                else
                {
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO ac_Readmes (StoreId, DisplayName, ReadmeText, IsHTML)");
                    insertQuery.Append(" VALUES (@StoreId, @DisplayName, @ReadmeText, @IsHTML)");
                    insertQuery.Append("; SELECT Scope_Identity()");
                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {
                        database.AddInParameter(insertCommand, "@ReadmeId", System.Data.DbType.Int32, this.ReadmeId);
                        database.AddInParameter(insertCommand, "@StoreId", System.Data.DbType.Int32, this.StoreId);
                        database.AddInParameter(insertCommand, "@DisplayName", System.Data.DbType.String, this.DisplayName);
                        database.AddInParameter(insertCommand, "@ReadmeText", System.Data.DbType.String, this.ReadmeText);
                        database.AddInParameter(insertCommand, "@IsHTML", System.Data.DbType.Boolean, this.IsHTML);
                        //RESULT IS NEW IDENTITY;
                        result = AlwaysConvert.ToInt(database.ExecuteScalar(insertCommand));
                        this._ReadmeId = result;
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
        /// Saves that child objects associated with this Readme object.
        /// </summary>
        public virtual void SaveChildren()
        {
            this.EnsureChildProperties();
            if (this.DigitalGoodsLoaded) this.DigitalGoods.Save();
        }

     }
}
