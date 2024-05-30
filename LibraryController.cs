using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using LibraryApi.Models;
using LibraryApi.Entities;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase

    {
        public string URI = "https://localhost:8081";
        public string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
        public string DatabaseName = "librarydata";
        public string ContainerName = "student";

        private readonly CosmosDbClient _cosmosDbClient;
         public LibraryController()
       {
     _cosmosDbClient = new CosmosDbClient(URI, PrimaryKey, DatabaseName, ContainerName);
       }

        // Book Operations

        [HttpGet("books")]
        public IEnumerable<Book> GetBooks()
        {
            return _cosmosDbClient.GetBooks();
        }

        [HttpGet("books/{uid}")]
        public ActionResult<Book> GetBook(string uid)
        {
            var book = _cosmosDbClient.GetBookByUId(uid);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        [HttpPost("books")]
        public IActionResult AddBook(Book book)
        {
            book.UId = Guid.NewGuid().ToString();
            _cosmosDbClient.AddBook(book);
            return CreatedAtAction(nameof(GetBook), new { uid = book.UId }, book);
        }

        [HttpPut("books/{uid}")]
        public IActionResult UpdateBook(string uid, Book book)
        {
            var existingBook = _cosmosDbClient.GetBookByUId(uid);
            if (existingBook == null)
            {
                return NotFound();
            }

            book.UId = uid;
            _cosmosDbClient.UpdateBook(book);
            return NoContent();
        }

        [HttpDelete("books/{uid}")]
        public IActionResult DeleteBook(string uid)
        {
            var existingBook = _cosmosDbClient.GetBookByUId(uid);
            if (existingBook == null)
            {
                return NotFound();
            }

            _cosmosDbClient.DeleteBook(uid);
            return NoContent();
        }

        // Member Operations

        [HttpGet("members")]
        public IEnumerable<Member> GetMembers()
        {
            return _cosmosDbClient.GetMembers();
        }

        [HttpGet("members/{uid}")]
        public ActionResult<Member> GetMember(string uid)
        {
            var member = _cosmosDbClient.GetMemberByUId(uid);
            if (member == null)
            {
                return NotFound();
            }
            return member;
        }

        [HttpPost("members")]
        public IActionResult AddMember(Member member)
        {
            member.UId = Guid.NewGuid().ToString();
            _cosmosDbClient.AddMember(member);
            return CreatedAtAction(nameof(GetMember), new { uid = member.UId }, member);
        }

        [HttpPut("members/{uid}")]
        public IActionResult UpdateMember(string uid, Member member)
        {
            var existingMember = _cosmosDbClient.GetMemberByUId(uid);
            if (existingMember == null)
            {
                return NotFound();
            }

            member.UId = uid;
            _cosmosDbClient.UpdateMember(member);
            return NoContent();
        }

        [HttpDelete("members/{uid}")]
        public IActionResult DeleteMember(string uid)
        {
            var existingMember = _cosmosDbClient.GetMemberByUId(uid);
            if (existingMember == null)
            {
                return NotFound();
            }

            _cosmosDbClient.DeleteMember(uid);
            return NoContent();
        }

        // Issue Operations

        [HttpGet("issues")]
        public IEnumerable<Issue> GetIssues()
        {
            return _cosmosDbClient.GetIssues();
        }

        [HttpGet("issues/{uid}")]
        public ActionResult<Issue> GetIssue(string uid)
        {
            var issue = _cosmosDbClient.GetIssueByUId(uid);
            if (issue == null)
            {
                return NotFound();
            }
            return issue;
        }

        [HttpPost("issues")]
        public IActionResult AddIssue(Issue issue)
        {
            issue.UId = Guid.NewGuid().ToString();
            _cosmosDbClient.AddIssue(issue);
            return CreatedAtAction(nameof(GetIssue), new { uid = issue.UId }, issue);
        }

        [HttpPut("issues/{uid}")]
        public IActionResult UpdateIssue(string uid, Issue issue)
        {
            var existingIssue = _cosmosDbClient.GetIssueByUId(uid);
            if (existingIssue == null)
            {
                return NotFound();
            }

            issue.UId = uid;
            _cosmosDbClient.UpdateIssue(issue);
            return NoContent();
        }

        [HttpDelete("issues/{uid}")]
        public IActionResult DeleteIssue(string uid)
        {
            var existingIssue = _cosmosDbClient.GetIssueByUId(uid);
            if (existingIssue == null)
            {
                return NotFound();
            }

            _cosmosDbClient.DeleteIssue(uid);
            return NoContent();
        }
    }
}
