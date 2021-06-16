// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Pulumipackage
{
    [PulumipackageResourceType("pulumi-package:index:Package")]
    public partial class Package : Pulumi.ComponentResource
    {
        /// <summary>
        /// Language of the pulumi package (typescript, go, c#, python).
        /// </summary>
        [Output("releases")]
        public Output<ImmutableArray<string>> Releases { get; private set; } = null!;


        /// <summary>
        /// Create a Package resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Package(string name, PackageArgs? args = null, ComponentResourceOptions? options = null)
            : base("pulumi-package:index:Package", name, args ?? new PackageArgs(), MakeResourceOptions(options, ""), remote: true)
        {
        }

        private static ComponentResourceOptions MakeResourceOptions(ComponentResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new ComponentResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = ComponentResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class PackageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Language of the pulumi package (typescript, go, c#, python).
        /// </summary>
        [Input("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Name of the pulumi package
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Name s3 bucket for plugin publication.
        /// </summary>
        [Input("serverBucketName")]
        public Input<string>? ServerBucketName { get; set; }

        /// <summary>
        /// Website endpoint for s3 plugin server
        /// </summary>
        [Input("serverBucketWebsiteEndpoint")]
        public Input<string>? ServerBucketWebsiteEndpoint { get; set; }

        public PackageArgs()
        {
        }
    }
}