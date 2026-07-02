using UnityEngine; // Corregido: se quitó el punto y se dejó un espacio

public class interseccion : MonoBehaviour
{
    public float velocidad = 5f;
    public float rotacion = 5f;
    public Transform objetivo;

    void Start()
    {
    }
    
    void Update()
    {
       Vector3 punto = objetivo.position- transform.position;
       Vector3 vision = transform.position = punto;
       vision.y = objetivo.position.y;
       
       transform.LookAt(vision);
       transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}