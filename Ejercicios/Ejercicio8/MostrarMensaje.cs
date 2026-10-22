using UnityEngine;
using TMPro;
using System.Collections;
public class MostrarMensaje : MonoBehaviour
{
    public TextMeshProUGUI recompensaTexto;
    public ReclamarRecompensa mostrar;
    public ControlarEnemigos[] mostrarEliminacion;
    private bool eliminar = false;
    private int muertes = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mostrar = FindAnyObjectByType<ReclamarRecompensa>();
        recompensaTexto = FindAnyObjectByType<TextMeshProUGUI>();
        mostrarEliminacion = FindObjectsByType<ControlarEnemigos>();
        recompensaTexto.text = "";
        recompensaTexto.color = Color.red;
        mostrarEliminacion[0].OnMiEliminacion += Eliminar;
        mostrarEliminacion[1].OnMiEliminacion += Eliminar;
        mostrar.OnMiRecompensa += Mostrar;
    }

    void Update()
    {
        if (eliminar)
        {
            StartCoroutine(MostrarEliminacion());
        }
    }

    void Mostrar()
    {
        if (muertes == 2) {
            recompensaTexto.color = Color.yellow;
            recompensaTexto.text = "¡HAS GANADO, el tesoro es tuyo!";
        }
    }
    IEnumerator MostrarEliminacion()
    {
        recompensaTexto.text = "¡Enemigo elimininado!";
        yield return new WaitForSeconds(1.0f);
        recompensaTexto.text = "";
        eliminar = false;
    }

    void Eliminar()
    {
        eliminar = true;
        ++muertes;
    }
}
