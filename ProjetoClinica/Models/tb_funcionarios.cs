﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetoClinica.Models
{
    public partial class tb_funcionarios
    {
        public tb_funcionarios() { }

        [Key]
        public int fun_ID { get; set; }
        [Required]
        [StringLength(50)]
      
        public string fun_Nome { get; set; }
        [Required]
        [StringLength(11)]
      
        public string fun_DataNascimento { get; set; }
        [StringLength(100)]
      
        public string fun_Email { get; set; }
        [Required]
        [StringLength(16)]
      
        public string fun_Telefone { get; set; }
        [Required]
        [StringLength(15)]
      
        public string fun_CPF { get; set; }
        [Required]
        [StringLength(50)]
      
        public string fun_CargoPrimario { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal fun_Salario { get; set; }
        [StringLength(50)]
      
        public string fun_CargoFuncao { get; set; }
        [StringLength(10)]
      
        public string fun_MedCRM { get; set; }
        public byte[] fun_foto { get; set; }
        public bool? fun_admin { get; set; }
        [StringLength(50)]
      
        public string fun_login { get; set; }
        [StringLength(50)]
      
        public string fun_senha { get; set; }

        [InverseProperty("fk_Fun")]
        public virtual Resources Resources { get; set; }
    }
}