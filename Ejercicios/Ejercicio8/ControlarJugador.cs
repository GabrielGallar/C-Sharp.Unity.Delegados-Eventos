using UnityEngine;

public class ControlarJugador : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidad = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) 
        {
            Vector3 nuevaPosicion = new(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            rb.MovePosition(rb.position + nuevaPosicion * velocidad * Time.fixedDeltaTime);
        }
    }
}
