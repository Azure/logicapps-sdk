//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thebronnoysundregistries
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThebronnoysundregistriesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebronnoysundregistries")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllSearch))]
        public IBodyWorkflowAction<GetAllSearchResponse> GetAllSearch([WorkflowExpression] Func<string> navn = null, [WorkflowExpression] Func<string> fraRegistreringsdatoEnhetsregisteret = null, [WorkflowExpression] Func<string> tilRegistreringsdatoEnhetsregisteret = null, [WorkflowExpression] Func<bool> konkurs = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllSearchResponse> __BuildGetAllSearch(WorkflowValue<string> navn = null, WorkflowValue<string> fraRegistreringsdatoEnhetsregisteret = null, WorkflowValue<string> tilRegistreringsdatoEnhetsregisteret = null, WorkflowValue<bool> konkurs = null, WorkflowValue<string> sort = null)
        {
            WorkflowValue.Validate(navn, nameof(navn), required: false);
            WorkflowValue.Validate(fraRegistreringsdatoEnhetsregisteret, nameof(fraRegistreringsdatoEnhetsregisteret), required: false);
            WorkflowValue.Validate(tilRegistreringsdatoEnhetsregisteret, nameof(tilRegistreringsdatoEnhetsregisteret), required: false);
            WorkflowValue.Validate(konkurs, nameof(konkurs), required: false);
            WorkflowValue.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetAllSearchResponse>(() =>
            {
                var apiCallPath = "/enhetsregisteret/api/enheter";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (navn != null)
                    callPayload.Queries["navn"] = ExpressionConverter.Convert(navn);
                if (fraRegistreringsdatoEnhetsregisteret != null)
                    callPayload.Queries["fraRegistreringsdatoEnhetsregisteret"] = ExpressionConverter.Convert(fraRegistreringsdatoEnhetsregisteret);
                if (tilRegistreringsdatoEnhetsregisteret != null)
                    callPayload.Queries["tilRegistreringsdatoEnhetsregisteret"] = ExpressionConverter.Convert(tilRegistreringsdatoEnhetsregisteret);
                if (konkurs != null)
                    callPayload.Queries["konkurs"] = ExpressionConverter.Convert(konkurs);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<GetAllSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebronnoysundregistries")]
        [WorkflowExpressionFactory(nameof(__BuildGetByOrganizationNumber))]
        public IBodyWorkflowAction<GetByOrganizationNumberResponse> GetByOrganizationNumber([WorkflowExpression] Func<string> orgnr)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetByOrganizationNumberResponse> __BuildGetByOrganizationNumber(WorkflowValue<string> orgnr)
        {
            WorkflowValue.Validate(orgnr, nameof(orgnr), required: true);
            return new DeferredBodyAction<GetByOrganizationNumberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/enhetsregisteret/api/enheter/{0}", ExpressionConverter.ConvertWithUrlEncoding(orgnr, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetByOrganizationNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebronnoysundregistries")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntityRoles))]
        public IBodyWorkflowAction<GetEntityRolesResponse> GetEntityRoles([WorkflowExpression] Func<string> orgnr)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEntityRolesResponse> __BuildGetEntityRoles(WorkflowValue<string> orgnr)
        {
            WorkflowValue.Validate(orgnr, nameof(orgnr), required: true);
            return new DeferredBodyAction<GetEntityRolesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/enhetsregisteret/api/enheter/{0}/roller", ExpressionConverter.ConvertWithUrlEncoding(orgnr, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetEntityRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebronnoysundregistries")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllSearchSub))]
        public IBodyWorkflowAction<GetAllSearchSubResponse> GetAllSearchSub([WorkflowExpression] Func<string> navn = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllSearchSubResponse> __BuildGetAllSearchSub(WorkflowValue<string> navn = null, WorkflowValue<string> sort = null)
        {
            WorkflowValue.Validate(navn, nameof(navn), required: false);
            WorkflowValue.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetAllSearchSubResponse>(() =>
            {
                var apiCallPath = "/enhetsregisteret/api/underenheter";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (navn != null)
                    callPayload.Queries["navn"] = ExpressionConverter.Convert(navn);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<GetAllSearchSubResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebronnoysundregistries")]
        [WorkflowExpressionFactory(nameof(__BuildGetSubByOrganizationNumber))]
        public IBodyWorkflowAction<GetSubByOrganizationNumberResponse> GetSubByOrganizationNumber([WorkflowExpression] Func<string> orgnr)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSubByOrganizationNumberResponse> __BuildGetSubByOrganizationNumber(WorkflowValue<string> orgnr)
        {
            WorkflowValue.Validate(orgnr, nameof(orgnr), required: true);
            return new DeferredBodyAction<GetSubByOrganizationNumberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/enhetsregisteret/api/underenheter/{0}", ExpressionConverter.ConvertWithUrlEncoding(orgnr, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSubByOrganizationNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebronnoysundregistries")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntitiesUpdates))]
        public IBodyWorkflowAction<GetEntitiesUpdatesResponse> GetEntitiesUpdates([WorkflowExpression] Func<string> dato = null, [WorkflowExpression] Func<int> oppdateringsid = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEntitiesUpdatesResponse> __BuildGetEntitiesUpdates(WorkflowValue<string> dato = null, WorkflowValue<int> oppdateringsid = null)
        {
            WorkflowValue.Validate(dato, nameof(dato), required: false);
            WorkflowValue.Validate(oppdateringsid, nameof(oppdateringsid), required: false);
            return new DeferredBodyAction<GetEntitiesUpdatesResponse>(() =>
            {
                var apiCallPath = "/enhetsregisteret/api/oppdateringer/enheter";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (dato != null)
                    callPayload.Queries["dato"] = ExpressionConverter.Convert(dato);
                if (oppdateringsid != null)
                    callPayload.Queries["oppdateringsid"] = ExpressionConverter.Convert(oppdateringsid);
                return new ApiConnectionAction<GetEntitiesUpdatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebronnoysundregistries")]
        [WorkflowExpressionFactory(nameof(__BuildGetSubEntitiesUpdates))]
        public IBodyWorkflowAction<GetSubEntitiesUpdatesResponse> GetSubEntitiesUpdates([WorkflowExpression] Func<string> dato = null, [WorkflowExpression] Func<int> oppdateringsid = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSubEntitiesUpdatesResponse> __BuildGetSubEntitiesUpdates(WorkflowValue<string> dato = null, WorkflowValue<int> oppdateringsid = null)
        {
            WorkflowValue.Validate(dato, nameof(dato), required: false);
            WorkflowValue.Validate(oppdateringsid, nameof(oppdateringsid), required: false);
            return new DeferredBodyAction<GetSubEntitiesUpdatesResponse>(() =>
            {
                var apiCallPath = "/enhetsregisteret/api/oppdateringer/underenheter";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (dato != null)
                    callPayload.Queries["dato"] = ExpressionConverter.Convert(dato);
                if (oppdateringsid != null)
                    callPayload.Queries["oppdateringsid"] = ExpressionConverter.Convert(oppdateringsid);
                return new ApiConnectionAction<GetSubEntitiesUpdatesResponse>(callPayload);
            });
        }
    }

    public class ThebronnoysundregistriesTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAllSearchResponse
    {
        [JsonProperty("_embedded")]
        public GetAllSearchResponseEmbeddedType Embedded { get; set; }

        [JsonProperty("_links")]
        public GetAllSearchResponseLinksType Links { get; set; }

        [JsonProperty("page")]
        public GetAllSearchResponsePageType Page { get; set; }
    }

    public class GetAllSearchResponseEmbeddedType
    {
        [JsonProperty("enheter")]
        public GetAllSearchResponseEmbeddedTypeEnheterTypeItem[] Enheter { get; set; }
    }

    public class GetAllSearchResponseEmbeddedTypeEnheterTypeItem
    {
        [JsonProperty("organisasjonsnummer")]
        public string Organisasjonsnummer { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }

        [JsonProperty("organisasjonsform")]
        public GetAllSearchResponseEmbeddedTypeEnheterTypeItemOrganisasjonsformType Organisasjonsform { get; set; }

        [JsonProperty("postadresse")]
        public GetAllSearchResponseEmbeddedTypeEnheterTypeItemPostadresseType Postadresse { get; set; }

        [JsonProperty("registreringsdatoEnhetsregisteret")]
        public string RegistreringsdatoEnhetsregisteret { get; set; }

        [JsonProperty("registrertIMvaregisteret")]
        public bool RegistrertIMvaregisteret { get; set; }

        [JsonProperty("naeringskode1")]
        public GetAllSearchResponseEmbeddedTypeEnheterTypeItemNaeringskode1Type Naeringskode1 { get; set; }

        [JsonProperty("antallAnsatte")]
        public int AntallAnsatte { get; set; }

        [JsonProperty("forretningsadresse")]
        public GetAllSearchResponseEmbeddedTypeEnheterTypeItemForretningsadresseType Forretningsadresse { get; set; }

        [JsonProperty("stiftelsesdato")]
        public string Stiftelsesdato { get; set; }

        [JsonProperty("registrertIForetaksregisteret")]
        public bool RegistrertIForetaksregisteret { get; set; }

        [JsonProperty("registrertIStiftelsesregisteret")]
        public bool RegistrertIStiftelsesregisteret { get; set; }

        [JsonProperty("registrertIFrivillighetsregisteret")]
        public bool RegistrertIFrivillighetsregisteret { get; set; }

        [JsonProperty("konkurs")]
        public bool Konkurs { get; set; }

        [JsonProperty("underAvvikling")]
        public bool UnderAvvikling { get; set; }

        [JsonProperty("underTvangsavviklingEllerTvangsopplosning")]
        public bool UnderTvangsavviklingEllerTvangsopplosning { get; set; }

        [JsonProperty("maalform")]
        public string Maalform { get; set; }

        [JsonProperty("_links")]
        public GetAllSearchResponseEmbeddedTypeEnheterTypeItemLinksType Links { get; set; }
    }

    public class GetAllSearchResponseEmbeddedTypeEnheterTypeItemOrganisasjonsformType
    {
        [JsonProperty("kode")]
        public string Kode { get; set; }

        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("_links")]
        public GetAllSearchResponseEmbeddedTypeEnheterTypeItemOrganisasjonsformTypeLinksType Links { get; set; }
    }

    public class GetAllSearchResponseEmbeddedTypeEnheterTypeItemOrganisasjonsformTypeLinksType
    {
        [JsonProperty("self")]
        public GetAllSearchResponseEmbeddedTypeEnheterTypeItemOrganisasjonsformTypeLinksTypeSelfType Self { get; set; }
    }

    public class GetAllSearchResponseEmbeddedTypeEnheterTypeItemOrganisasjonsformTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetAllSearchResponseEmbeddedTypeEnheterTypeItemPostadresseType
    {
        [JsonProperty("land")]
        public string Land { get; set; }

        [JsonProperty("landkode")]
        public string Landkode { get; set; }

        [JsonProperty("postnummer")]
        public string Postnummer { get; set; }

        [JsonProperty("poststed")]
        public string Poststed { get; set; }

        [JsonProperty("adresse")]
        public string[] Adresse { get; set; }

        [JsonProperty("kommune")]
        public string Kommune { get; set; }

        [JsonProperty("kommunenummer")]
        public string Kommunenummer { get; set; }
    }

    public class GetAllSearchResponseEmbeddedTypeEnheterTypeItemNaeringskode1Type
    {
        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("kode")]
        public string Kode { get; set; }
    }

    public class GetAllSearchResponseEmbeddedTypeEnheterTypeItemForretningsadresseType
    {
        [JsonProperty("land")]
        public string Land { get; set; }

        [JsonProperty("landkode")]
        public string Landkode { get; set; }

        [JsonProperty("postnummer")]
        public string Postnummer { get; set; }

        [JsonProperty("poststed")]
        public string Poststed { get; set; }

        [JsonProperty("adresse")]
        public string[] Adresse { get; set; }

        [JsonProperty("kommune")]
        public string Kommune { get; set; }

        [JsonProperty("kommunenummer")]
        public string Kommunenummer { get; set; }
    }

    public class GetAllSearchResponseEmbeddedTypeEnheterTypeItemLinksType
    {
        [JsonProperty("self")]
        public GetAllSearchResponseEmbeddedTypeEnheterTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class GetAllSearchResponseEmbeddedTypeEnheterTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetAllSearchResponseLinksType
    {
        [JsonProperty("self")]
        public GetAllSearchResponseLinksTypeSelfType Self { get; set; }
    }

    public class GetAllSearchResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetAllSearchResponsePageType
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class GetByOrganizationNumberResponse
    {
        [JsonProperty("organisasjonsnummer")]
        public string Organisasjonsnummer { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }

        [JsonProperty("organisasjonsform")]
        public GetByOrganizationNumberResponseOrganisasjonsformType Organisasjonsform { get; set; }

        [JsonProperty("postadresse")]
        public GetByOrganizationNumberResponsePostadresseType Postadresse { get; set; }

        [JsonProperty("registreringsdatoEnhetsregisteret")]
        public string RegistreringsdatoEnhetsregisteret { get; set; }

        [JsonProperty("registrertIMvaregisteret")]
        public bool RegistrertIMvaregisteret { get; set; }

        [JsonProperty("naeringskode1")]
        public GetByOrganizationNumberResponseNaeringskode1Type Naeringskode1 { get; set; }

        [JsonProperty("antallAnsatte")]
        public int AntallAnsatte { get; set; }

        [JsonProperty("forretningsadresse")]
        public GetByOrganizationNumberResponseForretningsadresseType Forretningsadresse { get; set; }

        [JsonProperty("stiftelsesdato")]
        public string Stiftelsesdato { get; set; }

        [JsonProperty("registrertIForetaksregisteret")]
        public bool RegistrertIForetaksregisteret { get; set; }

        [JsonProperty("registrertIStiftelsesregisteret")]
        public bool RegistrertIStiftelsesregisteret { get; set; }

        [JsonProperty("registrertIFrivillighetsregisteret")]
        public bool RegistrertIFrivillighetsregisteret { get; set; }

        [JsonProperty("konkurs")]
        public bool Konkurs { get; set; }

        [JsonProperty("underAvvikling")]
        public bool UnderAvvikling { get; set; }

        [JsonProperty("underTvangsavviklingEllerTvangsopplosning")]
        public bool UnderTvangsavviklingEllerTvangsopplosning { get; set; }

        [JsonProperty("maalform")]
        public string Maalform { get; set; }

        [JsonProperty("_links")]
        public GetByOrganizationNumberResponseLinksType Links { get; set; }

        [JsonProperty("slettedato")]
        public string Slettedato { get; set; }
    }

    public class GetByOrganizationNumberResponseOrganisasjonsformType
    {
        [JsonProperty("kode")]
        public string Kode { get; set; }

        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("_links")]
        public GetByOrganizationNumberResponseOrganisasjonsformTypeLinksType Links { get; set; }

        [JsonProperty("utgaatt")]
        public string Utgaatt { get; set; }
    }

    public class GetByOrganizationNumberResponseOrganisasjonsformTypeLinksType
    {
        [JsonProperty("self")]
        public GetByOrganizationNumberResponseOrganisasjonsformTypeLinksTypeSelfType Self { get; set; }
    }

    public class GetByOrganizationNumberResponseOrganisasjonsformTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetByOrganizationNumberResponsePostadresseType
    {
        [JsonProperty("land")]
        public string Land { get; set; }

        [JsonProperty("landkode")]
        public string Landkode { get; set; }

        [JsonProperty("postnummer")]
        public string Postnummer { get; set; }

        [JsonProperty("poststed")]
        public string Poststed { get; set; }

        [JsonProperty("adresse")]
        public string[] Adresse { get; set; }

        [JsonProperty("kommune")]
        public string Kommune { get; set; }

        [JsonProperty("kommunenummer")]
        public string Kommunenummer { get; set; }
    }

    public class GetByOrganizationNumberResponseNaeringskode1Type
    {
        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("kode")]
        public string Kode { get; set; }
    }

    public class GetByOrganizationNumberResponseForretningsadresseType
    {
        [JsonProperty("land")]
        public string Land { get; set; }

        [JsonProperty("landkode")]
        public string Landkode { get; set; }

        [JsonProperty("postnummer")]
        public string Postnummer { get; set; }

        [JsonProperty("poststed")]
        public string Poststed { get; set; }

        [JsonProperty("adresse")]
        public string[] Adresse { get; set; }

        [JsonProperty("kommune")]
        public string Kommune { get; set; }

        [JsonProperty("kommunenummer")]
        public string Kommunenummer { get; set; }
    }

    public class GetByOrganizationNumberResponseLinksType
    {
        [JsonProperty("self")]
        public GetByOrganizationNumberResponseLinksTypeSelfType Self { get; set; }
    }

    public class GetByOrganizationNumberResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetEntityRolesResponse
    {
        [JsonProperty("rollegrupper")]
        public GetEntityRolesResponseRollegrupperTypeItem[] Rollegrupper { get; set; }

        [JsonProperty("_links")]
        public GetEntityRolesResponseLinksType Links { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItem
    {
        [JsonProperty("type")]
        public GetEntityRolesResponseRollegrupperTypeItemTypeType Type { get; set; }

        [JsonProperty("sistEndret")]
        public string SistEndret { get; set; }

        [JsonProperty("roller")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItem[] Roller { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemTypeType
    {
        [JsonProperty("kode")]
        public string Kode { get; set; }

        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("_links")]
        public GetEntityRolesResponseRollegrupperTypeItemTypeTypeLinksType Links { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemTypeTypeLinksType
    {
        [JsonProperty("self")]
        public GetEntityRolesResponseRollegrupperTypeItemTypeTypeLinksTypeSelfType Self { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemTypeTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItem
    {
        [JsonProperty("type")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemTypeType Type { get; set; }

        [JsonProperty("person")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemPersonType Person { get; set; }

        [JsonProperty("enhet")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetType Enhet { get; set; }

        [JsonProperty("fullmektige")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemFullmektigeTypeItem[] Fullmektige { get; set; }

        [JsonProperty("ansvarsandel")]
        public string Ansvarsandel { get; set; }

        [JsonProperty("valgtAv")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemValgtAvType ValgtAv { get; set; }

        [JsonProperty("fratraadt")]
        public bool Fratraadt { get; set; }

        [JsonProperty("rekkefolge")]
        public int Rekkefolge { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemTypeType
    {
        [JsonProperty("kode")]
        public string Kode { get; set; }

        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("_links")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemTypeTypeLinksType Links { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemTypeTypeLinksType
    {
        [JsonProperty("self")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemTypeTypeLinksTypeSelfType Self { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemTypeTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemPersonType
    {
        [JsonProperty("fodselsdato")]
        public string Fodselsdato { get; set; }

        [JsonProperty("navn")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemPersonTypeNavnType Navn { get; set; }

        [JsonProperty("erDoed")]
        public bool ErDoed { get; set; }

        [JsonProperty("verge")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemPersonTypeVergeType Verge { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemPersonTypeNavnType
    {
        [JsonProperty("fornavn")]
        public string Fornavn { get; set; }

        [JsonProperty("etternavn")]
        public string Etternavn { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemPersonTypeVergeType
    {
        [JsonProperty("fodselsdato")]
        public string Fodselsdato { get; set; }

        [JsonProperty("navn")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemPersonTypeVergeTypeNavnType Navn { get; set; }

        [JsonProperty("erDoed")]
        public bool ErDoed { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemPersonTypeVergeTypeNavnType
    {
        [JsonProperty("fornavn")]
        public string Fornavn { get; set; }

        [JsonProperty("mellomnavn")]
        public string Mellomnavn { get; set; }

        [JsonProperty("etternavn")]
        public string Etternavn { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetType
    {
        [JsonProperty("organisasjonsnummer")]
        public string Organisasjonsnummer { get; set; }

        [JsonProperty("organisasjonsform")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetTypeOrganisasjonsformType Organisasjonsform { get; set; }

        [JsonProperty("navn")]
        public string[] Navn { get; set; }

        [JsonProperty("erSlettet")]
        public bool ErSlettet { get; set; }

        [JsonProperty("_links")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetTypeLinksType Links { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetTypeOrganisasjonsformType
    {
        [JsonProperty("kode")]
        public string Kode { get; set; }

        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("_links")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetTypeOrganisasjonsformTypeLinksType Links { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetTypeOrganisasjonsformTypeLinksType
    {
        [JsonProperty("self")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetTypeOrganisasjonsformTypeLinksTypeSelfType Self { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetTypeOrganisasjonsformTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetTypeLinksType
    {
        [JsonProperty("self")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetTypeLinksTypeSelfType Self { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemEnhetTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemFullmektigeTypeItem
    {
        [JsonProperty("navn")]
        public string Navn { get; set; }

        [JsonProperty("adresse")]
        public string[] Adresse { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemValgtAvType
    {
        [JsonProperty("kode")]
        public string Kode { get; set; }

        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("_links")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemValgtAvTypeLinksType Links { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemValgtAvTypeLinksType
    {
        [JsonProperty("self")]
        public GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemValgtAvTypeLinksTypeSelfType Self { get; set; }
    }

    public class GetEntityRolesResponseRollegrupperTypeItemRollerTypeItemValgtAvTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetEntityRolesResponseLinksType
    {
        [JsonProperty("self")]
        public GetEntityRolesResponseLinksTypeSelfType Self { get; set; }

        [JsonProperty("enhet")]
        public GetEntityRolesResponseLinksTypeEnhetType Enhet { get; set; }
    }

    public class GetEntityRolesResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetEntityRolesResponseLinksTypeEnhetType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetAllSearchSubResponse
    {
        [JsonProperty("_embedded")]
        public GetAllSearchSubResponseEmbeddedType Embedded { get; set; }

        [JsonProperty("_links")]
        public GetAllSearchSubResponseLinksType Links { get; set; }

        [JsonProperty("page")]
        public GetAllSearchSubResponsePageType Page { get; set; }
    }

    public class GetAllSearchSubResponseEmbeddedType
    {
        [JsonProperty("underenheter")]
        public GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItem[] Underenheter { get; set; }
    }

    public class GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItem
    {
        [JsonProperty("organisasjonsnummer")]
        public string Organisasjonsnummer { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }

        [JsonProperty("organisasjonsform")]
        public GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemOrganisasjonsformType Organisasjonsform { get; set; }

        [JsonProperty("registreringsdatoEnhetsregisteret")]
        public string RegistreringsdatoEnhetsregisteret { get; set; }

        [JsonProperty("registrertIMvaregisteret")]
        public bool RegistrertIMvaregisteret { get; set; }

        [JsonProperty("naeringskode1")]
        public GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemNaeringskode1Type Naeringskode1 { get; set; }

        [JsonProperty("antallAnsatte")]
        public int AntallAnsatte { get; set; }

        [JsonProperty("overordnetEnhet")]
        public string OverordnetEnhet { get; set; }

        [JsonProperty("beliggenhetsadresse")]
        public GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemBeliggenhetsadresseType Beliggenhetsadresse { get; set; }

        [JsonProperty("_links")]
        public GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemLinksType Links { get; set; }

        [JsonProperty("oppstartsdato")]
        public string Oppstartsdato { get; set; }
    }

    public class GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemOrganisasjonsformType
    {
        [JsonProperty("kode")]
        public string Kode { get; set; }

        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("_links")]
        public GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemOrganisasjonsformTypeLinksType Links { get; set; }
    }

    public class GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemOrganisasjonsformTypeLinksType
    {
        [JsonProperty("self")]
        public GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemOrganisasjonsformTypeLinksTypeSelfType Self { get; set; }
    }

    public class GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemOrganisasjonsformTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemNaeringskode1Type
    {
        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("kode")]
        public string Kode { get; set; }
    }

    public class GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemBeliggenhetsadresseType
    {
        [JsonProperty("land")]
        public string Land { get; set; }

        [JsonProperty("landkode")]
        public string Landkode { get; set; }

        [JsonProperty("postnummer")]
        public string Postnummer { get; set; }

        [JsonProperty("poststed")]
        public string Poststed { get; set; }

        [JsonProperty("adresse")]
        public string[] Adresse { get; set; }

        [JsonProperty("kommune")]
        public string Kommune { get; set; }

        [JsonProperty("kommunenummer")]
        public string Kommunenummer { get; set; }
    }

    public class GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemLinksType
    {
        [JsonProperty("self")]
        public GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemLinksTypeSelfType Self { get; set; }

        [JsonProperty("overordnetEnhet")]
        public GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemLinksTypeOverordnetEnhetType OverordnetEnhet { get; set; }
    }

    public class GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetAllSearchSubResponseEmbeddedTypeUnderenheterTypeItemLinksTypeOverordnetEnhetType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetAllSearchSubResponseLinksType
    {
        [JsonProperty("self")]
        public GetAllSearchSubResponseLinksTypeSelfType Self { get; set; }
    }

    public class GetAllSearchSubResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetAllSearchSubResponsePageType
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class GetSubByOrganizationNumberResponse
    {
        [JsonProperty("organisasjonsnummer")]
        public string Organisasjonsnummer { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }

        [JsonProperty("organisasjonsform")]
        public GetSubByOrganizationNumberResponseOrganisasjonsformType Organisasjonsform { get; set; }

        [JsonProperty("postadresse")]
        public GetSubByOrganizationNumberResponsePostadresseType Postadresse { get; set; }

        [JsonProperty("registreringsdatoEnhetsregisteret")]
        public string RegistreringsdatoEnhetsregisteret { get; set; }

        [JsonProperty("registrertIMvaregisteret")]
        public bool RegistrertIMvaregisteret { get; set; }

        [JsonProperty("naeringskode1")]
        public GetSubByOrganizationNumberResponseNaeringskode1Type Naeringskode1 { get; set; }

        [JsonProperty("antallAnsatte")]
        public int AntallAnsatte { get; set; }

        [JsonProperty("overordnetEnhet")]
        public string OverordnetEnhet { get; set; }

        [JsonProperty("beliggenhetsadresse")]
        public GetSubByOrganizationNumberResponseBeliggenhetsadresseType Beliggenhetsadresse { get; set; }

        [JsonProperty("slettedato")]
        public string Slettedato { get; set; }

        [JsonProperty("nedleggelsesdato")]
        public string Nedleggelsesdato { get; set; }

        [JsonProperty("_links")]
        public GetSubByOrganizationNumberResponseLinksType Links { get; set; }
    }

    public class GetSubByOrganizationNumberResponseOrganisasjonsformType
    {
        [JsonProperty("kode")]
        public string Kode { get; set; }

        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("_links")]
        public GetSubByOrganizationNumberResponseOrganisasjonsformTypeLinksType Links { get; set; }
    }

    public class GetSubByOrganizationNumberResponseOrganisasjonsformTypeLinksType
    {
        [JsonProperty("self")]
        public GetSubByOrganizationNumberResponseOrganisasjonsformTypeLinksTypeSelfType Self { get; set; }
    }

    public class GetSubByOrganizationNumberResponseOrganisasjonsformTypeLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetSubByOrganizationNumberResponsePostadresseType
    {
        [JsonProperty("land")]
        public string Land { get; set; }

        [JsonProperty("landkode")]
        public string Landkode { get; set; }

        [JsonProperty("postnummer")]
        public string Postnummer { get; set; }

        [JsonProperty("poststed")]
        public string Poststed { get; set; }

        [JsonProperty("adresse")]
        public string[] Adresse { get; set; }

        [JsonProperty("kommune")]
        public string Kommune { get; set; }

        [JsonProperty("kommunenummer")]
        public string Kommunenummer { get; set; }
    }

    public class GetSubByOrganizationNumberResponseNaeringskode1Type
    {
        [JsonProperty("beskrivelse")]
        public string Beskrivelse { get; set; }

        [JsonProperty("kode")]
        public string Kode { get; set; }
    }

    public class GetSubByOrganizationNumberResponseBeliggenhetsadresseType
    {
        [JsonProperty("land")]
        public string Land { get; set; }

        [JsonProperty("landkode")]
        public string Landkode { get; set; }

        [JsonProperty("postnummer")]
        public string Postnummer { get; set; }

        [JsonProperty("poststed")]
        public string Poststed { get; set; }

        [JsonProperty("adresse")]
        public string[] Adresse { get; set; }

        [JsonProperty("kommune")]
        public string Kommune { get; set; }

        [JsonProperty("kommunenummer")]
        public string Kommunenummer { get; set; }
    }

    public class GetSubByOrganizationNumberResponseLinksType
    {
        [JsonProperty("self")]
        public GetSubByOrganizationNumberResponseLinksTypeSelfType Self { get; set; }

        [JsonProperty("overordnetEnhet")]
        public GetSubByOrganizationNumberResponseLinksTypeOverordnetEnhetType OverordnetEnhet { get; set; }
    }

    public class GetSubByOrganizationNumberResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetSubByOrganizationNumberResponseLinksTypeOverordnetEnhetType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetEntitiesUpdatesResponse
    {
        [JsonProperty("_embedded")]
        public GetEntitiesUpdatesResponseEmbeddedType Embedded { get; set; }

        [JsonProperty("_links")]
        public GetEntitiesUpdatesResponseLinksType Links { get; set; }

        [JsonProperty("page")]
        public GetEntitiesUpdatesResponsePageType Page { get; set; }
    }

    public class GetEntitiesUpdatesResponseEmbeddedType
    {
        [JsonProperty("oppdaterteEnheter")]
        public GetEntitiesUpdatesResponseEmbeddedTypeOppdaterteEnheterTypeItem[] OppdaterteEnheter { get; set; }
    }

    public class GetEntitiesUpdatesResponseEmbeddedTypeOppdaterteEnheterTypeItem
    {
        [JsonProperty("oppdateringsid")]
        public int Oppdateringsid { get; set; }

        [JsonProperty("dato")]
        public string Dato { get; set; }

        [JsonProperty("organisasjonsnummer")]
        public string Organisasjonsnummer { get; set; }

        [JsonProperty("endringstype")]
        public string Endringstype { get; set; }

        [JsonProperty("_links")]
        public GetEntitiesUpdatesResponseEmbeddedTypeOppdaterteEnheterTypeItemLinksType Links { get; set; }
    }

    public class GetEntitiesUpdatesResponseEmbeddedTypeOppdaterteEnheterTypeItemLinksType
    {
        [JsonProperty("enhet")]
        public GetEntitiesUpdatesResponseEmbeddedTypeOppdaterteEnheterTypeItemLinksTypeEnhetType Enhet { get; set; }
    }

    public class GetEntitiesUpdatesResponseEmbeddedTypeOppdaterteEnheterTypeItemLinksTypeEnhetType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetEntitiesUpdatesResponseLinksType
    {
        [JsonProperty("self")]
        public GetEntitiesUpdatesResponseLinksTypeSelfType Self { get; set; }
    }

    public class GetEntitiesUpdatesResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetEntitiesUpdatesResponsePageType
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class GetSubEntitiesUpdatesResponse
    {
        [JsonProperty("_embedded")]
        public GetSubEntitiesUpdatesResponseEmbeddedType Embedded { get; set; }

        [JsonProperty("_links")]
        public GetSubEntitiesUpdatesResponseLinksType Links { get; set; }

        [JsonProperty("page")]
        public GetSubEntitiesUpdatesResponsePageType Page { get; set; }
    }

    public class GetSubEntitiesUpdatesResponseEmbeddedType
    {
        [JsonProperty("oppdaterteUnderenheter")]
        public GetSubEntitiesUpdatesResponseEmbeddedTypeOppdaterteUnderenheterTypeItem[] OppdaterteUnderenheter { get; set; }
    }

    public class GetSubEntitiesUpdatesResponseEmbeddedTypeOppdaterteUnderenheterTypeItem
    {
        [JsonProperty("oppdateringsid")]
        public int Oppdateringsid { get; set; }

        [JsonProperty("dato")]
        public string Dato { get; set; }

        [JsonProperty("organisasjonsnummer")]
        public string Organisasjonsnummer { get; set; }

        [JsonProperty("endringstype")]
        public string Endringstype { get; set; }

        [JsonProperty("_links")]
        public GetSubEntitiesUpdatesResponseEmbeddedTypeOppdaterteUnderenheterTypeItemLinksType Links { get; set; }
    }

    public class GetSubEntitiesUpdatesResponseEmbeddedTypeOppdaterteUnderenheterTypeItemLinksType
    {
        [JsonProperty("underenhet")]
        public GetSubEntitiesUpdatesResponseEmbeddedTypeOppdaterteUnderenheterTypeItemLinksTypeUnderenhetType Underenhet { get; set; }
    }

    public class GetSubEntitiesUpdatesResponseEmbeddedTypeOppdaterteUnderenheterTypeItemLinksTypeUnderenhetType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetSubEntitiesUpdatesResponseLinksType
    {
        [JsonProperty("self")]
        public GetSubEntitiesUpdatesResponseLinksTypeSelfType Self { get; set; }
    }

    public class GetSubEntitiesUpdatesResponseLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetSubEntitiesUpdatesResponsePageType
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Thebronnoysundregistries;

    public partial class WorkflowManagedActions
    {
        public ThebronnoysundregistriesActions Thebronnoysundregistries(string connectionId) => new ThebronnoysundregistriesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ThebronnoysundregistriesTriggers Thebronnoysundregistries(string connectionId) => new ThebronnoysundregistriesTriggers(connectionId);
    }
}
