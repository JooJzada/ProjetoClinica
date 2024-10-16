﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetoClinica.Models
{
    public partial class tb_cliente
    {
        public tb_cliente()
        {
            tb_consultas = new HashSet<tb_consultas>();
        }

        [Key]
        public int cl_id { get; set; }
        [Required]
        [StringLength(100)]
       
        public string cl_nome { get; set; }
        [Required]
        [StringLength(14)]
       
        public string cl_cpf { get; set; }
        [StringLength(11)]
        public string cl_data_nascimento { get; set; }
        [Required]
        [StringLength(16)]
       
        public string cl_telefone { get; set; }
        [StringLength(100)]
       
        public string cl_email { get; set; }
        [Required]
        [StringLength(50)]
       
        public string cl_plano { get; set; }
        [Column(TypeName = "decimal(1, 1)")]
        public decimal? cl_altura { get; set; }
        public int? cl_peso { get; set; }
        [StringLength(4)]
       
        public string cl_tipo_sangue { get; set; }
        public byte[] cl_foto { get; set; }

        [InverseProperty("cslt_fk_idclienteNavigation")]
        public virtual ICollection<tb_consultas> tb_consultas { get; set; }
    }
}