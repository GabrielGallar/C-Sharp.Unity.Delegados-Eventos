using UnityEngine;

public class MoverVerdes : MonoBehaviour
{
    public ColisionarEvento colision;
    public GameObject cilindro;
    public float velocidad = 5.0f;
    private bool mover = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colision = FindAnyObjectByType<ColisionarEvento>();
        cilindro = GameObject.Find("Cylinder");
        colision.OnMiColision += MoverADestino;
    }

    // Update is called once per frame
    void Update()
    {
        if (mover)
        {
            transform.position = Vector3.MoveTowards(transform.position, cilindro.transform.position, velocidad * Time.deltaTime);
        }
        
    }

    void MoverADestino()
    {
        mover = true;        
    }
}
