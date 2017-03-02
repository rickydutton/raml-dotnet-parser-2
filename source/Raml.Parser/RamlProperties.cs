
using System;

namespace Raml.Parser
{
    [Serializable]
    public class RamlProperties
    {
        public string Namespace { get; set; }

        public string Source { get; set; }

        public bool? UseAsyncMethods { get; set; }

        public string ClientName { get; set; }

        public bool? IncludeApiVersionInRoutePrefix { get; set; }

        public string ModelsFolder { get; set; }

        public string ImplementationControllersFolder { get; set; }

        public bool? AddGeneratedSuffix { get; set; }

        public bool? UseLibraryNameAsNamespaceSuffix { get; set; }
        public bool? UseLibraryNameToDetermineTypeDestinationFolder { get; set; }
        public bool? UseResourceRouteAsNamespaceTarget { get; set; }
        public bool? UseResourceRouteToDetermineResourceDestinationFolder { get; set; }
        public bool? ChangeDestinationProjectIfMatchesLibraryName { get; set; }

    }
}