using UnityEngine;

public class OrientarObjeto : MonoBehaviour
{
    private GameObject esfera;
    public DetectarCubo detectar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        detectar = FindAnyObjectByType<DetectarCubo>();
        esfera = GameObject.Find("Sphere");
        detectar.OnMiAproximacion += Rotar;
    }

    void Rotar()
    {
        transform.LookAt(esfera.transform.position);
    }
}
