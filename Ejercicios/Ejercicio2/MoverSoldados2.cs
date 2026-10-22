using UnityEngine;

public class MoverSoldados2 : MonoBehaviour
{
    public ColisionarLich colision;
    public GameObject freelich;
    public float velocidad = 5.0f;
    private bool mover = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colision = FindAnyObjectByType<ColisionarLich>();
        freelich = GameObject.Find("FreeLich");
        colision.OnMiColision += MoverADestino;
    }

    // Update is called once per frame
    void Update()
    {
        if (mover)
        {
            transform.position = Vector3.MoveTowards(transform.position,freelich.transform.position, velocidad * Time.deltaTime);
        }
        
    }

    void MoverADestino()
    {
        mover = true;        
    }
}
