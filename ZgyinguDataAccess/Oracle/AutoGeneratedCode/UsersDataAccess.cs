/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	Users���ݷ���
 * 
 * �����ˣ���	Chenjt
 * �������ڣ�	2015/11/17 15:07:31
 * ����˵����	�Զ����ɴ��룬�Ͻ��޸�
 * -------------------------------------------------------------------------------------------------
 * This file is generated by CodeGenerator(Ver 2.2), a product of ZhouYonghua(Zhou_Yonghua@163.com).
 * -------------------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

using Microsoft.ApplicationBlocks.Data;

using Share.Framework.Data;
using Share.Framework.Logging;

using Zkjj.Zgyinggu.BusinessEntities;
#if EnableIDAL
using Zkjj.Zgyinggu.DataAccess.Interface;
#endif

namespace Zkjj.Zgyinggu.DataAccess.SQLServer
{
	/// <summary>
	/// Users���ݷ���
	/// </summary>
	public partial class UsersDataAccess : UsersDataAccessBase
#if EnableIDAL
		, IUsersDataAccess
#endif
	{
		//Do Not Code Here!
	}
	
	/// <summary>
	/// Users���ݷ��ʻ���
	/// </summary>
	public class UsersDataAccessBase
	{

		/// <summary>
		/// ���ӣ���������
		/// </summary>
		/// <param name="transaction">����</param>
		/// <param name="users">Users</param>
		public virtual void Add(DbTransaction transaction, Users users)
		{
			string commandName = "Pr_Users_I";
						
			#region Parameters
			SqlParameter[] parms = SqlHelperParameterCache.GetCachedParameterSet(ConnectionString.ZgyinguWrite, commandName);
			if (parms == null)
			{
				parms = new SqlParameter[] {
					new SqlParameter("@UserId", SqlDbType.Int),
					new SqlParameter("@UserName", SqlDbType.NVarChar, 50),
					new SqlParameter("@Password", SqlDbType.NVarChar, 100),
					new SqlParameter("@DisplayName", SqlDbType.NVarChar, 50),
					new SqlParameter("@UserHeadImg", SqlDbType.NVarChar, 200)
					};
				SqlHelperParameterCache.CacheParameterSet(ConnectionString.ZgyinguWrite, commandName, parms);
			}

			#region �����������
			parms[0].Direction = ParameterDirection.InputOutput;
			#endregion
			
			#region ������ֵ
			parms[1].Value = users.UserName;
			parms[2].Value = users.Password;
			parms[3].Value = users.DisplayName;
			parms[4].Value = users.UserHeadImg;
			#endregion
			#endregion			
		
			try
			{
				if (transaction == null)
				{
					SqlHelper.ExecuteNonQuery(ConnectionString.ZgyinguWrite, CommandType.StoredProcedure, commandName, parms);
				}
				else
				{
					SqlHelper.ExecuteNonQuery((SqlTransaction)transaction, CommandType.StoredProcedure, commandName, parms);
				}
			}
			catch (SqlException ex)
			{
				DBContraintExceptionHandler.Handle(ex, DBOperateType.Insert, null);
				throw;
			}

			#region ��ȡ�������ֵ
			users.UserId = (Int32)parms[0].Value;
			#endregion
		}

		///// <summary>
		///// ����
		///// </summary>
		///// <param name="users">Users</param>
		//public virtual void Add(Users users)
		//{
		//  Add(null, users);
		//}
		
		/// <summary>
		/// ɾ������������
		/// </summary>
		/// <param name="transaction">����</param>
		/// <param name="userId">UserId</param>
		public virtual void Remove(DbTransaction transaction, Int32 userId)
		{
			string commandName = "Pr_Users_D";

			#region Parameters
			SqlParameter[] parms = SqlHelperParameterCache.GetCachedParameterSet(ConnectionString.ZgyinguWrite, commandName);
			if (parms == null)
			{
				parms = new SqlParameter[] {
					new SqlParameter("@UserId", SqlDbType.Int)
				};
				SqlHelperParameterCache.CacheParameterSet(ConnectionString.ZgyinguWrite, commandName, parms);
			}
			
			#region ������ֵ
			parms[0].Value = userId;
			#endregion
			#endregion
						
			try
			{
				if (transaction == null)
				{
					SqlHelper.ExecuteNonQuery(ConnectionString.ZgyinguWrite, CommandType.StoredProcedure, commandName, parms);
				}
				else
				{
					SqlHelper.ExecuteNonQuery((SqlTransaction)transaction, CommandType.StoredProcedure, commandName, parms);
				}
			}
			catch (SqlException ex)
			{
				DBContraintExceptionHandler.Handle(ex, DBOperateType.Delete, new string[] { userId.ToString() });
				throw;
			}
		}

