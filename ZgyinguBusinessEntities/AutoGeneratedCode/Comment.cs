/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	Commentҵ��ʵ��
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
	/// Commentҵ��ʵ��
	/// </summary>
#if EnableWCF
	[DataContract] [Serializable]
#else
	[Serializable]
#endif
	public partial class Comment : CommentBase
	{
		#region Constructor
		/// <summary>
		/// Comment���캯��--Ĭ��
		/// </summary>
		public Comment()
			: base()
		{
		}
		
		/// <summary>
		/// Comment���캯��--��������
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="commentContent">�ظ�����</param>
		/// <param name="subjectId">SubjectId</param>
		/// <param name="creatorId">CreatorId</param>
		/// <param name="creatorName">CreatorName</param>
		/// <param name="createTime">CreateTime</param>
		public Comment(Int32 id, String commentContent, Int32 subjectId, Int32 creatorId, String creatorName, DateTime createTime)
			: base(id, commentContent, subjectId, creatorId, creatorName, createTime)
		{
		}
		
		#endregion Constructor
	}
	
	/// <summary>
	/// Commentҵ��ʵ�����
	/// </summary>
#if EnableWCF
	[DataContract] [Serializable]
#else
	[Serializable]
#endif
	public abstract partial class CommentBase
	{
		#region Constructor
		/// <summary>
		/// Comment���캯��--Ĭ��
		/// </summary>
		protected CommentBase()
		{
		}
		
		/// <summary>
		/// Comment���캯��--��������
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="commentContent">�ظ�����</param>
		/// <param name="subjectId">SubjectId</param>
		/// <param name="creatorId">CreatorId</param>
		/// <param name="creatorName">CreatorName</param>
		/// <param name="createTime">CreateTime</param>
		protected CommentBase(Int32 id, String commentContent, Int32 subjectId, Int32 creatorId, String creatorName, DateTime createTime)
		{
			this.idField = id;
			this.commentContentField = commentContent;
			this.subjectIdField = subjectId;
			this.creatorIdField = creatorId;
			this.creatorNameField = creatorName;
			this.createTimeField = createTime;
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
		
		private String commentContentField;
		/// <summary>
		/// �ظ�����
		/// </summary>
#if EnableWCF
		[DataMember]
#endif
		public virtual String CommentContent
		{
			get
			{
				return this.commentContentField;
			}
			set
			{
				this.commentContentField = value;
			}
		}
		
		private Int32 subjectIdField;
		/// <summary>
		/// SubjectId
		/// </summary>
#if EnableWCF
		[DataMember]
#endif
		public virtual Int32 SubjectId
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
		
		private Int32 creatorIdField;
		/// <summary>
		/// CreatorId
		/// </summary>
#if EnableWCF
		[DataMember]
#endif
		public virtual Int32 CreatorId
		{
			get
			{
				return this.creatorIdField;
			}
			set
			{
				this.creatorIdField = value;
			}
		}
		
		private String creatorNameField;
		/// <summary>
		/// CreatorName
		/// </summary>
#if EnableWCF
		[DataMember]
#endif
		public virtual String CreatorName
		{
			get
			{
				return this.creatorNameField;
			}
			set
			{
				this.creatorNameField = value;
			}
		}
		
		private DateTime createTimeField;
		/// <summary>
		/// CreateTime
		/// </summary>
#if EnableWCF
		[DataMember]
#endif
		public virtual DateTime CreateTime
		{
			get
			{
				return this.createTimeField;
			}
			set
			{
				this.createTimeField = value;
			}
		}
		
		#endregion Fields, Properties
	}
}