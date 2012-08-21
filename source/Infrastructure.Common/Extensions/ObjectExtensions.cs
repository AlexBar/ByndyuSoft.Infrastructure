using System;
using System.ComponentModel;

namespace ByndyuSoft.Infrastructure.Common.Extensions
{
	/// <summary>
	/// ���������� ��� ����������� �����
	/// </summary>
	public static class ObjectExtensions
	{
		/// <summary>
		/// �������� �������������� ������ � ��� ������� <paramref name="converted"/>
		/// </summary>
		/// <typeparam name="T">����� ���</typeparam>
		/// <param name="toConvert">������, ������� ����� ��������������</param>
		/// <param name="converted">������, � ������� ����� ����������� �����������</param>
		/// <returns>True, ���� ����������� ������ �������, ����� false</returns>
		public static bool TryConvertInto<T>(this object toConvert, out T converted)
		{
			converted = default(T);

			if (toConvert == null || string.IsNullOrEmpty(toConvert.ToString()))
				return false;

			TypeConverter converter = TypeDescriptor.GetConverter(typeof (T));
			if (converter.IsValid(toConvert))
			{
				try
				{
					converted = (T) converter.ConvertFromInvariantString(toConvert.ToString());
					return true;
				}
				catch
				{
				}
			}
			return false;
		}

		/// <summary>
		/// �������� �������������� ������ � ��� ������� <paramref name="{T}"/>
		/// </summary>
		/// <typeparam name="T">����� ���</typeparam>
		/// <param name="toConvert">������, ������� ����� ��������������</param>
		/// <returns>True, ���� ����������� ������ �������, ����� false</returns>
		public static T Value<T>(this object toConvert)
		{
			T result;

			if (toConvert == null ||
			    string.IsNullOrEmpty(toConvert.ToString()) ||
			    !toConvert.TryConvertInto(out result))
				return default(T);

			return result;
		}

		/// <summary>
		/// Check is value empty or not
		/// </summary>
		/// <param name="toCheck">������ �����</param>
		/// <returns>True, ���� ������ ����� null ��� �� �������� ���������, ����� false</returns>
		public static bool IsEmptyObject(this object toCheck)
		{
			return toCheck == null || string.IsNullOrEmpty(toCheck.ToString());
		}
	}
}