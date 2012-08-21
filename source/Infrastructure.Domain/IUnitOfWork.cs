using System;

namespace ByndyuSoft.Infrastructure.Domain
{
	///<summary>
	/// ������� ������
	///</summary>
	public interface IUnitOfWork : IDisposable
	{
		///<summary>
		/// ��������� ��� ��������� � ����
		///</summary>
		void Commit();

		/// <summary>
		/// �������� �������� ��� ���������� � ����
		/// </summary>
		void Save<TEntity>(TEntity entity) where TEntity : IEntity;

		/// <summary>
		/// �������� �������� ��� �������� �� ����
		/// </summary>
		void Delete<TEntity>(TEntity entity) where TEntity : IEntity;
	}
}