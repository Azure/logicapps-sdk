//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Basecamp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BasecampActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IBodyWorkflowAction<AccountList> ListAccounts()
        {
            var apiCallPath = "/authorization.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IBodyWorkflowAction<Basecamp[]> ListBasecamps(Expression<Func<int>> accountId)
        {
            var apiCallPath = String.Format("/{0}/projects.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Basecamp[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IBodyWorkflowAction<ToDoList[]> ListToDoLists(Expression<Func<int>> accountId, Expression<Func<string>> bucket = null)
        {
            var apiCallPath = String.Format("/{0}/projects/recordings.Todolist", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (bucket != null)
                callPayload.Queries["bucket"] = ExpressionConverter.Convert(bucket);
            return new ApiConnectionAction<ToDoList[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IBodyWorkflowAction<ToDo> CreateToDo(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> todolistId, Expression<Func<string>> toDocontent, Expression<Func<string>> toDodescription = null, Expression<Func<string>> toDodueOn = null, Expression<Func<string>> toDostartOn = null)
        {
            var apiCallPath = String.Format("/{0}/buckets/{1}/todolists/{2}/todos.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(todolistId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var toDo = new JObject();
            var toDopropCount = 0;
            toDopropCount++;
            toDo["content"] = ExpressionConverter.ConvertO(toDocontent);
            if (toDodescription != null)
            {
                toDo["description"] = ExpressionConverter.ConvertO(toDodescription);
                toDopropCount++;
            }

            if (toDodueOn != null)
            {
                toDo["due_on"] = ExpressionConverter.ConvertO(toDodueOn);
                toDopropCount++;
            }

            if (toDostartOn != null)
            {
                toDo["start_on"] = ExpressionConverter.ConvertO(toDostartOn);
                toDopropCount++;
            }

            if (toDopropCount > 0)
            {
                callPayload.Body = toDo;
            }

            return new ApiConnectionAction<ToDo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IBodyWorkflowAction<ToDo[]> ListToDos(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> todolistId)
        {
            var apiCallPath = String.Format("/{0}/buckets/{1}/todolists/{2}/todos.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(todolistId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ToDo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IWorkflowAction CompleteToDo(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> todoId)
        {
            var apiCallPath = String.Format("/{0}/buckets/{1}/todos/{2}/completion.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(todoId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IWorkflowAction UncompleteToDo(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> todoId)
        {
            var apiCallPath = String.Format("/{0}/buckets/{1}/todos/{2}/completion.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(todoId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IWorkflowAction DeleteToDo(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> todoId)
        {
            var apiCallPath = String.Format("/{0}/buckets/{1}/recordings/todos/{2}/status/trashed.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(todoId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IWorkflowAction DeleteScheduledEntry(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> eventId)
        {
            var apiCallPath = String.Format("/{0}/buckets/{1}/recordings/events/{2}/status/trashed.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IWorkflowAction DeleteDocument(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/{0}/buckets/{1}/recordings/documents/{2}/status/trashed.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IBodyWorkflowAction<Message> PostMessage(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> messagesubject, Expression<Func<string>> messagecontent)
        {
            var apiCallPath = String.Format("/{0}/buckets/dynamic_message_board/messages.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["basecampId"] = ExpressionConverter.Convert(basecampId);
            var message = new JObject();
            var messagepropCount = 0;
            messagepropCount++;
            message["subject"] = ExpressionConverter.ConvertO(messagesubject);
            messagepropCount++;
            message["content"] = ExpressionConverter.ConvertO(messagecontent);
            if (messagepropCount > 0)
            {
                callPayload.Body = message;
            }

            return new ApiConnectionAction<Message>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IBodyWorkflowAction<Document> CreateDocument(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> vaultId, Expression<Func<string>> documenttitle, Expression<Func<string>> documentcontent)
        {
            var apiCallPath = String.Format("/{0}/buckets/{1}/vaults/{2}/documents.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(vaultId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var document = new JObject();
            var documentpropCount = 0;
            documentpropCount++;
            document["title"] = ExpressionConverter.ConvertO(documenttitle);
            documentpropCount++;
            document["content"] = ExpressionConverter.ConvertO(documentcontent);
            if (documentpropCount > 0)
            {
                callPayload.Body = document;
            }

            return new ApiConnectionAction<Document>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IBodyWorkflowAction<Basecamp[]> UploadFile(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> vaultId, Expression<Func<string>> contentType, Expression<Func<string>> name, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/{0}/buckets/{1}/vaults/{2}/uploads.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(vaultId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["content_type"] = ExpressionConverter.Convert(contentType);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<Basecamp[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp")]
        public IBodyWorkflowAction<Entry> CreateScheduleEntry(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> scheduleEntrysummary, Expression<Func<string>> scheduleEntrystartTime, Expression<Func<string>> scheduleEntryendTime, Expression<Func<string>> scheduleEntryparticipants = null)
        {
            var apiCallPath = String.Format("/{0}/buckets/dynamic_schedule/entries.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["basecampId"] = ExpressionConverter.Convert(basecampId);
            var scheduleEntry = new JObject();
            var scheduleEntrypropCount = 0;
            scheduleEntrypropCount++;
            scheduleEntry["summary"] = ExpressionConverter.ConvertO(scheduleEntrysummary);
            scheduleEntrypropCount++;
            scheduleEntry["starts_at"] = ExpressionConverter.ConvertO(scheduleEntrystartTime);
            scheduleEntrypropCount++;
            scheduleEntry["ends_at"] = ExpressionConverter.ConvertO(scheduleEntryendTime);
            if (scheduleEntryparticipants != null)
            {
                scheduleEntry["participant_ids"] = ExpressionConverter.ConvertO(scheduleEntryparticipants);
                scheduleEntrypropCount++;
            }

            if (scheduleEntrypropCount > 0)
            {
                callPayload.Body = scheduleEntry;
            }

            return new ApiConnectionAction<Entry>(callPayload);
        }
    }

    public class BasecampTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Message[]> OnMessagePosted(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/{0}/buckets/dynamic_message_board/messages.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["basecampId"] = ExpressionConverter.Convert(basecampId);
            return new ApiConnectionTrigger<Message[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ToDo[]> OnToDoCreated(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> todolistId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/{0}/buckets/{1}/todolists/{2}/todos.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(todolistId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ToDo[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ToDo[]> OnToDoUpdated(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> todolistId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/update_trigger/{0}/buckets/{1}/todolists/{2}/todos.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(todolistId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ToDo[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Document[]> OnDocumentCreated(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> vaultId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/{0}/buckets/{1}/vaults/{2}/documents.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(vaultId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<Document[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Document[]> OnDocumentUpdated(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> vaultId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/update_trigger/{0}/buckets/{1}/vaults/{2}/documents.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(vaultId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<Document[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Document[]> OnDocumentDeleted(Expression<Func<int>> accountId, Expression<Func<string>> bucket = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/update_trigger/{0}/projects/recordings.Document", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (bucket != null)
                callPayload.Queries["bucket"] = ExpressionConverter.Convert(bucket);
            return new ApiConnectionTrigger<Document[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Entry[]> OnScheduledEntryDeleted(Expression<Func<int>> accountId, Expression<Func<string>> bucket = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/update_trigger/{0}/projects/recordings.Schedule::Entry", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (bucket != null)
                callPayload.Queries["bucket"] = ExpressionConverter.Convert(bucket);
            return new ApiConnectionTrigger<Entry[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Upload[]> OnFileUploaded(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> vaultId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/{0}/buckets/{1}/vaults/{2}/uploads.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(vaultId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<Upload[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Upload[]> OnFileUpdated(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, Expression<Func<string>> vaultId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/update_trigger/{0}/buckets/{1}/vaults/{2}/uploads.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(basecampId, 1), ExpressionConverter.ConvertWithUrlEncoding(vaultId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<Upload[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Entry[]> OnScheduledEntryCreated(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/{0}/buckets/dynamic_schedule/entries.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["basecampId"] = ExpressionConverter.Convert(basecampId);
            return new ApiConnectionTrigger<Entry[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Entry[]> OnScheduledEntryUpdated(Expression<Func<int>> accountId, Expression<Func<string>> basecampId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/update_trigger/{0}/buckets/dynamic_schedule/entries.json", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["basecampId"] = ExpressionConverter.Convert(basecampId);
            return new ApiConnectionTrigger<Entry[]>(callPayload, triggerName, recurrence);
        }
    }

    public class AccountList
    {
        [JsonProperty("accounts")]
        public Account[] Accounts { get; set; }
    }

    public class Account
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("href")]
        public string URL { get; set; }
    }

    public class Basecamp
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bookmark_url")]
        public string BookmarkURL { get; set; }

        [JsonProperty("app_url")]
        public string WebURL { get; set; }

        [JsonProperty("bookmarked")]
        public bool Bookmarked { get; set; }

        [JsonProperty("dock")]
        public BasecampDockType Dock { get; set; }
    }

    public class BasecampDockType
    {
        [JsonProperty("chat")]
        public DockItem Chat { get; set; }

        [JsonProperty("message_board")]
        public DockItem MessageBoard { get; set; }

        [JsonProperty("todoset")]
        public DockItem Todoset { get; set; }

        [JsonProperty("schedule")]
        public DockItem Schedule { get; set; }

        [JsonProperty("questionnaire")]
        public DockItem Questionnaire { get; set; }

        [JsonProperty("vault")]
        public DockItem Vault { get; set; }
    }

    public class DockItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("enabled")]
        public bool Enaled { get; set; }

        [JsonProperty("position")]
        public double Position { get; set; }

        [JsonProperty("app_url")]
        public string WebURL { get; set; }
    }

    public class ToDoList
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }

    public class ToDo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_on")]
        public string DueOn { get; set; }

        [JsonProperty("start_on")]
        public string StartOn { get; set; }
    }

    public class Message
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDate { get; set; }
    }

    public class Document
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("app_url")]
        public string URL { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDate { get; set; }

        [JsonProperty("vault_id")]
        public int VaultId { get; set; }

        [JsonProperty("vault_title")]
        public string VaultTitle { get; set; }

        [JsonProperty("vault_url")]
        public string VaultUrl { get; set; }
    }

    public class Entry
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("starts_at")]
        public string StartTime { get; set; }

        [JsonProperty("ends_at")]
        public string EndTime { get; set; }

        [JsonProperty("app_url")]
        public string URL { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDate { get; set; }
    }

    public class Upload
    {
        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("app_url")]
        public string URL { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDate { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("byte_size")]
        public int Size { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Basecamp;

    public partial class WorkflowManagedActions
    {
        public BasecampActions Basecamp(string connectionId) => new BasecampActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BasecampTriggers Basecamp(string connectionId) => new BasecampTriggers(connectionId);
    }
}