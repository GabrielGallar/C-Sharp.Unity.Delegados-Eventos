using UnityEngine;
using TMPro;
using System.Collections;

public class Recompensar100 : MonoBehaviour
{   
    public TextMeshProUGUI puntuacionTexto;
    public RecolectarEscudos6_7 jugador;
    private int puntuacion = 0;
    private bool mostrarRecompensa = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jugador = FindAnyObjectByType<RecolectarEscudos6_7>();
        jugador.OnMiRecompensa += Update;
        puntuacionTexto = FindAnyObjectByType<TextMeshProUGUI>();   
        puntuacionTexto.text = "Puntuación: " + puntuacion;

    }

    // Update is called once per frame
    void Update()
    {
        if (puntuacion != jugador.GetPuntos())
        {
            if (jugador.GetPuntos() % 100 == 0)
            {
                puntuacion = jugador.GetPuntos();
                StopAllCoroutines();
                StartCoroutine(MostrarRecompensa());
            }
            else if (!mostrarRecompensa)
            {
                puntuacion = jugador.GetPuntos();
                puntuacionTexto.text = "Puntuación: " + puntuacion;
            }
            
        }
    }

    IEnumerator MostrarRecompensa()
    {
        mostrarRecompensa = true;
        puntuacionTexto.text = "Puntuacion: " + puntuacion + " ¡+" + jugador.boost + " de velocidad durante " + jugador.duracion + " segundos!";
        yield return new WaitForSeconds(5);
        mostrarRecompensa = false;
        puntuacionTexto.text = "Puntuación: " + puntuacion;
    }
}
