using System;

using R5T.T0142;


namespace R5T.T0238
{
    /// <summary>
    /// Allows pairing two project descriptors (which is useful during comparisons or equality tests).
    /// </summary>
    /// <!--
    /// Prior(s):
    /// R5T.S0112.T001
    /// -->
    [DataTypeMarker]
    public class ProjectDescriptorPair
    {
        public string ProjectFilePath { get; set; }
        public ProjectDescriptor A { get; set; }
        public ProjectDescriptor B { get; set; }
    }
}
