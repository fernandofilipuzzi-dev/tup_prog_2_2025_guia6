
using System.Text.RegularExpressions;

namespace Ejercicio1.Models;

public class PersonaJuridica:Persona
{
    protected string cuit;
 
    public PersonaJuridica(string nombre, string cuit):base(nombre)
    {
        Match match = Regex.Match(cuit, @"\d{11}");
        if (match.Success == false)
        {
            throw new FormatoCUITNoValidoException();
        }

        this.cuit = cuit;
    }
    
    override public string Describir()
    {
        return $"{nombre}  ( {cuit} )";
    }
}
