using UnityEngine;

public class ColisionarHumanoide : MonoBehaviour
{
    public delegate void notificacion(string tipo);
    public event notificacion OnMiColisionHumanoide;
    public float velocidad = 1.0f;
    void Update()
    {
        if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) 
        {
            Vector3 nuevaPosicion = new(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            transform.Translate(nuevaPosicion * velocidad * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
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
