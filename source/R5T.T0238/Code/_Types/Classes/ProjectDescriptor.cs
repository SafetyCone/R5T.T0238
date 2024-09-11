using System;

using R5T.T0142;


/// <see cref="R5T.T0238.Documentation"/>
namespace R5T.T0238
{
    /// <summary>
    /// Contains descriptors of a Visual Studio project file.
    /// </summary>
    /// <!--
    /// Prior(s):
    /// R5T.S0112.T001
    /// -->
    [DataTypeMarker]
    public class ProjectDescriptor
    {
        public Guid Identity { get; }
        public string FilePath { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// The type of the project.
        /// See <see cref="ProjectType"/> for values.
        /// </summary>
        public string Type { get; set; }

        public string GitHubRepositoryUrl { get; set; }
        public bool IsPrivate { get; set; }

        public string[] ProjectReferences { get; set; }


        /// <summary>
        /// Allow creation of project descriptor instances without identity values.
        /// </summary>
        public ProjectDescriptor()
        {

            ///
            // Do nothing.
        }

        public ProjectDescriptor(Guid identity)
        {
            this.Identity = identity;
        }
    }
}