		///// <summary>
		///// ɾ��
		///// </summary>
		///// <param name="userId">UserId</param>
		//public virtual void Remove(Int32 userId)
		//{
		//  Remove(null, userId);
		//}
		
		/// <summary>
		/// ���棨��������
		/// </summary>
		/// <param name="transaction">����</param>
		/// <param name="users">Users</param>
		public virtual void Save(DbTransaction transaction, Users users)
		{
			string commandName = "Pr_Users_U";

			#region Parameters
			SqlParameter[] parms = SqlHelperParameterCache.GetCachedParameterSet(ConnectionString.ZgyinguWrite, commandName);
			if (parms == null)
			{
				parms = new SqlParameter[] {
					new SqlParameter("@UserId", SqlDbType.Int),
					new SqlParameter("@UserName", SqlDbType.NVarChar, 50),
					new SqlParameter("@Password", SqlDbType.NVarChar, 100),
					new SqlParameter("@DisplayName", SqlDbType.NVarChar, 50),
					new SqlParameter("@UserHeadImg", SqlDbType.NVarChar, 200)
				};
				SqlHelperParameterCache.CacheParameterSet(ConnectionString.ZgyinguWrite, commandName, parms);
			}
			
			#region ������ֵ
			parms[0].Value = users.UserId;
			parms[1].Value = users.UserName;
			parms[2].Value = users.Password;
			parms[3].Value = users.DisplayName;
			parms[4].Value = users.UserHeadImg;
			#endregion
			#endregion
			
			try
			{
				if (transaction == null)
				{
					SqlHelper.ExecuteNonQuery(ConnectionString.ZgyinguWrite, CommandType.StoredProcedure, commandName, parms);
				}
				else
				{
					SqlHelper.ExecuteNonQuery((SqlTransaction)transaction, CommandType.StoredProcedure, commandName, parms);
				}
			}
			catch (SqlException ex)
			{
				DBContraintExceptionHandler.Handle(ex, DBOperateType.Update, null);
				throw;
			}
		}

		///// <summary>
		///// ����
		///// </summary>
		///// <param name="users">Users</param>
		//public virtual void Save(Users users)
		//{
		//  Save(null, users);
		//}
		
		/// <summary>
		/// ��ȡ��ID�����У�
		/// </summary>
		/// <returns>��ID</returns>
		public virtual decimal GetNewId()
		{
			string commandText = @"SELECT S_Users.nextval FROM DUAL;";

			return (decimal)OracleHelper.ExecuteScalar(ConnectionString.ZgyinguWrite, CommandType.Text, commandText, null);
		}
		
		/// <summary>
		/// ���ݱ�ʶ��ȡ����
		/// </summary>
		/// <param name="userId">UserId</param>
		/// <returns>Users</returns>
		public virtual Users GetById(Int32 userId)
		{
			Users users = null;
			
			string commandName = "Query_Users_GetByPk";
			string commandText = @"
SELECT *
FROM Users
WHERE
 UserId = :p_UserId";

			#region Parameters
			SqlParameter[] parms = SqlHelperParameterCache.GetCachedParameterSet(ConnectionString.ZgyinguRead, commandName);
			if (parms == null)
			{
				parms = new SqlParameter[] {
					new SqlParameter("@UserId", SqlDbType.Int)
				};
				SqlHelperParameterCache.CacheParameterSet(ConnectionString.ZgyinguRead, commandName, parms);
			}
			
			#region ������ֵ
			parms[0].Value = userId;
			#endregion
			#endregion

			using (SqlDataReader dataReader = SqlHelper.ExecuteReader(ConnectionString.ZgyinguRead, CommandType.Text, commandText, parms))
			{
				if (dataReader.Read())
				{
					users = PopulateUsersFromDataReader(dataReader);
				}
			}
			
			return users;
		}
	
