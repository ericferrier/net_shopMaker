//Generated by PersistableBaseGenerator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using MakerShop.Common;
using MakerShop.Data;
using MakerShop.Stores;
using MakerShop.Utility;

namespace MakerShop.Validation
{
    public partial class BlackLists : IPersistable
    {

        #region Constructors

        public BlackLists() { }

        public BlackLists(Int32 pBlackListId)
        {
            this.BlackListId = pBlackListId;

        }

        public static string GetColumnNames(string prefix)
        {
            if (string.IsNullOrEmpty(prefix)) prefix = string.Empty;
            else prefix = prefix + ".";
            List<string> columnNames = new List<string>();
            columnNames.Add(prefix + "BlackListId");
            columnNames.Add(prefix + "BlackListTypeId");
            columnNames.Add(prefix + "Value");
            columnNames.Add(prefix + "CreateDate");
            columnNames.Add(prefix + "CreateUser");
            columnNames.Add(prefix + "ChangeDate");
            columnNames.Add(prefix + "ChangeUser");


            return string.Join(",", columnNames.ToArray());
        }

        public static void LoadDataReader(BlackLists pBlackLists, IDataReader dr)
        {
            //SET FIELDS FROM ROW DATA

            pBlackLists.BlackListId = dr.GetInt32(0);

            pBlackLists.BlackListTypeId = dr.GetInt16(1);

            pBlackLists.Value = dr.GetString(2);

            pBlackLists.CreateDate = LocaleHelper.ToLocalTime(dr.GetDateTime(3));

            pBlackLists.CreateUser = dr.GetString(4);

            pBlackLists.ChangeDate = LocaleHelper.ToLocalTime(dr.GetDateTime(5));

            pBlackLists.ChangeUser = dr.GetString(6);


            pBlackLists.IsDirty = false;
        }

        #endregion

        #region Class Data

        private bool _IsDirty;

        public bool IsDirty
        {
            get { return this._IsDirty; }
            set { this._IsDirty = value; }
        }


        private Int32 _BlackListId;

        [DataObjectField(true, false, false)]
        public Int32 BlackListId
        {
            get { return this._BlackListId; }
            set
            {
                if (this._BlackListId != value)
                {
                    this._BlackListId = value;
                    this.IsDirty = true;
                }
            }
        }


        private Int16 _BlackListTypeId;

        [DataObjectField(true, false, false)]
        public Int16 BlackListTypeId
        {
            get { return this._BlackListTypeId; }
            set
            {
                if (this._BlackListTypeId != value)
                {
                    this._BlackListTypeId = value;
                    this.IsDirty = true;
                }
            }
        }


        private String _Value;

        [DataObjectField(true, false, false)]
        public String Value
        {
            get { return this._Value; }
            set
            {
                if (this._Value != value)
                {
                    this._Value = value;
                    this.IsDirty = true;
                }
            }
        }


        private DateTime _CreateDate;

        [DataObjectField(true, false, false)]
        public DateTime CreateDate
        {
            get { return this._CreateDate; }
            set
            {
                if (this._CreateDate != value)
                {
                    this._CreateDate = value;
                    this.IsDirty = true;
                }
            }
        }


        private String _CreateUser;

        [DataObjectField(true, false, false)]
        public String CreateUser
        {
            get { return this._CreateUser; }
            set
            {
                if (this._CreateUser != value)
                {
                    this._CreateUser = value;
                    this.IsDirty = true;
                }
            }
        }


        private DateTime _ChangeDate;

        [DataObjectField(true, false, false)]
        public DateTime ChangeDate
        {
            get { return this._ChangeDate; }
            set
            {
                if (this._ChangeDate != value)
                {
                    this._ChangeDate = value;
                    this.IsDirty = true;
                }
            }
        }


        private String _ChangeUser;

        [DataObjectField(true, false, false)]
        public String ChangeUser
        {
            get { return this._ChangeUser; }
            set
            {
                if (this._ChangeUser != value)
                {
                    this._ChangeUser = value;
                    this.IsDirty = true;
                }
            }
        }



        #endregion



        #region CURD

        public virtual bool Delete()
        {
            int recordsAffected = 0;
            StringBuilder deleteQuery = new StringBuilder();
            deleteQuery.Append("DELETE FROM xm_BlackLists");
            deleteQuery.Append(" WHERE  BlackListId = @BlackListId  ");
            Database database = Token.Instance.Database;
            MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null);
            using (DbCommand deleteCommand = database.GetSqlStringCommand(deleteQuery.ToString()))
            {

                database.AddInParameter(deleteCommand, "@BlackListId", System.Data.DbType.Int32, this.BlackListId);

                recordsAffected = database.ExecuteNonQuery(deleteCommand);
            }

            MakerShop.Stores.AuditEventDataSource.AuditInfoEnd();
            return (recordsAffected > 0);
        }

