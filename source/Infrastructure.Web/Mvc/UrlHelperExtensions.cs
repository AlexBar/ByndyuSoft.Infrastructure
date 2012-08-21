using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using Microsoft.Web.Mvc;

namespace ByndyuSoft.Infrastructure.Web.Mvc
{
	///<summary>
	/// ���������� ��� UrlHelper
	///</summary>
	public static class UrlHelperExtensions
	{
		///<summary>
		/// �����, ��������� �������� URL �� ��������� ���������.
		///</summary>
		///<param name="urlHelper"></param>
		///<param name="expression"></param>
		///<typeparam name="T"></typeparam>
		///<returns></returns>
		public static string Action<T>(this UrlHelper urlHelper, Expression<Action<T>> expression) where T : Controller
		{
			return LinkBuilder.BuildUrlFromExpression(urlHelper.RequestContext, urlHelper.RouteCollection, expression);
		}
	}
}