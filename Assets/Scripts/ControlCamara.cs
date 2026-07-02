using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public Transform objetivo;
    
    // Distancia a la que estará la cámara respecto al jugador (X, Y, Z)
    public Vector3 offset = new Vector3(0f, 2f, -4f); 
    
    // Velocidad con la que la cámara sigue al jugador
    public float suavizado = 5f; 

    // Usamos LateUpdate en lugar de Update para las cámaras
    void LateUpdate()
    {
        if (objetivo != null)
        {
            // 1. Calculamos a dónde debe moverse la cámara basándonos en la posición del jugador más la distancia (offset)
            Vector3 posicionDeseada = objetivo.position + offset;

            // 2. Movemos la cámara suavemente hacia esa posición
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);

            // 3. Hacemos que la cámara mire al jugador
            transform.LookAt(objetivo);
        }
    }
}