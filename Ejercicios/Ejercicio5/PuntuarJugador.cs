using UnityEngine;

public class PuntuarJugador : MonoBehaviour
{
    private string tipo;
    public delegate void notificar(string tipo);
    public event notificar OnMiRecoleccion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tipo = gameObject.tag;   
    }

    public void Recolectar()
    {
        OnMiRecoleccion?.Invoke(tipo);
    }
}
