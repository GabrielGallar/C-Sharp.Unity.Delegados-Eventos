using UnityEngine;

public class MoverRojas : MonoBehaviour
{
    public ColisionarEvento colision;
    public GameObject verde;
    private bool mover = false;
    public float velocidad = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colision = FindAnyObjectByType<ColisionarEvento>();
        verde = GameObject.Find("Sphere (10)");
        colision.OnMiColision += MoverADestino;
    }

    // Update is called once per frame
    void Update()
    {
        if (mover)
        {
            transform.position = Vector3.MoveTowards(transform.position, verde.transform.position, velocidad * Time.deltaTime);
        }
        
    }

    void MoverADestino()
    {
        mover = true;        
    }
}
