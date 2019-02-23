using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ExemploApi.Model
{
    [Table("USUARIO")]
    public class Usuario
    {
        [Key]        
        [Column("ID")]
        public decimal Id { get; set; }
        
        [Required]
        [Column("NOME_USUARIO")]
        public string Nome { get; set; }

        [Required]
        [Column("SENHA_USUARIO")]
        public string Senha { get; set; }
        
        [Required]
        [Column("EMAIL_USUARIO")]
        public string Email { get; set; }

        [Column("SUB_USUARIO")] 
        public bool SubUsuario { get; set; } = false;

        [Column("ID_USUARIO_PRINCIPAL")]
        public decimal IdSubUsuario { get; set; }
        
        [Column("ATIVO")] 
        public bool Ativo { get; set; } = true;

        [Column("USUARIO_CREACAO")]
        public decimal CriacaoUsuario { get; set; } = 1;

        [Column("DATA_CREACAO")]
        public DateTime CriacaoData { get; set; } = DateTime.Now;
        
        [Column("USUARIO_ALTERACAO")]
        public decimal? AlteracaoUsuario { get; set; } 

        [Column("DATA_ALTERACAO")]
        public DateTime? AlteracaoData { get; set; }

        [Column("USUARIO_EXCLUSAO")]
        public decimal? ExclusaoUsuario { get; set; } 

        [Column("DATA_EXCLUSAO")]
        public DateTime? ExclusaoData { get; set; }        
    }
}