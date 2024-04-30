using System;


namespace R5T.T0238
{
    public class ProjectDescriptorOperator : IProjectDescriptorOperator
    {
        #region Infrastructure

        public static IProjectDescriptorOperator Instance { get; } = new ProjectDescriptorOperator();


        private ProjectDescriptorOperator()
        {
        }

        #endregion
    }
}
