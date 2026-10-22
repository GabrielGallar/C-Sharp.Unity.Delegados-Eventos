using UnityEngine;

public class ColisionarEvento : MonoBehaviour
{
    public delegate void notificacion();
    public event notificacion OnMiColision;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            OnMiColision?.Invoke();
        }
        
    }
}