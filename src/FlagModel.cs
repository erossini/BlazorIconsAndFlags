using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Icons
{
    /// <summary>
    /// Flag Data Model
    /// </summary>
    public class FlagModel
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the flag square.
        /// </summary>
        /// <value>
        /// The flag square.
        /// </value>
        [JsonPropertyName("flagSquare")]
        public string FlagSquare { get; set; }

        /// <summary>
        /// Gets or sets the flag wide.
        /// </summary>
        /// <value>
        /// The flag wide.
        /// </value>
        [JsonPropertyName("flagWide")]
        public string FlagWide { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FlagModel"/> is iso.
        /// </summary>
        /// <value>
        ///   <c>true</c> if iso; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("iso")]
        public bool Iso { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
