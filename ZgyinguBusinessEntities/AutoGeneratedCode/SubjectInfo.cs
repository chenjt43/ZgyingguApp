/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	SubjectInfoҵ��ʵ��
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
	/// SubjectInfoҵ��ʵ��
	/// </summary>
#if EnableWCF
	[DataContract] [Serializable]
#else
	[Serializable]
#endif
	public partial class SubjectInfo : SubjectInfoBase
	{
		#region Constructor
		/// <summary>
		/// SubjectInfo���캯��--Ĭ��
		/// </summary>
		public SubjectInfo()
			: base()
		{
		}
		
		/// <summary>
		/// SubjectInfo���캯��--��������
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="subjectId">SubjectId</param>
		/// <param name="fileName">FileName</param>
		/// <param name="fileUrl">FileUrl</param>
		public SubjectInfo(Int32 id, Int32? subjectId, String fileName, String fileUrl)
			: base(id, subjectId, fileName, fileUrl)
		{
		}
		
		#endregion Constructor
	}
	
	/// <summary>
	/// SubjectInfoҵ��ʵ�����
	/// </summary>
#if EnableWCF
	[DataContract] [Serializable]
#else
	[Serializable]
#endif
	public abstract partial class SubjectInfoBase
	{
		#region Constructor
		/// <summary>
		/// SubjectInfo���캯��--Ĭ��
		/// </summary>
		protected SubjectInfoBase()
		{
		}
		
		/// <summary>
		/// SubjectInfo���캯��--��������
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="subjectId">SubjectId</param>
		/// <param name="fileName">FileName</param>
		/// <param name="fileUrl">FileUrl</param>
		protected SubjectInfoBase(Int32 id, Int32? subjectId, String fileName, String fileUrl)
		{
			this.idField = id;
			this.subjectIdField = subjectId;
			this.fileNameField = fileName;
			this.fileUrlField = fileUrl;
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
		
		private Int32? subjectIdField;
		/// <summary>
		/// SubjectId
		/// </summary>
#if EnableWCF
		[DataMember]
#endif
		public virtual Int32? SubjectId
		{
			get
			{
				return this.subjectIdField;
			}
			set
			{
				this.subjectIdField = value;
			}
		}
		
		private String fileNameField;
		/// <summary>
		/// FileName
		/// </summary>
#if EnableWCF
		[DataMember]
#endif
		public virtual String FileName
		{
			get
			{
				return this.fileNameField;
			}
			set
			{
				this.fileNameField = value;
			}
		}
		
		private String fileUrlField;
		/// <summary>
		/// FileUrl
		/// </summary>
#if EnableWCF
		[DataMember]
#endif
		public virtual String FileUrl
		{
			get
			{
				return this.fileUrlField;
			}
			set
			{
				this.fileUrlField = value;
			}
		}
		
		#endregion Fields, Properties
	}
}