/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	SubjectCategoryҵ��ʵ���б�
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

using System.Collections;
#if EnableWCF
using System.Runtime.Serialization;
#endif

namespace Zkjj.Zgyinggu.BusinessEntities
{
	/// <summary>
	/// SubjectCategoryҵ��ʵ���б�
	/// </summary>
#if EnableWCF
	[CollectionDataContract] [Serializable]
#else
	[Serializable]
#endif
	public sealed class SubjectCategoryList : List<SubjectCategory>
	{
		/// <summary>
		/// ������������������SubjectCategory
		/// </summary>
		/// <param name="match">SubjectCategory��������</param>
		/// <returns>SubjectCategoryҵ��ʵ���б�</returns>
		public new SubjectCategoryList FindAll(Predicate<SubjectCategory> match)
		{
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			
			SubjectCategoryList list = new SubjectCategoryList();
			
			for (int i = 0; i < this.Count; i++)
			{
				if (match(this[i]))
				{
					list.Add(this[i]);
				}
			}
			
			return list;
		}
	}
}