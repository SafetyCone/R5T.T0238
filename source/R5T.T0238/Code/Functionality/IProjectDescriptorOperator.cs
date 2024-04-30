using System;

using R5T.T0132;

using SerializationType = R5T.T0238.Serialization.ProjectDescriptor;


namespace R5T.T0238
{
    [FunctionalityMarker]
    public partial interface IProjectDescriptorOperator : IFunctionalityMarker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <!--
        /// Prior(s):
        /// R5T.S0112.T001.IProjectDescriptorOperator.From_SerializationType()
        /// -->
        public ProjectDescriptor From_SerializationType(SerializationType projectDescriptor)
        {
            var output = new ProjectDescriptor(projectDescriptor.Identity)
            {
                FilePath = projectDescriptor.FilePath,
                Name = projectDescriptor.Name,
                Description = projectDescriptor.Description,
                Type = projectDescriptor.Type,
                GitHubRepositoryUrl = projectDescriptor.GitHubRepositoryUrl,
                IsPrivate = projectDescriptor.IsPrivate,
                ProjectReferences = projectDescriptor.ProjectReferences
            };

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!--
        /// Prior(s):
        /// R5T.S0112.T001.IProjectDescriptorOperator.To_SerializationType()
        /// -->
        public SerializationType To_SerializationType(ProjectDescriptor projectDescriptor)
        {
            var output = new SerializationType
            {
                Identity = projectDescriptor.Identity,
                FilePath = projectDescriptor.FilePath,
                Name = projectDescriptor.Name,
                Description = projectDescriptor.Description,
                Type = projectDescriptor.Type,
                GitHubRepositoryUrl = projectDescriptor.GitHubRepositoryUrl,
                IsPrivate = projectDescriptor.IsPrivate,
                ProjectReferences = projectDescriptor.ProjectReferences
            };

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!--
        /// Prior(s):
        /// R5T.S0112.T001.IProjectDescriptorOperator.Verify_IdentityNotSet()
        /// -->
        public void Verify_IdentityNotSet(ProjectDescriptor projectDescriptor)
        {
            var identityIsDefault = Instances.DefaultOperator.Is_Default(projectDescriptor.Identity);
            if (!identityIsDefault)
            {
                throw new Exception("Project identity must not be set (must be the default value).");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!--
        /// Prior(s):
        /// R5T.S0112.T001.IProjectDescriptorOperator.Clone_Set_Data()
        /// -->
        public void Clone_Set_Data(
            ProjectDescriptor source,
            ProjectDescriptor destination)
        {
            destination.Description = source.Description;
            destination.FilePath = source.FilePath;
            destination.GitHubRepositoryUrl = source.GitHubRepositoryUrl;
            destination.Name = source.Name;
            destination.ProjectReferences = source.ProjectReferences;
            destination.Type = source.Type;
            destination.IsPrivate = source.IsPrivate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!--
        /// Prior(s):
        /// R5T.S0112.T001.IProjectDescriptorOperator.Clone_Set_Identity()
        /// -->
        public ProjectDescriptor Clone_Set_Identity(
            ProjectDescriptor projectDescriptor,
            Guid identity)
        {
            var output = new ProjectDescriptor(identity);

            this.Clone_Set_Data(
                projectDescriptor,
                output);

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!--
        /// Prior(s):
        /// R5T.S0112.T001.IProjectDescriptorOperator.Clone_Set_Identity()
        /// -->
        public ProjectDescriptor Clone_Set_Identity(ProjectDescriptor projectDescriptor)
        {
            var identity = Instances.GuidOperator.New();

            var output = this.Clone_Set_Identity(
                projectDescriptor,
                identity);

            return output;
        }
    }
}
