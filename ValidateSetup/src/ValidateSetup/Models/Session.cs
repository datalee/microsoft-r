// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ValidateSetup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Session
    {
        /// <summary>
        /// Initializes a new instance of the Session class.
        /// </summary>
        public Session()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Session class.
        /// </summary>
        /// <param name="id">Unique identifier representing the
        /// session.</param>
        /// <param name="name">Name of the session.</param>
        /// <param name="owner">Owner of the session.</param>
        /// <param name="runtimeType">Type of the runtime. Possible values
        /// include: 'R', 'Python'</param>
        public Session(string id = default(string), string name = default(string), string owner = default(string), RuntimeType? runtimeType = default(RuntimeType?))
        {
            Id = id;
            Name = name;
            Owner = owner;
            RuntimeType = runtimeType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier representing the session.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets name of the session.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets owner of the session.
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets type of the runtime. Possible values include: 'R',
        /// 'Python'
        /// </summary>
        [JsonProperty(PropertyName = "runtimeType")]
        public RuntimeType? RuntimeType { get; set; }

    }
}