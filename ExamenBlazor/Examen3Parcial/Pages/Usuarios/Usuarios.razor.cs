using Examen3Parcial.Interfaces;
using Microsoft.AspNetCore.Components;

namespace Examen3Parcial.Pages.Usuarios;

partial class Usuarios
{
    [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

   
}
