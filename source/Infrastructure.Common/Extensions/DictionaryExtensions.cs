using System;
using System.Collections.Generic;

namespace ByndyuSoft.Infrastructure.Common.Extensions
{
	///<summary>
	/// ������ ���������� ��� <see cref="IDictionary{TKey,TValue}"/>
	///</summary>
	public static class DictionaryExtensions
	{
		/// <summary>
		/// ����� ��������� �������� �� �������
		/// </summary>
		/// <typeparam name="TKey">��� �����</typeparam>
		/// <typeparam name="TValue">��� ��������</typeparam>
		/// <param name="dictionary">�������</param>
		/// <param name="key">����</param>
		/// <returns>�������� �� ������� ��� �������� �� ���������, ���� ���� �� ������ � �������</returns>
		public static TValue Get<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
		{
			TValue result;
		    dictionary.TryGetValue(key, out result);
		    return result;
		}

		/// <summary>
		/// ����� ��������� �������� �� �������
		/// </summary>
		/// <typeparam name="TKey">��� �����</typeparam>
		/// <typeparam name="TValue">��� ��������</typeparam>
		/// <param name="dictionary">�������</param>
		/// <param name="key">����</param>
		/// <param name="defaultValue">�������� �� ���������</param>
		/// <returns>�������� �� ������� ��� �������� �� ���������, ���� ���� �� ������ � �������</returns>
		public static TValue Get<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
		{
			TValue result;
			return dictionary.TryGetValue(key, out result) ? result : defaultValue;
		}

		/// <summary>
		/// ����� ��������� �������� �� �������
		/// </summary>
		/// <typeparam name="TKey">��� �����</typeparam>
		/// <typeparam name="TValue">��� ��������</typeparam>
		/// <param name="dictionary">�������</param>
		/// <param name="key">����</param>
		/// <param name="defaultValue">������� ��� ��������� �������� �� ���������</param>
		/// <returns>�������� �� ������� ��� �������� �� ���������, ���� ���� �� ������ � �������</returns>
		public static TValue Get<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> defaultValue)
		{
			TValue result;
			return dictionary.TryGetValue(key, out result) ? result : defaultValue();
		}
	}
}