using UnityEngine;

public class ReclamarRecompensa : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje OnMiRecompensa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Jugador")
        {
            OnMiRecompensa?.Invoke();
        }
    }

}
