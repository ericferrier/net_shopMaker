//Generated by DataSourceBaseGenerator_Assn

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
namespace MakerShop.Products
{

    /// <summary>
    /// DataSource class for SpecialGroup objects
    /// </summary>
    public partial class SpecialGroupDataSource
    {
        /// <summary>
        /// Deletes a SpecialGroup object from the database
        /// </summary>
        /// <param name="specialGroup">The SpecialGroup object to delete</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static bool Delete(SpecialGroup specialGroup)
        {
            return specialGroup.Delete();
        }

        /// <summary>
        /// Deletes a SpecialGroup object with given id from the database
        /// </summary>
        /// <param name="specialId">Value of SpecialId of the object to delete.</param>
        /// <param name="groupId">Value of GroupId of the object to delete.</param>
        /// <returns><b>true</b> if delete operation is successful, <b>false</b> otherwise</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static bool Delete(Int32 specialId, Int32 groupId)
        {
            SpecialGroup specialGroup = new SpecialGroup();
            if (specialGroup.Load(specialId, groupId)) return specialGroup.Delete();
            return false;
        }

        /// <summary>
        /// Inserts/Saves a SpecialGroup object to the database.
        /// </summary>
        /// <param name="specialGroup">The SpecialGroup object to insert</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Insert(SpecialGroup specialGroup) { return specialGroup.Save(); }

        /// <summary>
        /// Load a SpecialGroup object for the given primary key from the database.
        /// </summary>
        /// <param name="specialId">Value of SpecialId of the object to load.</param>
        /// <param name="groupId">Value of GroupId of the object to load.</param>
        /// <returns>The loaded SpecialGroup object.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialGroup Load(Int32 specialId, Int32 groupId)
        {
            SpecialGroup specialGroup = new SpecialGroup();
            specialGroup.SpecialId = specialId;
            specialGroup.GroupId = groupId;
            specialGroup.IsDirty = false;
            return specialGroup;
        }

        /// <summary>
        /// Loads a collection of SpecialGroup objects for the given criteria for Group from the database.
        /// </summary>
        /// <param name="groupId">Value of GroupId of the object to load.</param>
        /// <returns>A collection of SpecialGroup objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialGroupCollection LoadForGroup(Int32 groupId)
        {
            SpecialGroupCollection SpecialGroups = new SpecialGroupCollection();
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT SpecialId");
            selectQuery.Append(" FROM ac_SpecialGroups");
            selectQuery.Append(" WHERE GroupId = @groupId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@groupId", System.Data.DbType.Int32, groupId);
            //EXECUTE THE COMMAND
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read())
                {
                    SpecialGroup specialGroup = new SpecialGroup();
                    specialGroup.GroupId = groupId;
                    specialGroup.SpecialId = dr.GetInt32(0);
                    SpecialGroups.Add(specialGroup);
                }
                dr.Close();
            }
            return SpecialGroups;
        }

        /// <summary>
        /// Loads a collection of SpecialGroup objects for the given criteria for Special from the database.
        /// </summary>
        /// <param name="specialId">Value of SpecialId of the object to load.</param>
        /// <returns>A collection of SpecialGroup objects</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static SpecialGroupCollection LoadForSpecial(Int32 specialId)
        {
            SpecialGroupCollection SpecialGroups = new SpecialGroupCollection();
            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT GroupId");
            selectQuery.Append(" FROM ac_SpecialGroups");
            selectQuery.Append(" WHERE SpecialId = @specialId");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());
            database.AddInParameter(selectCommand, "@specialId", System.Data.DbType.Int32, specialId);
            //EXECUTE THE COMMAND
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                while (dr.Read())
                {
                    SpecialGroup specialGroup = new SpecialGroup();
                    specialGroup.SpecialId = specialId;
                    specialGroup.GroupId = dr.GetInt32(0);
                    SpecialGroups.Add(specialGroup);
                }
                dr.Close();
            }
            return SpecialGroups;
        }

        /// <summary>
        /// Updates/Saves the given SpecialGroup object to the database.
        /// </summary>
        /// <param name="specialGroup">The SpecialGroup object to update/save to database.</param>
        /// <returns><b>SaveResult</b> enumeration that represents the result of the save operation.</returns>
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static SaveResult Update(SpecialGroup specialGroup) { return specialGroup.Save(); }

    }
}
