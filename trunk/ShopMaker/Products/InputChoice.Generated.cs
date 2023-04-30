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
    /// This class represents a InputChoice object in the database.
    /// </summary>
    public partial class InputChoice : IPersistable
    {

#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public InputChoice() { }

        /// <summary>
        /// Constructor with primary key
        /// <param name="inputChoiceId">Value of InputChoiceId.</param>
        /// </summary>
        public InputChoice(Int32 inputChoiceId)
        {
            this.InputChoiceId = inputChoiceId;
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
          columnNames.Add(prefix + "InputChoiceId");
          columnNames.Add(prefix + "InputFieldId");
          columnNames.Add(prefix + "ChoiceText");
          columnNames.Add(prefix + "ChoiceValue");
          columnNames.Add(prefix + "IsSelected");
          columnNames.Add(prefix + "OrderBy");
          return string.Join(",", columnNames.ToArray());
        }

        /// <summary>
        /// Loads the given InputChoice object from the given database data reader.
        /// </summary>
        /// <param name="inputChoice">The InputChoice object to load.</param>
        /// <param name="dr">The database data reader to read data from.</param>
        public static void LoadDataReader(InputChoice inputChoice, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA
            inputChoice.InputChoiceId = dr.GetInt32(0);
            inputChoice.InputFieldId = dr.GetInt32(1);
            inputChoice.ChoiceText = dr.GetString(2);
            inputChoice.ChoiceValue = NullableData.GetString(dr, 3);
            inputChoice.IsSelected = dr.GetBoolean(4);
            inputChoice.OrderBy = dr.GetInt16(5);
            inputChoice.IsDirty = false;
        }

#endregion

        private Int32 _InputChoiceId;
        private Int32 _InputFieldId;
        private String _ChoiceText = string.Empty;
        private String _ChoiceValue = string.Empty;
        private Boolean _IsSelected;
        private Int16 _OrderBy = -1;
        private bool _IsDirty;

        /// <summary>
        /// InputChoiceId
        /// </summary>
        [DataObjectField(true, true, false)]
        public Int32 InputChoiceId
        {
            get { return this._InputChoiceId; }
            set
            {
                if (this._InputChoiceId != value)
                {
                    this._InputChoiceId = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// InputFieldId
        /// </summary>
        public Int32 InputFieldId
        {
            get { return this._InputFieldId; }
            set
            {
                if (this._InputFieldId != value)
                {
                    this._InputFieldId = value;
                    this.IsDirty = true;
                    this._InputField = null;
                }
            }
        }

        /// <summary>
        /// ChoiceText
        /// </summary>
        public String ChoiceText
        {
            get { return this._ChoiceText; }
            set
            {
                if (this._ChoiceText != value)
                {
                    this._ChoiceText = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// ChoiceValue
        /// </summary>
        public String ChoiceValue
        {
            get { return this._ChoiceValue; }
            set
            {
                if (this._ChoiceValue != value)
                {
                    this._ChoiceValue = value;
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
        /// Indicates whether this InputChoice object has changed since it was loaded from the database.
        /// </summary>
        public bool IsDirty
        {
            get { return this._IsDirty; }
            set { this._IsDirty = value; }
        }

#region Parents
        private InputField _InputField;

        /// <summary>
        /// The InputField object that this InputChoice object is associated with
        /// </summary>
        public InputField InputField
        {
            get
            {
                if (!this.InputFieldLoaded)
                {
                    this._InputField = InputFieldDataSource.Load(this.InputFieldId);
                }
                return this._InputField;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool InputFieldLoaded { get { return ((this._InputField != null) && (this._InputField.InputFieldId == this.InputFieldId)); } }

#endregion

        /// <summary>
        /// Deletes this InputChoice object from the database.
        /// </summary>
        /// <returns><b>true</b> if delete successful, <b>false</b> otherwise.</returns>
        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM ac_InputChoices");
            deleteQuery.Append(" WHERE InputChoiceId = @inputChoiceId");
            Database database = Token.Instance.Database;
            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null);
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {
                database.AddInParameter(deleteCommand, "@InputChoiceId", System.Data.DbType.Int32, this.InputChoiceId);
                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }
            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();
            return (recordsAffected > 0);
        }


        /// <summary>
        /// Load this InputChoice object from the database for the given primary key.
        /// </summary>
        /// <param name="inputChoiceId">Value of InputChoiceId of the object to load.</param>
        /// <returns><b>true</b> if load is successful, <b>false</b> otherwise</returns>
        public virtual bool Load(Int32 inputChoiceId)
        {
            bool result = false;
            this.InputChoiceId = inputChoiceId;
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_InputChoices");
            selectQuery.Append(" WHERE InputChoiceId = @inputChoiceId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@inputChoiceId", System.Data.DbType.Int32, inputChoiceId);
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
        /// Saves this InputChoice object to the database.
        /// </summary>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        public virtual SaveResult Save()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                bool recordExists = true;
                
                if (this.InputChoiceId == 0) recordExists = false;

                if (this.OrderBy < 0) this.OrderBy = InputChoiceDataSource.GetNextOrderBy(this.InputFieldId);

                if (recordExists) {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM ac_InputChoices");
                    selectQuery.Append(" WHERE InputChoiceId = @inputChoiceId");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {
                        database.AddInParameter(selectCommand, "@InputChoiceId", System.Data.DbType.Int32, this.InputChoiceId);
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
                    updateQuery.Append("UPDATE ac_InputChoices SET ");
                    updateQuery.Append("InputFieldId = @InputFieldId");
                    updateQuery.Append(", ChoiceText = @ChoiceText");
                    updateQuery.Append(", ChoiceValue = @ChoiceValue");
                    updateQuery.Append(", IsSelected = @IsSelected");
                    updateQuery.Append(", OrderBy = @OrderBy");
                    updateQuery.Append(" WHERE InputChoiceId = @InputChoiceId");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {
                        database.AddInParameter(updateCommand, "@InputChoiceId", System.Data.DbType.Int32, this.InputChoiceId);
                        database.AddInParameter(updateCommand, "@InputFieldId", System.Data.DbType.Int32, this.InputFieldId);
                        database.AddInParameter(updateCommand, "@ChoiceText", System.Data.DbType.String, this.ChoiceText);
                        database.AddInParameter(updateCommand, "@ChoiceValue", System.Data.DbType.String, NullableData.DbNullify(this.ChoiceValue));
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
                    insertQuery.Append("INSERT INTO ac_InputChoices (InputFieldId, ChoiceText, ChoiceValue, IsSelected, OrderBy)");
                    insertQuery.Append(" VALUES (@InputFieldId, @ChoiceText, @ChoiceValue, @IsSelected, @OrderBy)");
                    insertQuery.Append("; SELECT Scope_Identity()");
                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {
                        database.AddInParameter(insertCommand, "@InputChoiceId", System.Data.DbType.Int32, this.InputChoiceId);
                        database.AddInParameter(insertCommand, "@InputFieldId", System.Data.DbType.Int32, this.InputFieldId);
                        database.AddInParameter(insertCommand, "@ChoiceText", System.Data.DbType.String, this.ChoiceText);
                        database.AddInParameter(insertCommand, "@ChoiceValue", System.Data.DbType.String, NullableData.DbNullify(this.ChoiceValue));
                        database.AddInParameter(insertCommand, "@IsSelected", System.Data.DbType.Boolean, this.IsSelected);
                        database.AddInParameter(insertCommand, "@OrderBy", System.Data.DbType.Int16, this.OrderBy);
                        //RESULT IS NEW IDENTITY;
                        result = AlwaysConvert.ToInt(database.ExecuteScalar(insertCommand));
                        this._InputChoiceId = result;
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
