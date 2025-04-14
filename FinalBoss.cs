using UnityEngine;

public class FinalBoss : BaseEntity
{
    private int buffsAplicados = 0;

    public void ApplyBuff(string tipo, int cantidad)
    {
        //para evitar valores nega
        if (cantidad < 0)
        {
            Debug.Log("No se pueden aplicar buffs negativos");
            return;
        }

        //lo que escriba el user
        switch (tipo)
        {
            case "ataque":

                Attack = Attack + cantidad;
                Debug.Log($"{Name} gana +{cantidad} de ataque!");
                break;

            case "defensa":
                Defense = Defense + cantidad;
                Debug.Log($"{Name} gana +{cantidad} de defensa!");
                break;

            case "salud":
                Life = Life + cantidad;
                Debug.Log($"{Name} gana +{cantidad} de vida!");
                break;

            default:
                Debug.Log($"Tipo de buff desconocido: {tipo}");
                break;
        }

        buffsAplicados = buffsAplicados + 1;
        MostrarDatos();

        if (buffsAplicados >= 4)
        {
            Debug.Log("¡Jefe destruido por 4 buffs aplicados!");
            Destroy(gameObject);
        }

    }

    private void OnDestroy()
    {
        Debug.Log("¡El jefe final ha sido destruido!");
    }
}
