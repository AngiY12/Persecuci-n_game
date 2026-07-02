using UnityEngine;

public class VerJugador : MonoBehaviour
{
    public float velocidad = 5;
    public Transform objetivo;
    public float rangoVision = 50;
    public float rangoFOV = 30;

    public float distanicaJugador = 0;
    public float angulo = 0; 
    private Vector3 JugadorDesdeIA;

    void Start()
    {
        
    }

    void Update()
    {
        bool visto = false; 
        
        // LÍNEA CORREGIDA: Obtenemos el vector primero, y luego leemos su propiedad sqrMagnitude
        distanicaJugador = (transform.position - objetivo.position).sqrMagnitude;   

        if (distanicaJugador <= (rangoVision * rangoVision))
        {
            JugadorDesdeIA = objetivo.position - transform.position;
            angulo = Vector3.Angle(transform.forward, JugadorDesdeIA);

            if(angulo <= rangoFOV) visto = true;
        }

        if(visto)
        {
            Debug.Log("Jugador visto");
        }
        else
        {
            Debug.Log("Jugador no visto");
        }
    }
}