using UnityEngine;

public class DetectarCubo : MonoBehaviour
{
    public delegate void deteccion();
    public float limite = 10.0f;
    public event deteccion OnMiAproximacion;
    private GameObject cubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubo = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, cubo.transform.position) < limite)
        {
            OnMiAproximacion?.Invoke();
        }
        
    }
}
