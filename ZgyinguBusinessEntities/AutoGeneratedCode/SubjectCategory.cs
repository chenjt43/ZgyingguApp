/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	SubjectCategoryҵ��ʵ��
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
using System.Text;

#if EnableWCF
using System.Runtime.Serialization;
#endif

namespace Zkjj.Zgyinggu.BusinessEntities
{
	/// <summary>
	/// SubjectCategoryҵ��ʵ��
	/// </summary>
#if EnableWCF
	[DataContract] [Serializable]
#else
	[Serializable]
#endif
	public partial class SubjectCategory : SubjectCategoryBase
	{
		#region Constructor
		/// <summary>
		/// SubjectCategory���캯��--Ĭ��
		/// </summary>
		public SubjectCategory()
			: base()
		{
		}
		
		/// <summary>
		/// SubjectCategory���캯��--��������
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="subjectCategoryName">SubjectCategoryName</param>
		public SubjectCategory(Int32 id, String subjectCategoryName)
			: base(id, subjectCategoryName)
		{
		}
		
		#endregion Constructor
	}
	
	/// <summary>
	/// SubjectCategoryҵ��ʵ�����
	/// </summary>
#if EnableWCF
	[DataContract] [Serializable]
#else
	[Serializable]
#endif
	public abstract partial class SubjectCategoryBase
	{
		#region Constructor
		/// <summary>
		/// SubjectCategory���캯��--Ĭ��
		/// </summary>
		protected SubjectCategoryBase()
		{
		}
		
		/// <summary>
		/// SubjectCategory���캯��--��������
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="subjectCategoryName">SubjectCategoryName</param>
		protected SubjectCategoryBase(Int32 id, String subjectCategoryName)
		{
			this.idField = id;
			this.subjectCategoryNameField = subjectCategoryName;
		}
		
		#endregion Constructor
		
		#region Fields, Properties
		private Int32 idField;
		/// <summary>
		/// Id
		/// </summary>
#if EnableWCF
		[DataMember]
#endif
		public virtual Int32 Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}
		
		private String subjectCategoryNameField;
		/// <summary>
		/// SubjectCategoryName
		/// </summary>
#if EnableWCF
		[DataMember]
#endif
		public virtual String SubjectCategoryName
		{
			get
			{
				return this.subjectCategoryNameField;
			}
			set
			{
				this.subjectCategoryNameField = value;
			}
		}
		
		#endregion Fields, Properties
	}
}