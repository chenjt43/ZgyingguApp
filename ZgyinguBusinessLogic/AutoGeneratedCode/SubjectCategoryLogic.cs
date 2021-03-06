/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	SubjectCategory业务逻辑
 * 
 * 创建人：　	Chenjt
 * 创建日期：	2015/11/17 15:07:31
 * 创建说明：	自动生成代码，严禁修改
 * -------------------------------------------------------------------------------------------------
 * This file is generated by CodeGenerator(Ver 2.2), a product of ZhouYonghua(Zhou_Yonghua@163.com).
 * -------------------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

#if EnableWCF
using System.ServiceModel;
#endif
#if EnableDTC
using System.Transactions;
#endif

using Share.Framework;
using Share.Framework.Caching;
using Share.Framework.Logging;

using Zkjj.Zgyinggu.BusinessEntities;
using Zkjj.Zgyinggu.BusinessLogic.Caching;
using Zkjj.Zgyinggu.BusinessLogic.Logging;
using Zkjj.Zgyinggu.DataAccess;
using Zkjj.Zgyinggu.DataAccess;
#if EnableIDAL
using Zkjj.Zgyinggu.DataAccess.Interface;
#else
using Zkjj.Zgyinggu.DataAccess.SQLServer;
#endif
using Zkjj.Zgyinggu.Exceptions;
#if EnableWCF || EnableServiceContracts
using Zkjj.Zgyinggu.ServiceContracts;
#endif



namespace Zkjj.Zgyinggu.BusinessLogic
{
	/// <summary>
	/// SubjectCategory业务逻辑
	/// </summary>
	[System.ComponentModel.DataObject]
	public partial class SubjectCategoryLogic : SubjectCategoryLogicBase
#if EnableWCF || EnableServiceContracts
		, ISubjectCategoryService
#endif
	{
		//Do Not Code Here!
	}
	
	/// <summary>
	/// SubjectCategory业务逻辑基类
	/// </summary>
	public abstract class SubjectCategoryLogicBase
	{
#if EnableIDAL
		protected static readonly ISubjectCategoryDataAccess DalSubjectCategory = DalFactory.CreateSubjectCategory();//数据访问对象
#else
		protected static readonly SubjectCategoryDataAccess DalSubjectCategory = new SubjectCategoryDataAccess();//数据访问对象
#endif
		protected int _TotalRecords;//记录总数

		#region 缓存
		/// <summary>
		/// 移除根据标识获取SubjectCategory对象的缓存
		/// </summary>
		/// <param name="id">Id</param>
		protected internal virtual void RemoveGetByIdCache(Int32 id)
		{
			CacheHelper.Remove(BizCacheEnum.SubjectCategoryGetById.ToString(), new string[] {id.ToString()}, true);
		}
		#endregion
		
		/// <summary>
		/// 增加
		/// </summary>
		/// <param name="transaction">事务</param>
		/// <param name="needLog">是否记录日志</param>
		/// <param name="subjectCategory">SubjectCategory</param>
		internal virtual void Add(DbTransaction transaction, bool needLog, SubjectCategory subjectCategory)
		{
			DalSubjectCategory.Add(transaction, subjectCategory);
			
			if(needLog)
			{
				LogHelper.Instance().WriteBusinessLog(
					BizLogEnum.SubjectCategoryAdd.ToString(),
					new StringBuilder().Append("Id: ").Append(subjectCategory.Id.ToString()).ToString(),
					"增加SubjectCategory");
			}
		}
		
		/// <summary>
		/// 增加
		/// </summary>
		/// <param name="subjectCategory">SubjectCategory</param>
		public virtual void Add(SubjectCategory subjectCategory)
		{
			Add(null, true, subjectCategory);
		}

		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="transaction">事务</param>
		/// <param name="needLog">是否记录日志</param>
		/// <param name="id">Id</param>
		internal virtual void Remove(DbTransaction transaction, bool needLog, Int32 id)
		{
			DalSubjectCategory.Remove(transaction, id);
			RemoveGetByIdCache(id);
			
			if(needLog)
			{
				LogHelper.Instance().WriteBusinessLog(
					BizLogEnum.SubjectCategoryRemove.ToString(),
					new StringBuilder().Append("Id: ").Append(id.ToString()).ToString(),
					"删除SubjectCategory");
			}
		}
		
		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="id">Id</param>
		public virtual void Remove(Int32 id)
		{
			Remove(null, true, id);
		}

		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="transaction">事务</param>
		/// <param name="needLog">是否记录日志</param>
		/// <param name="subjectCategory">SubjectCategory</param>
		internal virtual void Remove(DbTransaction transaction, bool needLog, SubjectCategory subjectCategory)
		{
			Remove(transaction, needLog, subjectCategory.Id);
		}
		
		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="subjectCategory">SubjectCategory</param>
		public virtual void Remove(SubjectCategory subjectCategory)
		{
			Remove(null, true, subjectCategory);
		}
		    
