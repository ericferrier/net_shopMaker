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

namespace MakerShop.Users
{
    /// <summary>
    /// DataSource class for UserSetting objects
    /// </summary>
    public partial class UserSettingDataSource
    {
        /// <summary>
        /// Deletes a UserSetting object from the database
        /// </summary>
        /// <param name="userSetting">The UserSetting object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(UserSetting userSetting)
        {
            return userSetting.Delete();
        }

        /// <summary>
        /// Deletes a UserSetting object with given id from the database
        /// </summary>
        /// <param name="userSettingId">Value of UserSettingId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 userSettingId)
        {
            UserSetting userSetting = new UserSetting();
            if (userSetting.Load(userSettingId)) return userSetting.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a UserSetting object to the database.
        /// </summary>
        /// <param name="userSetting">The UserSetting object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(UserSetting userSetting) { return userSetting.Save(); }

        /// <summary>
        /// Loads a UserSetting object for given Id from the database.
        /// </summary>
        /// <param name="userSettingId">Value of UserSettingId of the object to load.</param>
        /// <returns>If the load is successful the newly loaded UserSetting object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static UserSetting Load(Int32 userSettingId)
        {
            return UserSettingDataSource.Load(userSettingId, true);
        }

        /// <summary>
        /// Loads a UserSetting object for given Id from the database.
        /// </summary>
        /// <param name="userSettingId">Value of UserSettingId of the object to load.</param>
        /// <param name="useCache">If true tries to load object from cache first.</param>
        /// <returns>If the load is successful the newly loaded UserSetting object is returned. If load fails null is returned.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static UserSetting Load(Int32 userSettingId, bool useCache)
        {
            if (userSettingId == 0) return null;
            UserSetting userSetting = null;
            string key = "UserSetting_" + userSettingId.ToString();
            if (useCache)
            {
                userSetting = ContextCache.GetObject(key) as UserSetting;
                if (userSetting != null) return userSetting;
            }
            userSetting = new UserSetting();
            if (userSetting.Load(userSettingId))
            {
                if (useCache) ContextCache.SetObject(key, userSetting);
                return userSetting;
            }
            return null;
        }

        /// <summary>
        /// Counts the number of UserSetting objects in result if retrieved using the given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the UserSetting objects that should be loaded.</param>
        /// <returns>The number of UserSetting objects matching the criteria</returns>
        public static int CountForCriteria(string sqlCriteria)
        {
            Database database = Token.Instance.Database;
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_UserSettings" + whereClause);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of UserSetting objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <returns>A collection of UserSetting objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static UserSettingCollection LoadForCriteria(string sqlCriteria)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of UserSetting objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of UserSetting objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static UserSettingCollection LoadForCriteria(string sqlCriteria, string sortExpression)
        {
            return LoadForCriteria(sqlCriteria, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of UserSetting objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of UserSetting objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static UserSettingCollection LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex)
        {
            return LoadForCriteria(sqlCriteria, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of UserSetting objects from the database based on given SQL criteria
        /// </summary>
        /// <param name="sqlCriteria">The SQL criteria string that determines the objects that should be loaded.</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of UserSetting objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static UserSettingCollection  LoadForCriteria(string sqlCriteria, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + UserSetting.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_UserSettings");
            string whereClause = string.IsNullOrEmpty(sqlCriteria) ? string.Empty : " WHERE " + sqlCriteria;
            selectQuery.Append(whereClause);
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            //EXECUTE THE COMMAND
            UserSettingCollection results = new UserSettingCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        UserSetting userSetting = new UserSetting();
                        UserSetting.LoadDataReader(userSetting, dr);
                        results.Add(userSetting);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Counts the number of UserSetting objects for the given UserId in the database.
        /// <param name="userId">The given UserId</param>
        /// </summary>
        /// <returns>The Number of UserSetting objects for the given UserId in the database.</returns>
        public static int CountForUser(Int32 userId)
        {
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) AS TotalRecords FROM ac_UserSettings WHERE UserId = @userId");
            database.AddInParameter(selectCommand, "@userId", System.Data.DbType.Int32, userId);
            return MakerShop.Utility.AlwaysConvert.ToInt(database.ExecuteScalar(selectCommand));
        }

        /// <summary>
        /// Loads a collection of UserSetting objects for the given UserId from the database
        /// </summary>
        /// <param name="userId">The given UserId</param>
        /// <returns>A collection of UserSetting objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static UserSettingCollection LoadForUser(Int32 userId)
        {
            return LoadForUser(userId, 0, 0, string.Empty);
        }

        /// <summary>
        /// Loads a collection of UserSetting objects for the given UserId from the database
        /// </summary>
        /// <param name="userId">The given UserId</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of UserSetting objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static UserSettingCollection LoadForUser(Int32 userId, string sortExpression)
        {
            return LoadForUser(userId, 0, 0, sortExpression);
        }

        /// <summary>
        /// Loads a collection of UserSetting objects for the given UserId from the database
        /// </summary>
        /// <param name="userId">The given UserId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <returns>A collection of UserSetting objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static UserSettingCollection LoadForUser(Int32 userId, int maximumRows, int startRowIndex)
        {
            return LoadForUser(userId, maximumRows, startRowIndex, string.Empty);
        }

        /// <summary>
        /// Loads a collection of UserSetting objects for the given UserId from the database
        /// </summary>
        /// <param name="userId">The given UserId</param>
        /// <param name="maximumRows">Maximum number of rows to retrieve.</param>
        /// <param name="startRowIndex">Starting index from where to start retrieving.</param>
        /// <param name="sortExpression">The sort expression to use for sorting the loaded objects.</param>
        /// <returns>A collection of UserSetting objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static UserSettingCollection LoadForUser(Int32 userId, int maximumRows, int startRowIndex, string sortExpression)
        {
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT");
            if (maximumRows > 0) selectQuery.Append(" TOP " + (startRowIndex + maximumRows).ToString());
            selectQuery.Append(" " + UserSetting.GetColumnNames(string.Empty));
            selectQuery.Append(" FROM ac_UserSettings");
            selectQuery.Append(" WHERE UserId = @userId");
            if (!string.IsNullOrEmpty(sortExpression)) selectQuery.Append(" ORDER BY " + sortExpression);
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@userId", System.Data.DbType.Int32, userId);
            //EXECUTE THE COMMAND
            UserSettingCollection results = new UserSettingCollection();
            int thisIndex = 0;
            int rowCount = 0;
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read() && ((maximumRows < 1) || (rowCount < maximumRows)))
                {
                    if (thisIndex >= startRowIndex)
                    {
                        UserSetting userSetting = new UserSetting();
                        UserSetting.LoadDataReader(userSetting, dr);
                        results.Add(userSetting);
                        rowCount++;
                    }
                    thisIndex++;
                }
                dr.Close();
            }
            return results;
        }

        /// <summary>
        /// Updates/Saves the given UserSetting object to the database.
        /// </summary>
        /// <param name="userSetting">The UserSetting object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(UserSetting userSetting) { return userSetting.Save(); }

    }
}
