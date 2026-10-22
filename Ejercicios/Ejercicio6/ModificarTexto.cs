using UnityEngine;
using TMPro;

public class ModificarTexto : MonoBehaviour
{
    public TextMeshProUGUI puntuacionTexto;
    public RecolectarEscudos6_7 jugador;
    private int puntuacion = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jugador = FindAnyObjectByType<RecolectarEscudos6_7>();
        puntuacionTexto = FindAnyObjectByType<TextMeshProUGUI>();   
        puntuacionTexto.text = "Puntuación: " + puntuacion;
    }

    // Update is called once per frame
    void Update()
    {
        if (puntuacion != jugador.GetPuntos())
        {
            puntuacion = jugador.GetPuntos();
            puntuacionTexto.text = "Puntuación: " + puntuacion;
        }
    }
}
