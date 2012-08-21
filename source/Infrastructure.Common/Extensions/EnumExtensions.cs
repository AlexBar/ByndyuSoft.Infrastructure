using System;
using System.ComponentModel;
using System.Reflection;
using JetBrains.Annotations;

namespace ByndyuSoft.Infrastructure.Common.Extensions
{
	///<summary>
	/// ������ ���������� ��� ������������
	///</summary>
	public static class EnumExtensions
	{
		/// <summary>
		/// ����� �������� �������� Description
		/// </summary>
		/// <param name="member">������� ������������</param>
		/// <returns></returns>
		[CanBeNull]
		public static string GetDescription(this Enum member)
		{
			if (member.GetType().IsEnum == false)
				throw new ArgumentOutOfRangeException("member", "member is not enum");

			FieldInfo fieldInfo = member.GetType().GetField(member.ToString());

			if (fieldInfo == null)
				return null;

			var attributes = fieldInfo.GetCustomAttributes<DescriptionAttribute>(false);

			if (attributes.Length > 0)
				return attributes[0].Description;

			return member.ToString();
		}
	}
}