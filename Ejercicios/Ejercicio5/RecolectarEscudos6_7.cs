using UnityEngine;
using System.Collections;
public class RecolectarEscudos6_7 : MonoBehaviour
{
    private Rigidbody rb;
    public PuntuarJugador puntuacion;
    private int puntos = 0;
    public float velocidad = 5.0f;
    public float boost = 30.0f, duracion = 5.0f;
    public delegate void recompensar();
    public event recompensar OnMiRecompensa;
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

        if (puntos % 100 == 0)
        {
            StartCoroutine(CambiarVelocidad());
        }
    }

    IEnumerator CambiarVelocidad()
    {
        velocidad += boost;
        OnMiRecompensa();
        yield return new WaitForSeconds(duracion);
        velocidad = 5;
    }

   
    void OnCollisionEnter(Collision collision)
    {
        puntuacion = collision.gameObject.GetComponent<PuntuarJugador>();
        puntuacion.OnMiRecoleccion += SumarPuntos;
        puntuacion.Recolectar();
        Destroy(collision.gameObject);
    }

    public int GetPuntos()
    {
        return puntos;
    }
}
