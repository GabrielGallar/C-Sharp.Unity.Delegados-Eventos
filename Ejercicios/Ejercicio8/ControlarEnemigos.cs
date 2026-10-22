using UnityEngine;

public class ControlarEnemigos : MonoBehaviour
{
    public delegate void eliminar();
    public event eliminar OnMiEliminacion;
    private GameObject jugador;
    public DetectarJugador aviso;
    private Rigidbody rb, rb_target;
    private bool mover = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jugador = GameObject.Find("Jugador");
        rb_target = jugador.GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        aviso = FindAnyObjectByType<DetectarJugador>();
        aviso.OnMiProximidad += Actuar;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (mover)
        {
            rb.position = Vector3.MoveTowards(rb.position, rb_target.position, 1 * Time.fixedDeltaTime);
        }
    }
    void Actuar(string tipo)
    {
        if (tipo == "Espera")
        {
            transform.LookAt(jugador.transform.position);
        }
        else
        {
            transform.LookAt(jugador.transform.position);
            mover = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Spear")
        {
            OnMiEliminacion?.Invoke();
            Destroy(gameObject);
        }
        
    }
}
