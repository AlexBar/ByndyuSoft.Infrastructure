namespace ByndyuSoft.Infrastructure.Domain
{
	using JetBrains.Annotations;

	/// <summary>
	/// ��������� ��� ������� ��������� �������
	/// </summary>
	/// <typeparam name="T">��� ������������ �������� ��������</typeparam>
	public interface IQueryFor<out T>
	{
		/// <summary>
		/// �������� �������� �������
		/// </summary>
		/// <param name="criterion"></param>
		/// <typeparam name="TCriterion"></typeparam>
		/// <returns></returns>
		[CanBeNull]
		T With<TCriterion>(TCriterion criterion) where TCriterion : ICriterion;

		/// <summary>
		/// �������� �������� ��� ������ �������� �������� �� ��������������
		/// </summary>
		/// <param name="id">������������� �������� ��������</param>
		/// <returns>���������� ��������� �������� ��������, ���� null</returns>
		[CanBeNull]
		T ById(int id);
	}
}