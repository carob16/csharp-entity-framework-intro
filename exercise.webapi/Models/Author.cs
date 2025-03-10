﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    [Table("authors")]
    public class Author
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("numOfBooks")]
        public int BookCount {  get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
