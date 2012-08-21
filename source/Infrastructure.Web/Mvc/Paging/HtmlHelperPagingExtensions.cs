using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace ByndyuSoft.Infrastructure.Web.Mvc.Paging
{
    ///<summary>
    ///</summary>
    public static class HtmlHelperPagingExtensions
    {
        #region HtmlHelper extensions

        /// <summary>
        /// ������� �������
        /// </summary>
        /// <param name="htmlHelper"><see cref="HtmlHelper"/></param>
        /// <param name="pageInfo"></param>
        /// <returns>HTML ����� � ���������</returns>
        public static string Pager(this HtmlHelper htmlHelper, PageInfo pageInfo)
        {
            ViewContext controllerContext = htmlHelper.ViewContext;
            RouteValueDictionary routeValueDictionary = controllerContext.RouteData.Values;

            return new Pager(controllerContext.RequestContext, routeValueDictionary, pageInfo)
                .RenderHtml();
        }

        /// <summary>
        /// ������� �������
        /// </summary>
        /// <param name="htmlHelper"><see cref="HtmlHelper"/></param>
        /// <param name="pageInfo"></param>
        /// <param name="values">�������������� ��������� ��� ��������</param>
        /// <returns>HTML ����� � ���������</returns>
        public static string Pager(this HtmlHelper htmlHelper, PageInfo pageInfo, object values)
        {
            ViewContext controllerContext = htmlHelper.ViewContext;
            var routeValueDictionary = new RouteValueDictionary(values);

            return new Pager(controllerContext.RequestContext, routeValueDictionary, pageInfo)
                .RenderHtml();
        }

        /// <summary>
        /// ������� �������
        /// </summary>
        /// <param name="htmlHelper"><see cref="HtmlHelper"/></param>
        /// <param name="pageInfo"></param>
        /// <param name="actionName">��� ��������, ������� ���������� ������� �� ���������� ��������</param>
        /// <param name="values">�������������� ��������� ��� ��������</param>
        /// <returns>HTML ����� � ���������</returns>
        public static string Pager(this HtmlHelper htmlHelper, PageInfo pageInfo, string actionName, object values)
        {
            var valuesDictionary = new RouteValueDictionary(values);
            if (actionName != null)
            {
                if (valuesDictionary.ContainsKey("action"))
                    throw new ArgumentException("The valuesDictionary already contains an action.", "actionName");

                valuesDictionary.Add("action", actionName);
            }

            ControllerContext controllerContext = htmlHelper.ViewContext;
            return new Pager(controllerContext.RequestContext, valuesDictionary, pageInfo)
                .RenderHtml();
        }

        /// <summary>
        /// ������� �������
        /// </summary>
        /// <param name="htmlHelper"><see cref="HtmlHelper"/></param>
        /// <param name="pageInfo"></param>
        /// <param name="actionName">��� ��������, ������� ���������� ������� �� ���������� ��������</param>
        /// <param name="controllerName">��� �����������</param>
        /// <param name="values">�������������� ��������� ��� ��������</param>
        /// <returns>HTML ����� � ���������</returns>
        public static string Pager(this HtmlHelper htmlHelper, PageInfo pageInfo, string actionName, string controllerName, object values)
        {
            var valuesDictionary = new RouteValueDictionary(values);
            if (actionName != null)
            {
                if (valuesDictionary.ContainsKey("action"))
                    throw new ArgumentException("The valuesDictionary already contains an action.", "actionName");

                valuesDictionary.Add("action", actionName);
            }
            if (controllerName != null)
            {
                if (valuesDictionary.ContainsKey("controller"))
                    throw new ArgumentException("The valuesDictionary already contains an controller.", "controllerName");

                valuesDictionary.Add("controller", controllerName);
            }

            ControllerContext controllerContext = htmlHelper.ViewContext;
            return new Pager(controllerContext.RequestContext, valuesDictionary, pageInfo)
                .RenderHtml();
        }

        #endregion
    }
}