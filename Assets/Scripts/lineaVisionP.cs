using UnityEngine;

public class lineaVisionP : MonoBehaviour
{
    public float velocidad = 5f;
    public Transform objetivo;
    
    // Nueva variable para guardar dónde estaba el jugador en el frame anterior
    private Vector3 posAnteriorObjetivo;

    void Start()
    {
        if (objetivo != null)
        {
            // Inicializamos la posición anterior al empezar
            posAnteriorObjetivo = objetivo.position; 
        }
    }
    
    void Update()
    {
        if (objetivo == null) return;

        // Calculamos cuánto se movió el objetivo usando el mismo truco de sqrMagnitude que usaste antes
        float movimientoObjetivo = (objetivo.position - posAnteriorObjetivo).sqrMagnitude;

        // Si el cuadrado de la distancia es mayor a 0 (con un pequeño margen de error para los decimales)
        if (movimientoObjetivo > 0.0001f) 
        {
            // El objetivo se está moviendo -> ¡A perseguir!
            transform.LookAt(objetivo);
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }

        // Al final del frame, actualizamos la posición anterior para usarla en el siguiente
        posAnteriorObjetivo = objetivo.position;
    }
}