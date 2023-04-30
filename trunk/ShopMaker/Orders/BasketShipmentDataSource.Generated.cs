//Generated by DataSourceBaseGenerator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
using MakerShop.Utility;

namespace MakerShop.Orders
{
    /// <summary>
    /// DataSource class for BasketShipment objects
    /// </summary>
    public partial class BasketShipmentDataSource
    {
        /// <summary>
        /// Deletes a BasketShipment object from the database
        /// </summary>
        /// <param name="basketShipment">The BasketShipment object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(BasketShipment basketShipment)
        {
            return basketShipment.Delete();
        }

        /// <summary>
        /// Deletes a BasketShipment object with given id from the database
        /// </summary>
        /// <param name="basketShipmentId">Value of BasketShipmentId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 basketShipmentId)
        {
            BasketShipment basketShipment = new BasketShipment();
            if (basketShipment.Load(basketShipmentId)) return basketShipment.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a BasketShipment object to the database.
        /// </summary>
        /// <param name="basketShipment">The BasketShipment object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(BasketShipment basketShipment) { return basketShipment.Save(); }

        /// <summary>
        /// Loads a BasketShipment object for given Id from the database.
        /// </summary>
        /// <param name="basketShipmentId">Value of BasketShipmentId of the object to load.</param>
        /// <returns>If the load is successful the newly loaded BasketShipment object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipment Load(Int32 basketShipmentId)
        {
            return BasketShipmentDataSource.Load(basketShipmentId, true);
        }

        /// <summary>
        /// Loads a BasketShipment object for given Id from the database.
        /// </summary>
        /// <param name="basketShipmentId">Value of BasketShipmentId of the object to load.</param>
        /// <param name="useCache">If true tries to load object from cache first.</param>
        /// <returns>If the load is successful the newly loaded BasketShipment object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipment Load(Int32 basketShipmentId, bool useCache)
        {
            if (basketShipmentId == 0) return null;
            BasketShipment basketShipment = null;
            string key = "BasketShipment_" + basketShipmentId.ToString();
            if (useCache)
            {
                basketShipment = ContextCache.GetObject(key) as BasketShipment;
                if (basketShipment != null) return basketShipment;
            }
            basketShipment = new BasketShipment();
            if (basketShipment.Load(basketShipmentId))
            {
                if (useCache) ContextCache.SetObject(key, basketShipment);
                return basketShipment;
            }
            return null;
        }

        /// <summary>
        /// Counts the number of BasketShipment objects in result if retrieved using the given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the BasketShipment objects that should be loaded.</param>
        /// <returns>The number of BasketShipment objects matching the criteria</returns>
        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_BasketShipments" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection  LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + BasketShipment.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_BasketShipments");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            BasketShipmentCollection results = new BasketShipmentCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        BasketShipment basketShipment = new BasketShipment();
                        BasketShipment.LoadDataReader(basketShipment, dr);
                        results.Add(basketShipment);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of BasketShipment objects for the given AddressId in the database.
        /// <param name="addressId">The given AddressId</param>
        /// </summary>
        /// <returns>The Number of BasketShipment objects for the given AddressId in the database.</returns>
        public static int CountForAddress(Int32 addressId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_BasketShipments WHERE AddressId = @addressId");
            database.AddInParameter(selectCommand, "@addressId", System.Data.DbType.Int32, NullableData.DbNullify(addressId));
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given AddressId from the database
        /// </summary>
        /// <param name="addressId">The given AddressId</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForAddress(Int32 addressId)
        {
            return LoadForAddress(addressId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given AddressId from the database
        /// </summary>
        /// <param name="addressId">The given AddressId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForAddress(Int32 addressId, string sortExpression)
        {
            return LoadForAddress(addressId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given AddressId from the database
        /// </summary>
        /// <param name="addressId">The given AddressId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForAddress(Int32 addressId, int maximumRows, int startRowIndex)
        {
            return LoadForAddress(addressId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given AddressId from the database
        /// </summary>
        /// <param name="addressId">The given AddressId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForAddress(Int32 addressId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + BasketShipment.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_BasketShipments");
            selectQuery.Append(" WHERE AddressId = @addressId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@addressId", System.Data.DbType.Int32, NullableData.DbNullify(addressId));
            //EXECUTE THE COMMAND
            BasketShipmentCollection results = new BasketShipmentCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        BasketShipment basketShipment = new BasketShipment();
                        BasketShipment.LoadDataReader(basketShipment, dr);
                        results.Add(basketShipment);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of BasketShipment objects for the given BasketId in the database.
        /// <param name="basketId">The given BasketId</param>
        /// </summary>
        /// <returns>The Number of BasketShipment objects for the given BasketId in the database.</returns>
        public static int CountForBasket(Int32 basketId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_BasketShipments WHERE BasketId = @basketId");
            database.AddInParameter(selectCommand, "@basketId", System.Data.DbType.Int32, basketId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given BasketId from the database
        /// </summary>
        /// <param name="basketId">The given BasketId</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForBasket(Int32 basketId)
        {
            return LoadForBasket(basketId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given BasketId from the database
        /// </summary>
        /// <param name="basketId">The given BasketId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForBasket(Int32 basketId, string sortExpression)
        {
            return LoadForBasket(basketId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given BasketId from the database
        /// </summary>
        /// <param name="basketId">The given BasketId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForBasket(Int32 basketId, int maximumRows, int startRowIndex)
        {
            return LoadForBasket(basketId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given BasketId from the database
        /// </summary>
        /// <param name="basketId">The given BasketId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForBasket(Int32 basketId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + BasketShipment.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_BasketShipments");
            selectQuery.Append(" WHERE BasketId = @basketId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@basketId", System.Data.DbType.Int32, basketId);
            //EXECUTE THE COMMAND
            BasketShipmentCollection results = new BasketShipmentCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        BasketShipment basketShipment = new BasketShipment();
                        BasketShipment.LoadDataReader(basketShipment, dr);
                        results.Add(basketShipment);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of BasketShipment objects for the given ShipMethodId in the database.
        /// <param name="shipMethodId">The given ShipMethodId</param>
        /// </summary>
        /// <returns>The Number of BasketShipment objects for the given ShipMethodId in the database.</returns>
        public static int CountForShipMethod(Int32 shipMethodId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_BasketShipments WHERE ShipMethodId = @shipMethodId");
            database.AddInParameter(selectCommand, "@shipMethodId", System.Data.DbType.Int32, NullableData.DbNullify(shipMethodId));
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given ShipMethodId from the database
        /// </summary>
        /// <param name="shipMethodId">The given ShipMethodId</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForShipMethod(Int32 shipMethodId)
        {
            return LoadForShipMethod(shipMethodId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given ShipMethodId from the database
        /// </summary>
        /// <param name="shipMethodId">The given ShipMethodId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForShipMethod(Int32 shipMethodId, string sortExpression)
        {
            return LoadForShipMethod(shipMethodId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given ShipMethodId from the database
        /// </summary>
        /// <param name="shipMethodId">The given ShipMethodId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForShipMethod(Int32 shipMethodId, int maximumRows, int startRowIndex)
        {
            return LoadForShipMethod(shipMethodId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given ShipMethodId from the database
        /// </summary>
        /// <param name="shipMethodId">The given ShipMethodId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForShipMethod(Int32 shipMethodId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + BasketShipment.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_BasketShipments");
            selectQuery.Append(" WHERE ShipMethodId = @shipMethodId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@shipMethodId", System.Data.DbType.Int32, NullableData.DbNullify(shipMethodId));
            //EXECUTE THE COMMAND
            BasketShipmentCollection results = new BasketShipmentCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        BasketShipment basketShipment = new BasketShipment();
                        BasketShipment.LoadDataReader(basketShipment, dr);
                        results.Add(basketShipment);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of BasketShipment objects for the given WarehouseId in the database.
        /// <param name="warehouseId">The given WarehouseId</param>
        /// </summary>
        /// <returns>The Number of BasketShipment objects for the given WarehouseId in the database.</returns>
        public static int CountForWarehouse(Int32 warehouseId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_BasketShipments WHERE WarehouseId = @warehouseId");
            database.AddInParameter(selectCommand, "@warehouseId", System.Data.DbType.Int32, NullableData.DbNullify(warehouseId));
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given WarehouseId from the database
        /// </summary>
        /// <param name="warehouseId">The given WarehouseId</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForWarehouse(Int32 warehouseId)
        {
            return LoadForWarehouse(warehouseId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given WarehouseId from the database
        /// </summary>
        /// <param name="warehouseId">The given WarehouseId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForWarehouse(Int32 warehouseId, string sortExpression)
        {
            return LoadForWarehouse(warehouseId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given WarehouseId from the database
        /// </summary>
        /// <param name="warehouseId">The given WarehouseId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForWarehouse(Int32 warehouseId, int maximumRows, int startRowIndex)
        {
            return LoadForWarehouse(warehouseId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of BasketShipment objects for the given WarehouseId from the database
        /// </summary>
        /// <param name="warehouseId">The given WarehouseId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of BasketShipment objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static BasketShipmentCollection LoadForWarehouse(Int32 warehouseId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + BasketShipment.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_BasketShipments");
            selectQuery.Append(" WHERE WarehouseId = @warehouseId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@warehouseId", System.Data.DbType.Int32, NullableData.DbNullify(warehouseId));
            //EXECUTE THE COMMAND
            BasketShipmentCollection results = new BasketShipmentCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        BasketShipment basketShipment = new BasketShipment();
                        BasketShipment.LoadDataReader(basketShipment, dr);
                        results.Add(basketShipment);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Updates/Saves the given BasketShipment object to the database.
        /// </summary>
        /// <param name="basketShipment">The BasketShipment object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(BasketShipment basketShipment) { return basketShipment.Save(); }

    }
}
