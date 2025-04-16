using UnityEngine;

public class BaseEntity : MonoBehaviour
{
    public string Name { get; private set; }

    protected int Life { get; set; }
    protected int Attack { get; set; }
    protected int Defense { get; set; }

    public void DatosIniciales(string name, int life, int attack, int defense)
    {
        Name = name;
        Life = life;
        Attack = attack;
        Defense = defense;
    }

    public void MostrarDatos()
    {
        Debug.Log("Entidad: " + Name);
        Debug.Log("Vida: " + Life);
        Debug.Log("Ataque: " + Attack);
        Debug.Log("Defensa: " + Defense);
    }

    public int GetLife()
    {
        return Life;
    }

    public void RecibirDa�o(int da�o)
    {
        Life = Life - da�o;
        if (Life < 0)
        {
            Life = 0;
        }

        Debug.Log(Name + " recibi� " + da�o + " de da�o. Vida actual: " + Life);

        if (Life <= 0)
        {
            Debug.Log("+100 puntos por eliminar a " + Name);
            Destroy(gameObject);
        }
    }
}
