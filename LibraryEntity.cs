using Newtonsoft.Json;
using System;

namespace LibraryApi.Entities
{
    public class Book
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uId")]
        public string UId { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTime UpdatedOn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("publishedDate")]
        public DateTime PublishedDate { get; set; }

        [JsonProperty("isbn")]
        public string ISBN { get; set; }

        [JsonProperty("isIssued")]
        public bool IsIssued { get; set; }
    }

    public class Member
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uId")]
        public string UId { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTime UpdatedOn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Issue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uId")]
        public string UId { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedOn")]
        public DateTime UpdatedOn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("bookId")]
        public string BookId { get; set; }

        [JsonProperty("memberId")]
        public string MemberId { get; set; }

        [JsonProperty("issueDate")]
        public DateTime IssueDate { get; set; }

        [JsonProperty("returnDate")]
        public DateTime? ReturnDate { get; set; }

        [JsonProperty("isReturned")]
        public bool IsReturned { get; set; }
    }
}
