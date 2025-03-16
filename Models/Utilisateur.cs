﻿using Microsoft.EntityFrameworkCore;
using StationnementAPI.Models.ModelsDTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace StationnementAPI.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(205)]
        public string NomUtilisateur { get; set; }

        [Required, MaxLength(205)]
        public string MotDePasse { get; set; }

        [Required, MaxLength(205)]
        public string Role { get; set; } = "visiteur"; // Admin, Abonné, Visiteur (par défaut)

        [Required, MaxLength(205), EmailAddress] 
        public string Email { get; set; }


        // Un utilisateur peut avoir plusieurs abonnements
        [InverseProperty("Utilisateur")]
        public ICollection<Abonnement>? Abonnements { get; set; }

       

       
    }
}
