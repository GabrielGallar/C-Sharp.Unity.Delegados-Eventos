using UnityEngine;

public class RecolectarEscudos5 : MonoBehaviour
{
    private Rigidbody rb;
    public PuntuarJugador puntuacion;
    private int puntos = 0;
    public float velocidad = 5.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) 
        {
            Vector3 nuevaPosicion = new(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            rb.MovePosition(rb.position + nuevaPosicion * velocidad * Time.fixedDeltaTime);
        }
    }
    void SumarPuntos(string tipo)
    {
        if (tipo == "tipo 1")
        {
            puntos += 5;
        }
        else
        {
            puntos += 10;
        }

        Debug.Log(puntos);
    }

   
    void OnCollisionEnter(Collision collision)
    {
        puntuacion = collision.gameObject.GetComponent<PuntuarJugador>();
        puntuacion.OnMiRecoleccion += SumarPuntos;
        puntuacion.Recolectar();
    }
}
