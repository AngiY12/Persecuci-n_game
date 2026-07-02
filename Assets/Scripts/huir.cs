using UnityEngine;
using Unity.VisualScripting;

public class huir : MonoBehaviour
{
    public Transform objetivo;
    public float velocidadPersecucion = 5f;

    private float x=0f;
    private float y=0f;
    private float z=0f;


    void Start() {
        y = transform.position.y;
    }

    void Update() {
       x =transform.position.x;
       z =transform.position.z;
       if(objetivo.position.x > x ){
        x-=velocidadPersecucion*Time.deltaTime;
    }
    if(objetivo.position.x < x ){
        x+=velocidadPersecucion*Time.deltaTime;
    }
    if(objetivo.position.z > z ){
        z-=velocidadPersecucion*Time.deltaTime;
    }
    if(objetivo.position.z < z ){
        z+=velocidadPersecucion*Time.deltaTime;
    }
    transform.position = new Vector3(x, y, z);
    }
    
}
