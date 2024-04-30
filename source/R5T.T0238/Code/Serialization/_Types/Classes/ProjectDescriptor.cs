using System;

using R5T.T0142;


namespace R5T.T0238.Serialization
{
    /// <summary>
    /// Type that allows de-serialization of <see cref="T0238.ProjectDescriptor"/> instances (by allowing the <see cref="ProjectDescriptor.Identity"/> property to be set).
    /// </summary>
    /// <!--
    /// Prior(s):
    /// R5T.S0112.T001.ProjectDescriptor
    /// -->
    [DataTypeMarker]
    public class ProjectDescriptor
    {
        public Guid Identity { get; set; }
        public string FilePath { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// The type of the project.
        /// See <see cref="ProjectType"/>.
        /// </summary>
        public string Type { get; set; }

        public string GitHubRepositoryUrl { get; set; }
        public bool IsPrivate { get; set; }

        public string[] ProjectReferences { get; set; }


        public ProjectDescriptor()
        {

        }
    }
}
