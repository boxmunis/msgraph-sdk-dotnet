// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Planner User.
    /// </summary>
    public partial class PlannerUser : Entity
    {
    
		///<summary>
		/// The PlannerUser constructor
		///</summary>
        public PlannerUser()
        {
            this.ODataType = "microsoft.graph.plannerUser";
        }
	
        /// <summary>
        /// Gets or sets plans.
        /// Read-only. Nullable. Returns the plannerTasks assigned to the user.
        /// </summary>
        [JsonPropertyName("plans")]
        public IPlannerUserPlansCollectionPage Plans { get; set; }

        /// <summary>
        /// Gets or sets plansNextLink.
        /// </summary>
        [JsonPropertyName("plans@odata.nextLink")]
        public string PlansNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// Read-only. Nullable. Returns the plannerTasks assigned to the user.
        /// </summary>
        [JsonPropertyName("tasks")]
        public IPlannerUserTasksCollectionPage Tasks { get; set; }

        /// <summary>
        /// Gets or sets tasksNextLink.
        /// </summary>
        [JsonPropertyName("tasks@odata.nextLink")]
        public string TasksNextLink { get; set; }
    
    }
}