		/// <summary>
		/// ��ȡ���ж����б�����ҳ��������
		/// </summary>
		/// <param name="startRowIndex">��ʼ��¼��</param>
		/// <param name="maximumRows">����</param>
		/// <param name="sortExpression">�������ʽ</param>
		/// <param name="totalRecords">�����أ���¼����</param>
		/// <returns>Users�б�</returns>
		public virtual UsersList GetPagedListAll(int startRowIndex, int maximumRows, string sortExpression, out int totalRecords)
		{
			UsersList usersList = new UsersList();
			
			string commandName = "Query_Users_GetPagedListAll";
			string commandText = string.Format(@"
SELECT * FROM 
(SELECT a.*, ROWNUM RIndex FROM 
(SELECT * FROM Users t {0}) a
) b WHERE RIndex > :p_startRowIndex AND RIndex <= :p_endRowIndex",
				string.IsNullOrEmpty(sortExpression) ? "" : "ORDER BY " + sortExpression);

			#region Parameters
			SqlParameter[] parms = SqlHelperParameterCache.GetCachedParameterSet(ConnectionString.ZgyinguRead, commandName);
			if (parms == null)
			{
				parms = new SqlParameter[] {
					new SqlParameter("p_startRowIndex", SqlDbType.Int),
					new SqlParameter("p_endRowIndex", SqlDbType.Int)
				};
				SqlHelperParameterCache.CacheParameterSet(ConnectionString.ZgyinguRead, commandName, parms);
			}
			
			parms[0].Value = startRowIndex;
			parms[1].Value = startRowIndex + maximumRows;
			#endregion
			using (SqlDataReader dataReader = SqlHelper.ExecuteReader(ConnectionString.ZgyinguRead, CommandType.Text, commandText, parms))
			{
				while (dataReader.Read())
				{
					usersList.Add(PopulateUsersFromDataReader(dataReader));
				}
			}
			
			commandText = @"
SELECT COUNT(*) FROM Users";
			totalRecords = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString.ZgyinguRead, CommandType.Text, commandText, null));
			
			return usersList;
		}
		
		/// <summary>
		/// ����������ȡ�����б�����ҳ��������
		/// </summary>
		/// <param name="startRowIndex">��ʼ��¼��</param>
		/// <param name="maximumRows">����</param>
		/// <param name="sortExpression">�������ʽ</param>
		/// <param name="criteria">��ѯ����(��And��ͷ)</param>
		/// <param name="totalRecords">�����أ���¼����</param>
		/// <returns>Users�б�</returns>
		public virtual UsersList GetPagedListByCriteria(int startRowIndex, int maximumRows, string sortExpression, string criteria, out int totalRecords)
		{
			UsersList usersList = new UsersList();
			
			string commandName = "Query_Users_GetPagedListByCriteria";
			string commandText = string.Format(@"
SELECT * FROM 
(SELECT a.*, ROWNUM RIndex FROM 
(SELECT * FROM Users t WHERE 1=1 {1} {0}) a
) b WHERE RIndex > :p_startRowIndex AND RIndex <= :p_endRowIndex",
				string.IsNullOrEmpty(sortExpression) ? "" : "ORDER BY " + sortExpression,
				criteria);

			#region Parameters
			SqlParameter[] parms = SqlHelperParameterCache.GetCachedParameterSet(ConnectionString.ZgyinguRead, commandName);
			if (parms == null)
			{
				parms = new SqlParameter[] {
					new SqlParameter("p_startRowIndex", SqlDbType.Int),
					new SqlParameter("p_endRowIndex", SqlDbType.Int)
				};
				SqlHelperParameterCache.CacheParameterSet(ConnectionString.ZgyinguRead, commandName, parms);
			}
			
			parms[0].Value = startRowIndex;
			parms[1].Value = startRowIndex + maximumRows;
			#endregion
			using (SqlDataReader dataReader = SqlHelper.ExecuteReader(ConnectionString.ZgyinguRead, CommandType.Text, commandText, parms))
			{
				while (dataReader.Read())
				{
					usersList.Add(PopulateUsersFromDataReader(dataReader));
				}
			}
			
			commandText = string.Format(@"
SELECT COUNT(*) FROM Users WHERE 1=1 {0} ",
				criteria);;
			totalRecords = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString.ZgyinguRead, CommandType.Text, commandText, null));
			
			return usersList;
		}
		
		/// <summary>
		/// ��DataReader�ж�ȡ���ݵ�ҵ�����
		/// </summary>
		/// <param name="reader">DataReader</param>
		/// <returns>Users</returns>
		protected virtual Users PopulateUsersFromDataReader(SqlDataReader reader)
		{
			return DataReaderUtility.FillData<Users>(reader);
		}
	}
}