//Generated by PersistableBaseGenerator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
using MakerShop.Shipping;
using MakerShop.Users;
using MakerShop.Utility;

namespace MakerShop.Shipping
{
    /// <summary>
    /// This class represents a ShipMethodGroup object in the database.
    /// </summary>
    public partial class ShipMethodGroup : IPersistable
    {

#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ShipMethodGroup() { }

        /// <summary>
        /// Constructor with primary key
        /// <param name="shipMethodId">Value of ShipMethodId.</param>
        /// <param name="groupId">Value of GroupId.</param>
        /// </summary>
        public ShipMethodGroup(Int32 shipMethodId, Int32 groupId)
        {
            this.ShipMethodId = shipMethodId;
            this.GroupId = groupId;
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
          columnNames.Add(prefix + "ShipMethodId");
          columnNames.Add(prefix + "GroupId");
          return string.Join(",", columnNames.ToArray());
        }

        /// <summary>
        /// Loads the given ShipMethodGroup object from the given database data reader.
        /// </summary>
        /// <param name="shipMethodGroup">The ShipMethodGroup object to load.</param>
        /// <param name="dr">The database data reader to read data from.</param>
        public static void LoadDataReader(ShipMethodGroup shipMethodGroup, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA
            shipMethodGroup.ShipMethodId = dr.GetInt32(0);
            shipMethodGroup.GroupId = dr.GetInt32(1);
            shipMethodGroup.IsDirty = false;
        }

#endregion

        private Int32 _ShipMethodId;
        private Int32 _GroupId;
        private bool _IsDirty;

        /// <summary>
        /// ShipMethodId
        /// </summary>
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
                    this._ShipMethod = null;
                }
            }
        }

        /// <summary>
        /// GroupId
        /// </summary>
        [DataObjectField(true, false, false)]
        public Int32 GroupId
        {
            get { return this._GroupId; }
            set
            {
                if (this._GroupId != value)
                {
                    this._GroupId = value;
                    this.IsDirty = true;
                    this._Group = null;
                }
            }
        }

        /// <summary>
        /// Indicates whether this ShipMethodGroup object has changed since it was loaded from the database.
        /// </summary>
        public bool IsDirty
        {
            get { return this._IsDirty; }
            set { this._IsDirty = value; }
        }

#region Parents
        private Group _Group;
        private ShipMethod _ShipMethod;

        /// <summary>
        /// The Group object that this ShipMethodGroup object is associated with
        /// </summary>
        public Group Group
        {
            get
            {
                if (!this.GroupLoaded)
                {
                    this._Group = GroupDataSource.Load(this.GroupId);
                }
                return this._Group;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool GroupLoaded { get { return ((this._Group != null) && (this._Group.GroupId == this.GroupId)); } }

        /// <summary>
        /// The ShipMethod object that this ShipMethodGroup object is associated with
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

#endregion

        /// <summary>
        /// Deletes this ShipMethodGroup object from the database.
        /// </summary>
        /// <returns><b>true</b> if delete successful, <b>false</b> otherwise.</returns>
        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM ac_ShipMethodGroups");
            deleteQuery.Append(" WHERE ShipMethodId = @shipMethodId AND GroupId = @groupId");
            Database database = Token.Instance.Database;

            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {
                database.AddInParameter(deleteCommand, "@ShipMethodId", System.Data.DbType.Int32, this.ShipMethodId);
                database.AddInParameter(deleteCommand, "@GroupId", System.Data.DbType.Int32, this.GroupId);
                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }
            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();
            return (recordsAffected > 0);
        }

        /// <summary>
        /// Load this ShipMethodGroup object from the database for the given primary key.
        /// </summary>
        /// <param name="shipMethodId">Value of ShipMethodId of the object to load.</param>
        /// <param name="groupId">Value of GroupId of the object to load.</param>
        /// <returns><b>true</b> if load is successful, <b>false</b> otherwise</returns>
        public virtual bool Load(Int32 shipMethodId, Int32 groupId)
        {
            this.ShipMethodId = shipMethodId;
            this.GroupId = groupId;
            this.IsDirty = false;
            return true;
        }

        /// <summary>
        /// Saves this ShipMethodGroup object to the database.
        /// </summary>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        public virtual SaveResult Save()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                
                bool recordExists = true;
                
                //generate key(s) if needed
                if (recordExists) {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM ac_ShipMethodGroups");
                    selectQuery.Append(" WHERE ShipMethodId = @shipMethodId AND GroupId = @groupId");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {
                        database.AddInParameter(selectCommand, "@ShipMethodId", System.Data.DbType.Int32, this.ShipMethodId);
                        database.AddInParameter(selectCommand, "@GroupId", System.Data.DbType.Int32, this.GroupId);
                        if ((int)database.ExecuteScalar(selectCommand) == 0)
                        {
                            recordExists = false;
                        }
                    }
                }

                if (recordExists)
                {
                    //RECORD ALREADY EXISTS IN DATABASE
                    this.IsDirty = false;
                    return SaveResult.RecordUpdated;
                }
                else
                {
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO ac_ShipMethodGroups (ShipMethodId, GroupId)");
                    insertQuery.Append(" VALUES (@ShipMethodId, @GroupId)");
                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {
                        database.AddInParameter(insertCommand, "@ShipMethodId", System.Data.DbType.Int32, this.ShipMethodId);
                        database.AddInParameter(insertCommand, "@GroupId", System.Data.DbType.Int32, this.GroupId);
                        MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                        int recordsAffected = database.ExecuteNonQuery(insertCommand);
                        MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();
                        //OBJECT IS NOT DIRTY IF RECORD WAS INSERTED
                        this.IsDirty = (recordsAffected == 0);
                        if (this.IsDirty) { return SaveResult.Failed; }
                        return SaveResult.RecordInserted;
                    }
                }

            }

            //SAVE IS SUCCESSFUL IF OBJECT IS NOT DIRTY
            return SaveResult.NotDirty;
        }

     }
}
