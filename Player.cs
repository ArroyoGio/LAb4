using UnityEngine;

public class Player : BaseEntity
{
    private void OnDestroy()
    {
        Debug.Log("El jugador fue derrotado");
    }
}
