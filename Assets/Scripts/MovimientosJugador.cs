using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientosJugador : MonoBehaviour 
{
    public float velocidad = 15f;
    public float velAngular = 90f; 

    private PlayerInput playerInput; 
    private Vector2 inputMovimiento; 

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        if (playerInput == null)
        {
            playerInput = gameObject.AddComponent<PlayerInput>();
        }
        playerInput.defaultControlScheme = "Keyboard"; 
    }

    void Update() 
    {
        Vector2 moveInput = Vector2.zero;
        
        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed) moveInput.y = 1;
            if (Keyboard.current.sKey.isPressed) moveInput.y = -1;
            if (Keyboard.current.aKey.isPressed) moveInput.x = -1;
            if (Keyboard.current.dKey.isPressed) moveInput.x = 1;

            inputMovimiento = moveInput;
        }

        if (inputMovimiento.x != 0)
        {
            transform.Rotate(Vector3.up, inputMovimiento.x * velAngular * Time.deltaTime);
        }

        if (inputMovimiento.y != 0)
        {
            transform.Translate(Vector3.forward * inputMovimiento.y * velocidad * Time.deltaTime);
        }
    }
}