// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Power BI dataset parameter update request
    /// </summary>
    public partial class UpdateDatasetParametersRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateDatasetParametersRequest
        /// class.
        /// </summary>
        public UpdateDatasetParametersRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateDatasetParametersRequest
        /// class.
        /// </summary>
        /// <param name="updateDetails">The dataset parameter list to
        /// update</param>
        public UpdateDatasetParametersRequest(IList<UpdateDatasetParameterDetails> updateDetails)
        {
            UpdateDetails = updateDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dataset parameter list to update
        /// </summary>
        [JsonProperty(PropertyName = "updateDetails")]
        public IList<UpdateDatasetParameterDetails> UpdateDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UpdateDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UpdateDetails");
            }
            if (UpdateDetails != null)
            {
                foreach (var element in UpdateDetails)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
