using System;
using JilNs=Jil;
using Rebus.Serialization;

namespace Rebus.Config
{
    /// <summary>
    /// Configuration extensions for the Jil serializer
    /// </summary>
    public static class JilConfigurationExtensions
    {
        /// <summary>
        /// Configures Rebus to use the simple and extremely fast Jil JSON serializer. Pass an <see cref="JilNs.Options"/> object to specify 
        /// the particulars (such as <see cref="DateTime"/>/<see cref="DateTimeOffset"/> formats) of  the JSON being serialized/deserialized.
        /// If omitted <see cref="JilNs.Options.Default"/> is used, unless <see cref="JilNs.JSON.SetDefaultOptions"/> has been called with a different 
        /// <see cref="JilNs.Options"/> object.
        /// </summary>
        public static void UseJil(this StandardConfigurer<ISerializer> configurer, JilNs.Options options = null)
        {
            if (configurer == null) throw new ArgumentNullException(nameof(configurer));

            configurer.Register(c => new Jil.JilSerializer(options));
        }
    }
}