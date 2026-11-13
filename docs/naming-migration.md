# Generated connector naming migration

The generated managed connector and service provider APIs under `src/generated`
now follow the same naming policy as the Azure Connectors SDKs. Public C#
identifiers change; connection names, operation IDs, routes, JSON property
names and enum wire values do not. Generated models keep the wire name in
`[JsonProperty]`, and enum members keep it in `[EnumMember]`, so serialized
workflow definitions are unchanged.

This regeneration changes 729 generated files. About 12,600 renames differ only
in casing; the rest follow the rules below. Update code that references a
renamed type, method, property, parameter or enum member. The compiler reports
each one, and IntelliSense shows the new name.

## Rules and examples

| Rule | Before | After |
| --- | --- | --- |
| Acronyms of three or more letters use PascalCase | `CombinePDF`, `DownloadHTTPFile`, `EndpointURL`, `AccountURI`, `RawJSON`, `InvoiceXML`, `UTCOffset`, `SQLGenerationMode` | `CombinePdf`, `DownloadHttpFile`, `EndpointUrl`, `AccountUri`, `RawJson`, `InvoiceXml`, `UtcOffset`, `SqlGenerationMode` |
| Two-letter initialisms stay uppercase | `UTC0800PacificTimeUSCanada` | `Utc0800PacificTimeUSCanada` |
| Plural acronyms keep the plural boundary | `AppendIDsToList`, `JobIDs` | `AppendIdsToList`, `JobIds` |
| All-uppercase words use PascalCase | `INPROCESS`, `ADOBESIGN`, `NONE` | `InProcess`, `AdobeSign`, `None` |
| Known closed and compound words | `MetaData`, `Username`, `Filename` | `Metadata`, `UserName`, `FileName` |
| Product spelling | `DocuSign`, `MailChimp`, `Odata` | `Docusign`, `Mailchimp`, `OData` |
| Wire fields named `guid` keep `Guid` | `Id` (wire `Guid`) | `Guid` |
| Parameters use camelCase | `isHTML`, `username`, `Path` | `isHtml`, `userName`, `path` |

Enum members whose C# name no longer matches the wire value gain an
`[EnumMember]` attribute. For example, SAP `XML` becomes `Xml` with
`[EnumMember(Value = "XML")]`.

When two distinct wire fields normalize to the same C# name, both are kept.
A field whose name already matches keeps it, and the other receives a numeric
suffix with its wire name in `[JsonProperty]`.

## Connector namespaces and accessors

Connector namespaces and the `WorkflowManagedActions` and
`WorkflowManagedTriggers` accessors still derive from the connector API ID (for
example `Connectors.Azureblob`). One connector changes: the OData connector
moves from `Connectors.Odata`, `OdataActions`, `OdataTriggers` and `Odata(...)`
to `Connectors.OData`, `ODataActions`, `ODataTriggers` and `OData(...)`.