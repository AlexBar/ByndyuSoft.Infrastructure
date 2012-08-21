using System;
using System.Text;
using System.Xml.Linq;

namespace ByndyuSoft.Infrastructure.Common.Extensions
{
    /// <summary>
    ///   ���������� ��� XDocument
    /// </summary>
    public static class XDocumentExtensions
    {
        /// <summary>
        ///   ������������� �������� � XML-������
        /// </summary>
        /// <param name="document"> </param>
        /// <returns> </returns>
        public static string ToXml(this XDocument document)
        {
            return ToXml(document, Encoding.UTF8, SaveOptions.DisableFormatting);
        }

        /// <summary>
        ///   ������������� �������� � XML-������
        /// </summary>
        /// <param name="document"> �������� </param>
        /// <param name="encoding"> ��������� ��������� </param>
        /// <returns> </returns>
        public static string ToXml(this XDocument document, Encoding encoding)
        {
            return ToXml(document, encoding, SaveOptions.DisableFormatting);
        }

        /// <summary>
        ///   ������������� �������� � XML-������
        /// </summary>
        /// <param name="document"> �������� </param>
        /// <param name="options"> ����� ���������� </param>
        /// <returns> </returns>
        public static string ToXml(this XDocument document, SaveOptions options)
        {
            return ToXml(document, Encoding.UTF8, options);
        }

        /// <summary>
        ///   ������������� �������� � XML-������
        /// </summary>
        /// <param name="document"> �������� </param>
        /// <param name="encoding"> ��������� ��������� </param>
        /// <param name="options"> ����� ���������� </param>
        /// <returns> </returns>
        public static string ToXml(this XDocument document, Encoding encoding, SaveOptions options)
        {
            using (var writer = new EncodedStringWriter(encoding))
            {
                document.Save(writer, options);
                return writer.ToString();
            }
        }
    }
}