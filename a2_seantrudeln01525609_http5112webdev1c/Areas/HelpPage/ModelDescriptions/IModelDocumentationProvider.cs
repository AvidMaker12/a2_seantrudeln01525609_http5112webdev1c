using System;
using System.Reflection;

namespace a2_seantrudeln01525609_http5112webdev1c.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}