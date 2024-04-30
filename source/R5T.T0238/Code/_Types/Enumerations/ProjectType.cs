using System;

using R5T.T0142;


namespace R5T.T0238
{
    /// <summary>
    /// The conceptual types of Visual Studio projects.
    /// </summary>
    /// <!--
    /// Prior(s):
    /// R5T.F0020.ProjectType,
    /// R5T.S0112.T001
    /// -->
    [DataTypeMarker]
    public enum ProjectType
    {
        /// <summary>
        /// Default is library.
        /// </summary>
        Library = 0,

        BlazorWebClient,
        Console,
        Test,
        RazorClassLibrary,
        WebApplication,
        WindowsApplication,

        /// <summary>
        /// Allow for an unknown.
        /// </summary>
        Unknown = 999,
    }
}
