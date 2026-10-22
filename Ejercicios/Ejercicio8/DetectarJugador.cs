using UnityEngine;

public class DetectarJugador : MonoBehaviour
{
    public delegate void avisar(string fase);
    public event avisar OnMiProximidad;
    public float limite = 2f, maximaDistancia = 3f;
    private GameObject jugador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jugador = GameObject.Find("Jugador");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, jugador.transform.position) >= limite && Vector3.Distance(transform.position, jugador.transform.position) <= maximaDistancia)
        {
            OnMiProximidad?.Invoke("Espera");
        }
        else if (Vector3.Distance(transform.position, jugador.transform.position) < limite)
        {
            OnMiProximidad?.Invoke("Ataque");
        }
    }
}
