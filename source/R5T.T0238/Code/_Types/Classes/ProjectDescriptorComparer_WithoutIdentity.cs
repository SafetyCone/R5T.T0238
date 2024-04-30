using System;

using R5T.L0090.T000;
using R5T.T0142;


namespace R5T.T0238
{
    /// <summary>
    /// Compares the equality of two <see cref="ProjectDescriptor"/> instances,
    /// but without considering the identity value.
    /// This is useful for comparing instances from two separate repository systems (each of which assigned its own identity the instance).
    /// </summary>
    /// <!--
    /// Prior(s):
    /// R5T.S0112.T001.ProjectDescriptorComparer_WithoutIdentity
    /// -->
    [UtilityTypeMarker]
    public class ProjectDescriptorComparer_WithoutIdentity : IEqualityComparer<ProjectDescriptor>
    {
        #region Static

        private static readonly Lazy<ProjectDescriptorComparer_WithoutIdentity> zInstance = new(() =>
            new ProjectDescriptorComparer_WithoutIdentity());

        public static ProjectDescriptorComparer_WithoutIdentity Instance => zInstance.Value;

        #endregion


        public bool Equals(ProjectDescriptor x, ProjectDescriptor y)
        {
            var output = true
                //&& x.Identity == y.Identity // Do not compare identities.
                && x.Name == y.Name
                && x.Description == y.Description
                && x.Type == y.Type
                && x.FilePath == y.FilePath
                && x.GitHubRepositoryUrl == y.GitHubRepositoryUrl
                && x.IsPrivate == y.IsPrivate
                && Instances.ArrayOperator.Are_Equal(
                    x.ProjectReferences,
                    y.ProjectReferences,
                    (a, b) => a == b);

            return output;
        }
    }
}