        public virtual bool Load(Int32 pBlackListId)
        {
            bool result = false;

            this.BlackListId = pBlackListId;


            //CREATE THE DYNAMIC SQL TO LOAD OBJECT
            StringBuilder selectQuery = new StringBuilder();
            selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT " + GetColumnNames(string.Empty));
            selectQuery.Append(" FROM xm_BlackLists");
            selectQuery.Append(" WHERE  BlackListId = @BlackListId  ");
            Database database = Token.Instance.Database;
            DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString());


            database.AddInParameter(selectCommand, "@BlackListId", System.Data.DbType.Int32, this.BlackListId);


            //EXECUTE THE COMMAND
            using (IDataReader dr = database.ExecuteReader(selectCommand))
            {
                if (dr.Read())
                {
                    result = true;
                    LoadDataReader(this, dr); ;
                }
                dr.Close();
            }
            return result;
        }

        public virtual SaveResult Save()
        {
            if (this.IsDirty)
            {
                Database database = Token.Instance.Database;
                MakerShop.Stores.AuditEventDataSource.AuditInfoBegin(null); 
                bool recordExists = true;

                if (recordExists)
                {
                    //verify whether record is already present
                    StringBuilder selectQuery = new StringBuilder();
                    selectQuery.Append("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; SELECT COUNT(1) As RecordCount FROM xm_BlackLists");
                    selectQuery.Append(" WHERE  BlackListId = @BlackListId ");
                    using (DbCommand selectCommand = database.GetSqlStringCommand(selectQuery.ToString()))
                    {

                        database.AddInParameter(selectCommand, "@BlackListId", System.Data.DbType.Int32, this.BlackListId);


                        if ((int)database.ExecuteScalar(selectCommand) == 0)
                        {
                            recordExists = false;
                        }
                    }
                }

                int result = 0;
                if (recordExists)
                {
                    this.ChangeDate = DateTime.Now;
                    this.ChangeUser= Token.Instance.User.UserName;
                    //UPDATE
                    StringBuilder updateQuery = new StringBuilder();
                    updateQuery.Append("UPDATE xm_BlackLists SET ");

                    updateQuery.Append("BlackListTypeId = @BlackListTypeId,Value = @Value,ChangeDate = @ChangeDate,ChangeUser = @ChangeUser");

                    updateQuery.Append(" WHERE  BlackListId = @BlackListId ");
                    using (DbCommand updateCommand = database.GetSqlStringCommand(updateQuery.ToString()))
                    {


                        database.AddInParameter(updateCommand, "@BlackListId", System.Data.DbType.Int32, this.BlackListId);

                        database.AddInParameter(updateCommand, "@BlackListTypeId", System.Data.DbType.Int16, this.BlackListTypeId);

                        database.AddInParameter(updateCommand, "@Value", System.Data.DbType.String, this.Value);

                        database.AddInParameter(updateCommand, "@ChangeDate", System.Data.DbType.DateTime, this.ChangeDate);

                        database.AddInParameter(updateCommand, "@ChangeUser", System.Data.DbType.String, this.ChangeUser);


                        //RESULT IS NUMBER OF RECORDS AFFECTED
                        result = database.ExecuteNonQuery(updateCommand);
                    }
                }
                else
                {
                    this.CreateDate = DateTime.Now;
                    this.CreateUser = Token.Instance.User.UserName;
                    //INSERT
                    StringBuilder insertQuery = new StringBuilder();
                    insertQuery.Append("INSERT INTO xm_BlackLists (BlackListTypeId,Value,CreateDate,CreateUser,ChangeDate,ChangeUser )");
                    insertQuery.Append(" VALUES (@BlackListTypeId,@Value,@CreateDate,@CreateUser,@ChangeDate,@ChangeUser )");


                    insertQuery.Append("; SELECT @@IDENTITY");


                    using (DbCommand insertCommand = database.GetSqlStringCommand(insertQuery.ToString()))
                    {

                        database.AddInParameter(insertCommand, "@BlackListId", System.Data.DbType.Int32, this.BlackListId);

                        database.AddInParameter(insertCommand, "@BlackListTypeId", System.Data.DbType.Int16, this.BlackListTypeId);

                        database.AddInParameter(insertCommand, "@Value", System.Data.DbType.String, this.Value);

                        database.AddInParameter(insertCommand, "@CreateDate", System.Data.DbType.DateTime, this.CreateDate);

                        database.AddInParameter(insertCommand, "@CreateUser", System.Data.DbType.String, this.CreateUser);

                        database.AddInParameter(insertCommand, "@ChangeDate", System.Data.DbType.DateTime, this.ChangeDate);

                        database.AddInParameter(insertCommand, "@ChangeUser", System.Data.DbType.String, this.ChangeUser);

                        //RESULT IS NUMBER OF RECORDS AFFECTED;
                        result = database.ExecuteNonQuery(insertCommand);


                        this.BlackListId = result;


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

        #endregion
    }
}
