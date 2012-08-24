namespace ByndyuSoft.Infrastructure.Common.Extensions
{
	public static class RussianLanguageExtensions
	{
		/// <summary>
		/// ���������� ����� �����, ������� ���� ����� �����. ��������, 41 ����������, 42 ����������, 11 ���������
		/// </summary>
		/// <param name="value">�����, � �������� ��������� ���������������</param>
		/// <param name="oneForm">������������ �����. ��������, 41 ��� 101</param>
		/// <param name="twoForm">����� ������������ �� 2, 3 ��� 4</param>
		/// <param name="threeForm">��������� ������</param>
		/// <returns>����� + ���������� ����� ����������������</returns>
		public static string ToString(this int value, string oneForm, string twoForm, string threeForm)
		{
			if (value >= 11 && value <= 14)
				return string.Format("{0} {1}", value, threeForm);

			int lastDigit = value%10;
			if (lastDigit == 1)
				return string.Format("{0} {1}", value, oneForm);

			if (lastDigit == 2 || lastDigit == 3 || lastDigit == 4)
				return string.Format("{0} {1}", value, twoForm);

			return string.Format("{0} {1}", value, threeForm);
		}
	}
}