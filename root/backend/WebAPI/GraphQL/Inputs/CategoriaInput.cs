using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.GraphQL.Inputs
{
    public record AddCategoriaInput 
    (
        string NombreCategoria
    );
    public record DeleteCategoriaInput
    (
        int IdCategoria
    );
    public record UpdateCategoriaInput
    (
        int IdCategoria,
        string NombreCategoria
    );
}