		/// <summary>
		/// 保存
		/// </summary>
		/// <param name="transaction">事务</param>
		/// <param name="needLog">是否记录日志</param>
		/// <param name="subjectCategory">SubjectCategory</param>
		internal virtual void Save(DbTransaction transaction, bool needLog, SubjectCategory subjectCategory)
		{
			DalSubjectCategory.Save(transaction, subjectCategory);
			RemoveGetByIdCache(subjectCategory.Id);
			
			if(needLog)
			{
				LogHelper.Instance().WriteBusinessLog(
					BizLogEnum.SubjectCategorySave.ToString(),
					new StringBuilder().Append("Id: ").Append(subjectCategory.Id.ToString()).ToString(),
					"保存SubjectCategory");
			}
		}

		/// <summary>
		/// 保存
		/// </summary>
		/// <param name="subjectCategory">SubjectCategory</param>
		public virtual void Save(SubjectCategory subjectCategory)
		{
			Save(null, true, subjectCategory);
		}
		
#if GetNewId
		/// <summary>
		/// 获取新ID（序列）
		/// </summary>
		/// <returns>新ID</returns>
		public virtual decimal GetNewId()
		{
			return DalSubjectCategory.GetNewId();
		}
#endif
    
		/// <summary>
		/// 根据标识获取SubjectCategory对象（如果没有满足条件的记录，抛出异常）
		/// </summary>
		/// <param name="id">Id</param>
		/// <returns>SubjectCategory</returns>
		public virtual SubjectCategory GetById(Int32 id)
		{
			return GetById(id, true);
		}	
		
		/// <summary>
		/// 根据标识获取SubjectCategory对象
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="throwNotFoundException">如果没有满足条件的记录是否抛出异常</param>
		/// <returns>SubjectCategory</returns>
		public virtual SubjectCategory GetById(Int32 id, bool throwNotFoundException)
		{
			SubjectCategory subjectCategory = CacheHelper.Get<SubjectCategory, Int32>(
				BizCacheEnum.SubjectCategoryGetById.ToString(),
				id,
				new CacheMissedGetDataHandler<SubjectCategory, Int32>(DalSubjectCategory.GetById)
				);
			
			if (throwNotFoundException && subjectCategory == null)
			{
				SubjectCategoryNotFoundException subjectCategoryNotFoundException = new SubjectCategoryNotFoundException(id);
#if EnableWCF
				throw new FaultException<SubjectCategoryNotFoundException>(subjectCategoryNotFoundException, subjectCategoryNotFoundException.Message);
#else
				throw subjectCategoryNotFoundException;
#endif
			}
			
			return subjectCategory;
		}		

		/// <summary>
		/// 获取所有SubjectCategory对象列表（分页，可排序）
		/// </summary>
		/// <param name="startRowIndex">起始记录号</param>
		/// <param name="maximumRows">行数</param>
		/// <param name="sortExpression">排序表达式</param>
		/// <returns>SubjectCategory列表</returns>
		public virtual SubjectCategoryList GetPagedListAll(int startRowIndex, int maximumRows, string sortExpression)
		{
			SubjectCategoryList subjectCategoryList = DalSubjectCategory.GetPagedListAll(startRowIndex, maximumRows, sortExpression, out _TotalRecords);
			
			return subjectCategoryList;
		}
		
		/// <summary>
		/// 获取所有SubjectCategory对象记录总数
		/// </summary>
		/// <param name="startRowIndex">起始记录号</param>
		/// <param name="maximumRows">行数</param>
		/// <param name="sortExpression">排序表达式</param>
		/// <returns>SubjectCategory记录总数</returns>
		public virtual int GetRowCountAll(int startRowIndex, int maximumRows, string sortExpression)
		{
			return _TotalRecords;
		}

#if GetPagedListByCriteria
		/// <summary>
		/// 根据条件获取SubjectCategory对象列表（分页，可排序）
		/// </summary>
		/// <param name="startRowIndex">起始记录号</param>
		/// <param name="maximumRows">行数</param>
		/// <param name="sortExpression">排序表达式</param>
		/// <param name="criteria">查询条件(以And开头)</param>
		/// <returns>SubjectCategory列表</returns>
		internal virtual SubjectCategoryList GetPagedListByCriteria(int startRowIndex, int maximumRows, string sortExpression, string criteria)
		{
			SubjectCategoryList subjectCategoryList = DalSubjectCategory.GetPagedListByCriteria(startRowIndex, maximumRows, sortExpression, criteria, out _TotalRecords);
			
			return subjectCategoryList;
		}
		
		/// <summary>
		/// 根据条件获取SubjectCategory对象记录总数
		/// </summary>
		/// <param name="startRowIndex">起始记录号</param>
		/// <param name="maximumRows">行数</param>
		/// <param name="sortExpression">排序表达式</param>
		/// <param name="criteria">查询条件(以And开头)</param>
		/// <returns>SubjectCategory记录总数</returns>
		internal virtual int GetRowCountByCriteria(int startRowIndex, int maximumRows, string sortExpression, string criteria)
		{
			return _TotalRecords;
		}
#endif
	}	
}

