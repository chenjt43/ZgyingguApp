/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	SubjectInfo服务接口
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
using System.Text;

#if EnableWCF
using System.ServiceModel;
#endif

using Zkjj.Zgyinggu.BusinessEntities;
using Zkjj.Zgyinggu.Exceptions;

namespace Zkjj.Zgyinggu.ServiceContracts
{
	/// <summary>
	/// SubjectInfo服务接口
	/// </summary>
#if EnableWCF
	[ServiceContract]
#endif
	public partial interface ISubjectInfoService : ISubjectInfoServiceBase
	{
		//Do Not Code Here!
	}
	
	/// <summary>
	/// SubjectInfo服务接口基类
	/// </summary>
#if EnableWCF
	[ServiceContract]
#endif
	public interface ISubjectInfoServiceBase
	{

		/// <summary>
		/// 增加
		/// </summary>
		/// <param name="subjectInfo">SubjectInfo</param>
#if EnableWCF
		[OperationContract]
#endif
		void Add(SubjectInfo subjectInfo);

		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="id">Id</param>

#if EnableWCF
		[OperationContract(Name = "RemoveById")]
#endif
		void Remove(Int32 id);
		
		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="subjectInfo">SubjectInfo</param>
#if EnableWCF
		[OperationContract(Name = "RemoveByEntity")]
#endif
		void Remove(SubjectInfo subjectInfo);
				
		/// <summary>
		/// 保存
		/// </summary>
		/// <param name="subjectInfo">SubjectInfo</param>
#if EnableWCF
		[OperationContract]
#endif
		void Save(SubjectInfo subjectInfo);
    
		/// <summary>
		/// 根据标识获取对象
		/// </summary>
		/// <param name="id">Id</param>

#if EnableWCF
		[OperationContract]
		[FaultContract(typeof(SubjectInfoNotFoundException))]
#endif
		SubjectInfo GetById(Int32 id);

		/// <summary>
		/// 获取所有对象列表（分页，可排序）
		/// </summary>
		/// <param name="startRowIndex">起始记录号</param>
		/// <param name="maximumRows">行数</param>
		/// <param name="sortExpression">排序表达式</param>
#if EnableWCF
		[OperationContract]
#endif
		SubjectInfoList GetPagedListAll(int startRowIndex, int maximumRows, string sortExpression);
		
		/// <summary>
		/// 获取记录总数
		/// </summary>
		/// <param name="startRowIndex">起始记录号</param>
		/// <param name="maximumRows">行数</param>
		/// <param name="sortExpression">排序表达式</param>
#if EnableWCF
		[OperationContract]
#endif
		int GetRowCountAll(int startRowIndex, int maximumRows, string sortExpression);
	}
}

