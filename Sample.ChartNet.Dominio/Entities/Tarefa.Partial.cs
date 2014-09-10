﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Sample.ChartNet.Infraestrutura.Comuns.Extensions;
using Sample.ChartNet.Dominio.Entities.Enum;

namespace Sample.ChartNet.Dominio.Entities
{
    public partial class Tarefa : EntityBase, IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.Descricao))
                validationResults.Add(new ValidationResult(string.Format(Messages.ValidationGenericoCampoObrigatorio, "Descrição da Tarefa")));

            return validationResults;
        }
    }
}
