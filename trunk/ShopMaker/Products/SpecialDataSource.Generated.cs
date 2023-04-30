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

namespace MakerShop.Products
{
    /// <summary>
    /// DataSource class for Special objects
    /// </summary>
    public partial class SpecialDataSource
    {
        /// <summary>
        /// Deletes a Special object from the database
        /// </summary>
        /// <param name="special">The Special object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(Special special)
        {
            return special.Delete();
        }

        /// <summary>
        /// Deletes a Special object with given id from the database
        /// </summary>
        /// <param name="specialId">Value of SpecialId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 specialId)
        {
            Special special = new Special();
            if (special.Load(specialId)) return special.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a Special object to the database.
        /// </summary>
        /// <param name="special">The Special object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(Special special) { return special.Save(); }

        /// <summary>
        /// Loads a Special object for given Id from the database.
        /// </summary>
        /// <param name="specialId">Value of SpecialId of the object to load.</param>
        /// <returns>If the load is successful the newly loaded Special object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static Special Load(Int32 specialId)
        {
            return SpecialDataSource.Load(specialId, true);
        }

        /// <summary>
        /// Loads a Special object for given Id from the database.
        /// </summary>
        /// <param name="specialId">Value of SpecialId of the object to load.</param>
        /// <param name="useCache">If true tries to load object from cache first.</param>
        /// <returns>If the load is successful the newly loaded Special object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static Special Load(Int32 specialId, bool useCache)
        {
            if (specialId == 0) return null;
            Special special = null;
            string key = "Special_" + specialId.ToString();
            if (useCache)
            {
                special = ContextCache.GetObject(key) as Special;
                if (special != null) return special;
            }
            special = new Special();
            if (special.Load(specialId))
            {
                if (useCache) ContextCache.SetObject(key, special);
                return special;
            }
            return null;
        }

        /// <summary>
        /// Counts the number of Special objects in result if retrieved using the given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the Special objects that should be loaded.</param>
        /// <returns>The number of Special objects matching the criteria</returns>
        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_Specials" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of Special objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <returns>A collection of Special objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of Special objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Special objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of Special objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of Special objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of Special objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Special objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection  LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + Special.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_Specials");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            SpecialCollection results = new SpecialCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        Special special = new Special();
                        Special.LoadDataReader(special, dr);
                        results.Add(special);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of Special objects associated with the given GroupId
        /// </summary>
        /// <param name="groupId">The given GroupId</param>
        /// <returns>The number of Special objects associated with with the given GroupId</returns>
        public static int CountForGroup(Int32 groupId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_SpecialGroups WHERE GroupId = @groupId");
            database.AddInParameter(selectCommand, "@groupId", System.Data.DbType.Int32, groupId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }
        /// <summary>
        /// Loads the Special objects associated with the given GroupId
        /// </summary>
        /// <param name="groupId">The given GroupId</param>
        /// <returns>A collection of Special objects associated with with the given GroupId</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForGroup(Int32 groupId)
        {
            return SpecialDataSource.LoadForGroup(groupId, 0, 0, string.Empty);
        }
        /// <summary>
        /// Loads the Special objects associated with the given GroupId
        /// </summary>
        /// <param name="groupId">The given GroupId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Special objects associated with with the given GroupId</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForGroup(Int32 groupId, string sortExpression)
        {
            return SpecialDataSource.LoadForGroup(groupId, 0, 0, sortExpression);
        }
        /// <summary>
        /// Loads the Special objects associated with the given GroupId
        /// </summary>
        /// <param name="groupId">The given GroupId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of Special objects associated with with the given GroupId</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForGroup(Int32 groupId, int maximumRows, int startRowIndex)
        {
            return SpecialDataSource.LoadForGroup(groupId, maximumRows, startRowIndex, string.Empty);
        }
        /// <summary>
        /// Loads the Special objects associated with the given GroupId
        /// </summary>
        /// <param name="groupId">The given GroupId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Special objects associated with with the given GroupId</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForGroup(Int32 groupId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + Special.GetColumnNames("ac_Specials"));
            selectQuery.Append(" FROM ac_Specials, ac_SpecialGroups");
            selectQuery.Append(" WHERE ac_Specials.SpecialId = ac_SpecialGroups.SpecialId");
            selectQuery.Append(" AND ac_SpecialGroups.GroupId = @groupId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@groupId", System.Data.DbType.Int32, groupId);
            //EXECUTE THE COMMAND
            SpecialCollection results = new SpecialCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        Special special = new Special();
                        Special.LoadDataReader(special, dr);
                        results.Add(special);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of Special objects for the given ProductId in the database.
        /// <param name="productId">The given ProductId</param>
        /// </summary>
        /// <returns>The Number of Special objects for the given ProductId in the database.</returns>
        public static int CountForProduct(Int32 productId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_Specials WHERE ProductId = @productId");
            database.AddInParameter(selectCommand, "@productId", System.Data.DbType.Int32, productId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of Special objects for the given ProductId from the database
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <returns>A collection of Special objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForProduct(Int32 productId)
        {
            return LoadForProduct(productId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of Special objects for the given ProductId from the database
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Special objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForProduct(Int32 productId, string sortExpression)
        {
            return LoadForProduct(productId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of Special objects for the given ProductId from the database
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of Special objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForProduct(Int32 productId, int maximumRows, int startRowIndex)
        {
            return LoadForProduct(productId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of Special objects for the given ProductId from the database
        /// </summary>
        /// <param name="productId">The given ProductId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of Special objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialCollection LoadForProduct(Int32 productId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + Special.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_Specials");
            selectQuery.Append(" WHERE ProductId = @productId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@productId", System.Data.DbType.Int32, productId);
            //EXECUTE THE COMMAND
            SpecialCollection results = new SpecialCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        Special special = new Special();
                        Special.LoadDataReader(special, dr);
                        results.Add(special);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Updates/Saves the given Special object to the database.
        /// </summary>
        /// <param name="special">The Special object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(Special special) { return special.Save(); }

    }
}
