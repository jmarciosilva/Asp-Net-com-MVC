using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao01.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O Nome é Obrigatório")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength =5, ErrorMessage ="Insira uma mensagem de no minimo 5 caracteres e máximo de 50 caracteres")]
        public string Observacoes { get; set; }

        [Range(18,70, ErrorMessage ="A idade tem q estar entre 18 e 70 anos")]
        public int Idade { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um email valido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage ="Somente Letras de 5 a 15 Caracteres")]
        [Required(ErrorMessage = "O Login é Obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este Usuario Ja Existe" )]
        public string Login { get; set; }

        [Required(ErrorMessage = "A Senha é Obrigatória")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage ="As Senhas não estão iguais")]
        public string ConfirmarSenha { get; set; }
    }
}