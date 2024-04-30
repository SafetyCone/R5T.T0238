using System;


namespace R5T.T0238
{
    public static class Instances
    {
        public static L0066.IArrayOperator ArrayOperator => L0066.ArrayOperator.Instance;
        public static L0066.IDefaultOperator DefaultOperator => L0066.DefaultOperator.Instance;
        public static L0066.IGuidOperator GuidOperator => L0066.GuidOperator.Instance;
        public static IProjectDescriptorOperator ProjectDescriptorOperator => T0238.ProjectDescriptorOperator.Instance;
    }
}