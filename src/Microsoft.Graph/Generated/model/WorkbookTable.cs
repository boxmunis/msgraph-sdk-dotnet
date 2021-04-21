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
    /// The type Workbook Table.
    /// </summary>
    public partial class WorkbookTable : Entity
    {
    
		///<summary>
		/// The WorkbookTable constructor
		///</summary>
        public WorkbookTable()
        {
            this.ODataType = "microsoft.graph.workbookTable";
        }
	
        /// <summary>
        /// Gets or sets highlight first column.
        /// Indicates whether the first column contains special formatting.
        /// </summary>
        [JsonPropertyName("highlightFirstColumn")]
        public bool? HighlightFirstColumn { get; set; }
    
        /// <summary>
        /// Gets or sets highlight last column.
        /// Indicates whether the last column contains special formatting.
        /// </summary>
        [JsonPropertyName("highlightLastColumn")]
        public bool? HighlightLastColumn { get; set; }
    
        /// <summary>
        /// Gets or sets legacy id.
        /// Legacy Id used in older Excle clients. The value of the identifier remains the same even when the table is renamed. This property should be interpreted as an opaque string value and should not be parsed to any other type. Read-only.
        /// </summary>
        [JsonPropertyName("legacyId")]
        public string LegacyId { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Name of the table.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets show banded columns.
        /// Indicates whether the columns show banded formatting in which odd columns are highlighted differently from even ones to make reading the table easier.
        /// </summary>
        [JsonPropertyName("showBandedColumns")]
        public bool? ShowBandedColumns { get; set; }
    
        /// <summary>
        /// Gets or sets show banded rows.
        /// Indicates whether the rows show banded formatting in which odd rows are highlighted differently from even ones to make reading the table easier.
        /// </summary>
        [JsonPropertyName("showBandedRows")]
        public bool? ShowBandedRows { get; set; }
    
        /// <summary>
        /// Gets or sets show filter button.
        /// Indicates whether the filter buttons are visible at the top of each column header. Setting this is only allowed if the table contains a header row.
        /// </summary>
        [JsonPropertyName("showFilterButton")]
        public bool? ShowFilterButton { get; set; }
    
        /// <summary>
        /// Gets or sets show headers.
        /// Indicates whether the header row is visible or not. This value can be set to show or remove the header row.
        /// </summary>
        [JsonPropertyName("showHeaders")]
        public bool? ShowHeaders { get; set; }
    
        /// <summary>
        /// Gets or sets show totals.
        /// Indicates whether the total row is visible or not. This value can be set to show or remove the total row.
        /// </summary>
        [JsonPropertyName("showTotals")]
        public bool? ShowTotals { get; set; }
    
        /// <summary>
        /// Gets or sets style.
        /// Constant value that represents the Table style. Possible values are: TableStyleLight1 thru TableStyleLight21, TableStyleMedium1 thru TableStyleMedium28, TableStyleStyleDark1 thru TableStyleStyleDark11. A custom user-defined style present in the workbook can also be specified.
        /// </summary>
        [JsonPropertyName("style")]
        public string Style { get; set; }
    
        /// <summary>
        /// Gets or sets columns.
        /// Represents a collection of all the columns in the table. Read-only.
        /// </summary>
        [JsonPropertyName("columns")]
        public IWorkbookTableColumnsCollectionPage Columns { get; set; }

        /// <summary>
        /// Gets or sets columnsNextLink.
        /// </summary>
        [JsonPropertyName("columns@odata.nextLink")]
        public string ColumnsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets rows.
        /// Represents a collection of all the rows in the table. Read-only.
        /// </summary>
        [JsonPropertyName("rows")]
        public IWorkbookTableRowsCollectionPage Rows { get; set; }

        /// <summary>
        /// Gets or sets rowsNextLink.
        /// </summary>
        [JsonPropertyName("rows@odata.nextLink")]
        public string RowsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets sort.
        /// Represents the sorting for the table. Read-only.
        /// </summary>
        [JsonPropertyName("sort")]
        public WorkbookTableSort Sort { get; set; }
    
        /// <summary>
        /// Gets or sets worksheet.
        /// The worksheet containing the current table. Read-only.
        /// </summary>
        [JsonPropertyName("worksheet")]
        public WorkbookWorksheet Worksheet { get; set; }
    
    }
}

