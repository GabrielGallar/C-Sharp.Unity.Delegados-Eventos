using UnityEngine;
using System.Text.RegularExpressions;

public class DesplazarAEscudos : MonoBehaviour
{
    public ColisionarHumanoide colision;
    public float velocidad = 1.0f;
    private GameObject escudo2, escudoX;
    private Rigidbody rb, rbEscudo;
    public string escudo = "1";
    private bool moverAEscudoX = false, moverAEscudos2 = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        colision = FindAnyObjectByType<ColisionarHumanoide>();
        escudoX = GameObject.Find("Shield3");
        escudo2 = GameObject.Find("Shield2_" + escudo);
        rbEscudo = escudo2.GetComponent<Rigidbody>();
        colision.OnMiColisionHumanoide += MoverAEscudo;
    }

    void FixedUpdate()
    {
        if (moverAEscudos2)
        {
            rb.position = Vector3.MoveTowards(rb.position, rbEscudo.position, velocidad * Time.fixedDeltaTime);
        }
        if (moverAEscudoX)
        {
            rb.position = Vector3.MoveTowards(rb.position, escudoX.transform.position, velocidad * Time.fixedDeltaTime);
        }
    }

    void MoverAEscudo(string tipo)
    {
        if (tipo == "1") {
            moverAEscudos2 = true;
            moverAEscudoX = false;
        }
        else
        {
            moverAEscudos2 = false;
            moverAEscudoX = true;
        }
        
    }

    void OnCollisionEnter(Collision other)
    {
        Match coincidencia = Regex.Match(other.gameObject.name, @"Shield2_\d");
        if (coincidencia.Success)
        {
           SkinnedMeshRenderer rend = GetComponentInChildren<SkinnedMeshRenderer>();
           rend.material.color = Color.red;  
        }
    }
}
