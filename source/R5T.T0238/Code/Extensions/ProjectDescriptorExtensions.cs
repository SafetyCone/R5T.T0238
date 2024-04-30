using System;
using System.Collections.Generic;
using System.Linq;

using SerializationType = R5T.T0238.Serialization.ProjectDescriptor;


namespace R5T.T0238.Extensions
{
    public static class ProjectDescriptorExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <!--
        /// Prior(s):
        /// R5T.S0112.T001.ProjectDescriptorExtensions.To_SerializationType()
        /// -->
        public static SerializationType To_SerializationType(this ProjectDescriptor projectDescriptor)
            => Instances.ProjectDescriptorOperator.To_SerializationType(projectDescriptor);

        /// <summary>
        /// 
        /// </summary>
        /// <!--
        /// Prior(s):
        /// R5T.S0112.T001.ProjectDescriptorExtensions.From_SerializationType()
        /// -->
        public static ProjectDescriptor From_SerializationType(this SerializationType projectDescriptor)
            => Instances.ProjectDescriptorOperator.From_SerializationType(projectDescriptor);

        /// <summary>
        /// 
        /// </summary>
        /// <!--
        /// Prior(s):
        /// R5T.S0112.T001.ProjectDescriptorExtensions.To_ProjectDescriptor()
        /// -->
        public static ProjectDescriptor To_ProjectDescriptor(this SerializationType projectDescriptor)
            => Instances.ProjectDescriptorOperator.From_SerializationType(projectDescriptor);

        /// <summary>
        /// 
        /// </summary>
        /// <!--
        /// Prior(s):
        /// R5T.S0112.T001.ProjectDescriptorExtensions.To_ProjectDescriptors()
        /// -->
        public static IEnumerable<ProjectDescriptor> To_ProjectDescriptors(this IEnumerable<SerializationType> projectDescriptors)
            => projectDescriptors
                .Select(Instances.ProjectDescriptorOperator.From_SerializationType)
                ;
                
    }
}
