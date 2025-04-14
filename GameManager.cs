using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        FinalBoss jefe = new FinalBoss();
        Player jugador = new Player();

        // Inicializamos los datos (nombre, vida, ataque, defensa)
        jefe.DatosIniciales("Jefe Final", 200, 50, 30);
        jugador.DatosIniciales("Jugador", 150, 40, 20);

        // Mostrar datos iniciales
        jefe.MostrarDatos();
        jugador.MostrarDatos();

        // Aplicamos los buffs al jefe
        jefe.ApplyBuff("ataque", 20);  
        jefe.ApplyBuff("defensa", 10); 
        jefe.ApplyBuff("salud", 50);  
        jefe.ApplyBuff("ataque", 15); 


        jefe.RecibirDaño(30);   // El jugador ataca al jefe
        jugador.RecibirDaño(40); // El jefe ataca al jugador

        jefe.RecibirDaño(50);   
        jugador.RecibirDaño(60); 

        jefe.RecibirDaño(100);  
        jugador.RecibirDaño(50);

        if (jefe.GetLife() <= 0)
        {
            Debug.Log("El jugador ha derrotado al jefe");
        }
        else if (jugador.GetLife() <= 0)
        {
            Debug.Log("El jefe ha derrotado al jugador");
        }

    }

}
