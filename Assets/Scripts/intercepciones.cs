using UnityEngine; 

public class intercepciones : MonoBehaviour
{
    public GameObject objetivo;
    public GameObject prediccion;
    
    public float velocidad;
    private Vector3 velRelativa;
    private Vector3 miVelocidad;
    private Vector3 velObjetivo;
    private Vector3 miPosAnterior;
    private Vector3 objPosAnterior;
    private float tiempoIntercepcion;
    private Vector3 distRelativa;
    private Vector3 posFutura;
    private Vector3 posPrediccion;

    void Start()
    {
        miPosAnterior = transform.position;
        if(objetivo != null) objPosAnterior = objetivo.transform.position;
    }

    void Update()
    {
        if(objetivo == null || prediccion == null) return;

        if (Time.deltaTime <= 0.0001f) return;

        miVelocidad = (transform.position - miPosAnterior) / Time.deltaTime;
        miPosAnterior = transform.position;

        velObjetivo = (objetivo.transform.position - objPosAnterior) / Time.deltaTime;
        objPosAnterior = objetivo.transform.position;    

        if (velObjetivo.sqrMagnitude > 0.01f)
        {
            velRelativa = velObjetivo - miVelocidad;
            distRelativa = objetivo.transform.position - transform.position;

            if(velRelativa.magnitude > 0.001f)
            {
                tiempoIntercepcion = distRelativa.magnitude / velRelativa.magnitude;
            }
            else
            {
                tiempoIntercepcion = 0f;
            }

            posFutura = objetivo.transform.position + velObjetivo * tiempoIntercepcion;
            posPrediccion = new Vector3(posFutura.x, transform.position.y, posFutura.z);
            
            if (posPrediccion != transform.position)
            {
                transform.LookAt(posPrediccion);
            }
            
            prediccion.transform.position = posPrediccion;

            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
    }
}