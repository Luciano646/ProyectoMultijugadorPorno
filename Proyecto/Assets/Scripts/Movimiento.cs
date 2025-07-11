using UnityEngine;
using UnityEngine.InputSystem; // Necesario para Input System

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f; // Controla la velocidad de movimiento
    private Vector2 direccion;  // Almacena la dirección actual del movimiento

    // Este método lo llama automáticamente el Player Input cuando se presiona una tecla
    void OnMove(InputValue valor)
    {
        direccion = valor.Get<Vector2>(); // Captura el input como un vector (ej: [1, 0] = derecha)
    }

    void Update()
    {
        // Mueve el objeto cada frame según la dirección, velocidad y tiempo
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}
