using Blog.WebApp.Data;
using System.ComponentModel.DataAnnotations;

namespace Blog.WebApp.Models;

public class Post
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Titulo { get; set; }

    [Required]
    public string Conteudo { get; set; }

    public DateTime DataPublicacao { get; set; }

    public string ApplicationUserId { get; set; }

    public virtual ApplicationUser? ApplicationUser { get; set; }
}