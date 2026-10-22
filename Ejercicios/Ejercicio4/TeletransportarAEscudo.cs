using UnityEngine;

public class TeletransportarAEscudo : MonoBehaviour
{
    public DetectarCubo deteccionCubo;
    private GameObject escudoObjetivo;
    void Start()
    {
        deteccionCubo = FindAnyObjectByType<DetectarCubo>();
        escudoObjetivo = GameObject.Find("SHIELD_T");
        deteccionCubo.OnMiAproximacion += Teletransportar;
    }

    void Teletransportar()
    {
        transform.position = escudoObjetivo.transform.position;
    }
}
