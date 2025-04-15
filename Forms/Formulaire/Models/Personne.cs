using System.ComponentModel.DataAnnotations;

namespace Formulaire.Models;

public class Personne
{
    [Required(ErrorMessage = "Le nom est obligatoire")]
    [StringLength(50, ErrorMessage = "Le nom ne peut pas dépasser 50 caractères")]
    public string? Nom { get; set; }
    
    [Required(ErrorMessage = "Le prénom est obligatoire")]
    [StringLength(50, ErrorMessage = "Le prénom ne peut pas dépasser 50 caractères")]
    public string? Prenom { get; set; }
    
    [Required(ErrorMessage = "La date de naissance est obligatoire")]
    [Range(0, 99, ErrorMessage = "L'âge doit être compris entre 0 et 99 ans")]
    public DateTime DateNaissance { get; set; }
    
    public string? Adresse { get; set; }
    public string? Ville { get; set; }
    public string? CodePostal { get; set; }
    public string? Pays { get; set; }
    public string? Telephone { get; set; }
    
    [Required(ErrorMessage = "L'email est obligatoire")]
    [StringLength(255, ErrorMessage = "L'email ne peut pas dépasser 255 caractères")]
    public string? Email { get; set; }
    public string? Genre { get; set; }
    public bool IsSubscribe { get; set; }
    
    
    
    public Personne(string? nom, string? prenom, DateTime dateNaissance, string? adresse, string? ville, string? 
        codePostal, string? pays, string? telephone, string? email, string? genre){
        Nom = nom;
        Prenom = prenom;
        DateNaissance = DateTime.Now;
        Adresse = adresse;
        Ville = ville;
        CodePostal = codePostal;
        Pays = pays;
        Telephone = telephone;
        Email = email;
        Genre = genre;
        IsSubscribe = false;
    }
    
}