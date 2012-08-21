using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace ByndyuSoft.Infrastructure.Common.Extensions
{
	///<summary>
	/// ����� ������� ���������� ��� ��������� �����
	///</summary>
	public static class StringExtensions
	{
		///<summary>
		/// ���������� ��������� ����� � ���� ������ ��������� �����������
		///</summary>
		///<param name="source"></param>
		///<param name="separator"></param>
		///<returns></returns>
		public static string Join(this IEnumerable<string> source, string separator)
		{
			return string.Join(separator, source);
		}

		///<summary>
		/// ���������� ��������� ����� � ���� ������ ��������� �����������
		///</summary>
		///<param name="source"></param>
		///<param name="separator"></param>
		///<returns></returns>
		public static string Join(this StringCollection source, string separator)
		{
			return string.Join(separator, source.Cast<string>());
		}
	}
}