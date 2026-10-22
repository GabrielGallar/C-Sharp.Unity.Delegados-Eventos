using UnityEngine;

public class MoverSoldados1 : MonoBehaviour
{
    public ColisionarLich colision;
    public GameObject footmanDestino;
    private bool mover = false;
    public float velocidad = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colision = FindAnyObjectByType<ColisionarLich>();
        footmanDestino = GameObject.Find("Footman_Default (7)");
        colision.OnMiColision += MoverADestino;
    }

    // Update is called once per frame
    void Update()
    {
        if (mover)
        {
            transform.position = Vector3.MoveTowards(transform.position,footmanDestino.transform.position, velocidad * Time.deltaTime);
        }
        
    }

    void MoverADestino()
    {
        mover = true;        
    }
}
