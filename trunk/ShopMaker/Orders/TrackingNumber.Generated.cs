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
    /// This class represents a TrackingNumber object in the database.
    /// </summary>
    public partial class TrackingNumber : IPersistable
    {

#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TrackingNumber() { }

        /// <summary>
        /// Constructor with primary key
        /// <param name="trackingNumberId">Value of TrackingNumberId.</param>
        /// </summary>
        public TrackingNumber(Int32 trackingNumberId)
        {
            this.TrackingNumberId = trackingNumberId;
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
          columnNames.Add(prefix + "TrackingNumberId");
          columnNames.Add(prefix + "OrderShipmentId");
          columnNames.Add(prefix + "ShipGatewayId");
          columnNames.Add(prefix + "TrackingNumberData");
          return string.Join(",", columnNames.ToArray());
        }

        /// <summary>
        /// Loads the given TrackingNumber object from the given database data reader.
        /// </summary>
        /// <param name="trackingNumber">The TrackingNumber object to load.</param>
        /// <param name="dr">The database data reader to read data from.</param>
        public static void LoadDataReader(TrackingNumber trackingNumber, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA
            trackingNumber.TrackingNumberId = dr.GetInt32(0);
            trackingNumber.OrderShipmentId = dr.GetInt32(1);
            trackingNumber.ShipGatewayId = NullableData.GetInt32(dr, 2);
            trackingNumber.TrackingNumberData = dr.GetString(3);
            trackingNumber.IsDirty = false;
        }

#endregion

        private Int32 _TrackingNumberId;
        private Int32 _OrderShipmentId;
        private Int32 _ShipGatewayId;
        private String _TrackingNumberData = string.Empty;
        private bool _IsDirty;

        /// <summary>
        /// TrackingNumberId
        /// </summary>
        [DataObjectField(true, true, false)]
        public Int32 TrackingNumberId
        {
            get { return this._TrackingNumberId; }
            set
            {
                if (this._TrackingNumberId != value)
                {
                    this._TrackingNumberId = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// OrderShipmentId
        /// </summary>
        public Int32 OrderShipmentId
        {
            get { return this._OrderShipmentId; }
            set
            {
                if (this._OrderShipmentId != value)
                {
                    this._OrderShipmentId = value;
                    this.IsDirty = true;
                    this._OrderShipment = null;
                }
            }
        }

        /// <summary>
        /// ShipGatewayId
        /// </summary>
        public Int32 ShipGatewayId
        {
            get { return this._ShipGatewayId; }
            set
            {
                if (this._ShipGatewayId != value)
                {
                    this._ShipGatewayId = value;
                    this.IsDirty = true;
                    this._ShipGateway = null;
                }
            }
        }

        /// <summary>
        /// TrackingNumberData
        /// </summary>
        public String TrackingNumberData
        {
            get { return this._TrackingNumberData; }
            set
            {
                if (this._TrackingNumberData != value)
                {
                    this._TrackingNumberData = value;
                    this.IsDirty = true;
                }
            }
        }

        /// <summary>
        /// Indicates whether this TrackingNumber object has changed since it was loaded from the database.
        /// </summary>
        public bool IsDirty
        {
            get { return this._IsDirty; }
            set { this._IsDirty = value; }
        }

#region Parents
        private OrderShipment _OrderShipment;
        private ShipGateway _ShipGateway;

        /// <summary>
        /// The OrderShipment object that this TrackingNumber object is associated with
        /// </summary>
        public OrderShipment OrderShipment
        {
            get
            {
                if (!this.OrderShipmentLoaded)
                {
                    this._OrderShipment = OrderShipmentDataSource.Load(this.OrderShipmentId);
                }
                return this._OrderShipment;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool OrderShipmentLoaded { get { return ((this._OrderShipment != null) && (this._OrderShipment.OrderShipmentId == this.OrderShipmentId)); } }

        /// <summary>
        /// The ShipGateway object that this TrackingNumber object is associated with
        /// </summary>
        public ShipGateway ShipGateway
        {
            get
            {
                if (!this.ShipGatewayLoaded)
                {
                    this._ShipGateway = ShipGatewayDataSource.Load(this.ShipGatewayId);
                }
                return this._ShipGateway;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal bool ShipGatewayLoaded { get { return ((this._ShipGateway != null) && (this._ShipGateway.ShipGatewayId == this.ShipGatewayId)); } }

#endregion

        /// <summary>
        /// Deletes this TrackingNumber object from the database.
        /// </summary>
        /// <returns><b>true</b> if delete successful, <b>false</b> otherwise.</returns>
        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM ac_TrackingNumbers");
            deleteQuery.Append(" WHERE TrackingNumberId = @trackingNumberId");
            Database database = Token.Instance.Database;

            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null);
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {
                database.AddInParameter(deleteCommand, "@TrackingNumberId", System.Data.DbType.Int32, this.TrackingNumberId);
                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }

            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();



            return (recordsAffected > 0);
        }


        /// <summary>
        /// Load this TrackingNumber object from the database for the given primary key.
        /// </summary>
        /// <param name="trackingNumberId">Value of TrackingNumberId of the object to load.</param>
        /// <returns><b>true</b> if load is successful, <b>false</b> otherwise</returns>
        public virtual bool Load(Int32 trackingNumberId)
        {
            bool result = false;
            this.TrackingNumberId = trackingNumberId;
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_TrackingNumbers");
            selectQuery.Append(" WHERE TrackingNumberId = @trackingNumberId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@trackingNumberId", System.Data.DbType.Int32, trackingNumberId);
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
        /// Saves this TrackingNumber object to the database.
        /// </summary>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        public virtual SaveResult Save()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                bool recordExists = true;
                
                if (this.TrackingNumberId == 0) recordExists = false;

                if (recordExists) {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM ac_TrackingNumbers");
                    selectQuery.Append(" WHERE TrackingNumberId = @trackingNumberId");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {
                        database.AddInParameter(selectCommand, "@TrackingNumberId", System.Data.DbType.Int32, this.TrackingNumberId);
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
                    updateQuery.Append("UPDATE ac_TrackingNumbers SET ");
                    updateQuery.Append("OrderShipmentId = @OrderShipmentId");
                    updateQuery.Append(", ShipGatewayId = @ShipGatewayId");
                    updateQuery.Append(", TrackingNumberData = @TrackingNumberData");
                    updateQuery.Append(" WHERE TrackingNumberId = @TrackingNumberId");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {
                        database.AddInParameter(updateCommand, "@TrackingNumberId", System.Data.DbType.Int32, this.TrackingNumberId);
                        database.AddInParameter(updateCommand, "@OrderShipmentId", System.Data.DbType.Int32, this.OrderShipmentId);
                        database.AddInParameter(updateCommand, "@ShipGatewayId", System.Data.DbType.Int32, NullableData.DbNullify(this.ShipGatewayId));
                        database.AddInParameter(updateCommand, "@TrackingNumberData", System.Data.DbType.String, this.TrackingNumberData);
                        //RESULT IS NUMBER OF RECORDS AFFECTED
                        result = database.ExecuteNonQuery(updateCommand);
                    }
                }
                else
                {
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO ac_TrackingNumbers (OrderShipmentId, ShipGatewayId, TrackingNumberData)");
                    insertQuery.Append(" VALUES (@OrderShipmentId, @ShipGatewayId, @TrackingNumberData)");
                    insertQuery.Append("; SELECT Scope_Identity()");
                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {
                        database.AddInParameter(insertCommand, "@TrackingNumberId", System.Data.DbType.Int32, this.TrackingNumberId);
                        database.AddInParameter(insertCommand, "@OrderShipmentId", System.Data.DbType.Int32, this.OrderShipmentId);
                        database.AddInParameter(insertCommand, "@ShipGatewayId", System.Data.DbType.Int32, NullableData.DbNullify(this.ShipGatewayId));
                        database.AddInParameter(insertCommand, "@TrackingNumberData", System.Data.DbType.String, this.TrackingNumberData);
                        //RESULT IS NEW IDENTITY;
                        result = AlwaysConvert.ToInt(database.ExecuteScalar(insertCommand));
                        this._TrackingNumberId = result;
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
