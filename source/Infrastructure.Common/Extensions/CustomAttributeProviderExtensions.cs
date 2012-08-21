using System;
using System.Reflection;

namespace ByndyuSoft.Infrastructure.Common.Extensions
{
	/// <summary>
	/// ������ ���������� ��� <see cref="ICustomAttributeProvider"/>
	/// </summary>
	public static class CustomAttributeProviderExtensions
	{
		///<summary>
		/// �������������������� ������ ������ GetCustomAttributes
		///</summary>
		///<param name="attributeProvider"></param>
		///<param name="inherit"></param>
		///<typeparam name="T"></typeparam>
		///<returns></returns>
		public static T[] GetCustomAttributes<T>(this ICustomAttributeProvider attributeProvider, bool inherit) where T : Attribute
		{
			return (T[])attributeProvider.GetCustomAttributes(typeof(T), inherit);
		}
	}
}