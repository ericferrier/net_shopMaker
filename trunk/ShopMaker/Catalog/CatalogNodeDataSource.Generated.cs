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

namespace MakerShop.Catalog
{
    /// <summary>
    /// DataSource class for CatalogNode objects
    /// </summary>
    public partial class CatalogNodeDataSource
    {
        /// <summary>
        /// Deletes a CatalogNode object from the database
        /// </summary>
        /// <param name="catalogNode">The CatalogNode object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(CatalogNode catalogNode)
        {
            return catalogNode.Delete();
        }

        /// <summary>
        /// Deletes a CatalogNode object with given id from the database
        /// </summary>
        /// <param name="categoryId">Value of CategoryId of the object to delete.</param>
        /// <param name="catalogNodeId">Value of CatalogNodeId of the object to delete.</param>
        /// <param name="catalogNodeTypeId">Value of CatalogNodeTypeId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 categoryId, Int32 catalogNodeId, Byte catalogNodeTypeId)
        {
            CatalogNode catalogNode = new CatalogNode();
            if (catalogNode.Load(categoryId, catalogNodeId, catalogNodeTypeId)) return catalogNode.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a CatalogNode object to the database.
        /// </summary>
        /// <param name="catalogNode">The CatalogNode object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(CatalogNode catalogNode) { return catalogNode.Save(); }

        /// <summary>
        /// Loads a CatalogNode object for given key from the database.
        /// </summary>
        /// <param name="categoryId">Value of CategoryId of the object to load.</param>
        /// <param name="catalogNodeId">Value of CatalogNodeId of the object to load.</param>
        /// <param name="catalogNodeTypeId">Value of CatalogNodeTypeId of the object to load.</param>
        /// <returns>If the load is successful the newly loaded CatalogNode object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CatalogNode Load(Int32 categoryId, Int32 catalogNodeId, Byte catalogNodeTypeId)
        {
            CatalogNode catalogNode = new CatalogNode();
            if (catalogNode.Load(categoryId, catalogNodeId, catalogNodeTypeId)) return catalogNode;
            return null;
        }

        /// <summary>
        /// Counts the number of CatalogNode objects in result if retrieved using the given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the CatalogNode objects that should be loaded.</param>
        /// <returns>The number of CatalogNode objects matching the criteria</returns>
        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_CatalogNodes" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of CatalogNode objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <returns>A collection of CatalogNode objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CatalogNodeCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of CatalogNode objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of CatalogNode objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CatalogNodeCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of CatalogNode objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of CatalogNode objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CatalogNodeCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of CatalogNode objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of CatalogNode objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CatalogNodeCollection  LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //DEFAULT SORT EXPRESSION
            if (string.IsNullOrEmpty(sortExpression)) sortExpression = "OrderBy";
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + CatalogNode.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_CatalogNodes");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            CatalogNodeCollection results = new CatalogNodeCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        CatalogNode catalogNode = new CatalogNode();
                        CatalogNode.LoadDataReader(catalogNode, dr);
                        results.Add(catalogNode);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of CatalogNode objects for the given CategoryId in the database.
        /// <param name="categoryId">The given CategoryId</param>
        /// </summary>
        /// <returns>The Number of CatalogNode objects for the given CategoryId in the database.</returns>
        public static int CountForCategory(Int32 categoryId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_CatalogNodes WHERE CategoryId = @categoryId");
            database.AddInParameter(selectCommand, "@categoryId", System.Data.DbType.Int32, categoryId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of CatalogNode objects for the given CategoryId from the database
        /// </summary>
        /// <param name="categoryId">The given CategoryId</param>
        /// <returns>A collection of CatalogNode objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CatalogNodeCollection LoadForCategory(Int32 categoryId)
        {
            return LoadForCategory(categoryId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of CatalogNode objects for the given CategoryId from the database
        /// </summary>
        /// <param name="categoryId">The given CategoryId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of CatalogNode objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CatalogNodeCollection LoadForCategory(Int32 categoryId, string sortExpression)
        {
            return LoadForCategory(categoryId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of CatalogNode objects for the given CategoryId from the database
        /// </summary>
        /// <param name="categoryId">The given CategoryId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of CatalogNode objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CatalogNodeCollection LoadForCategory(Int32 categoryId, int maximumRows, int startRowIndex)
        {
            return LoadForCategory(categoryId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of CatalogNode objects for the given CategoryId from the database
        /// </summary>
        /// <param name="categoryId">The given CategoryId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of CatalogNode objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static CatalogNodeCollection LoadForCategory(Int32 categoryId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //DEFAULT SORT EXPRESSION
            if (string.IsNullOrEmpty(sortExpression)) sortExpression = "OrderBy";
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + CatalogNode.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_CatalogNodes");
            selectQuery.Append(" WHERE CategoryId = @categoryId");
            selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@categoryId", System.Data.DbType.Int32, categoryId);
            //EXECUTE THE COMMAND
            CatalogNodeCollection results = new CatalogNodeCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        CatalogNode catalogNode = new CatalogNode();
                        CatalogNode.LoadDataReader(catalogNode, dr);
                        results.Add(catalogNode);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Gets the next value of the OrderBy field for CatalogNode objects.
        /// </summary>
        /// <param name="categoryId">The CategoryId for which to get the next OrderBy value</param>
        /// <returns>The next value of the OrderBy field for CatalogNode objects</returns>
        public static short GetNextOrderBy(Int32 categoryId)
        {
            Database database = Token.Instance.Database;
            using (DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT (Max(OrderBy) + 1) AS NextOrderBy FROM ac_CatalogNodes WHERE CategoryId = @categoryId"))
            {
                database.AddInParameter(selectCommand, "@categoryId", System.Data.DbType.Int32, categoryId);
                object result = database.ExecuteScalar(selectCommand);
                if (result.Equals(DBNull.Value)) return 1;
                return (short)(int)result;
            }
        }

        /// <summary>
        /// Updates/Saves the given CatalogNode object to the database.
        /// </summary>
        /// <param name="catalogNode">The CatalogNode object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(CatalogNode catalogNode) { return catalogNode.Save(); }

    }
}
