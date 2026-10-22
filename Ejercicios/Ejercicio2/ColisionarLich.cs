using UnityEngine;

public class ColisionarLich : MonoBehaviour
{
    public delegate void notificacion();
    public event notificacion OnMiColision;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FreeLich (1)")
        {
            OnMiColision?.Invoke();
        }
        
    }
}
