using UnityEngine;

public class ColisionarHumanoide9 : MonoBehaviour
{
    public Rigidbody rb;
    public delegate void notificacion(string tipo);
    public event notificacion OnMiColisionHumanoide;
    public float velocidad = 1.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        //if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) 
        //{
            Vector3 entrada = new(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            Vector3 nuevaPosicion = rb.position + entrada * velocidad * Time.fixedDeltaTime;
            rb.MovePosition(nuevaPosicion);
        //}
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "tipo 2")
        {
            OnMiColisionHumanoide?.Invoke("2");
        }
        else if (other.gameObject.tag == "tipo 1")
        {
            OnMiColisionHumanoide?.Invoke("1");
        }
    }
}
