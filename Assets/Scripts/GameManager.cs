using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static List<Ball> bolasActivas;
    private static List<Ball> bolasPerdidas;


    void Awake( ) {
        bolasActivas = new List<Ball>();
        bolasPerdidas = new List<Ball>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void registrarBola(Ball bola) {
        bolasActivas.Add(bola);
    }

    public static void perderBola(Ball bola) {
        bolasActivas.Remove(bola);
        bolasPerdidas.Add(bola);

        Debug.Log("GameManager.perderBola");

        //TODO este es el momento de testear si hemos llegado al final de la partida
    }

    public static void Reiniciar() {
        foreach(Ball bola in bolasActivas) {
            bola.Reiniciar();
        }
        foreach(Ball bola in bolasPerdidas) {
            bola.Reiniciar();
            bolasActivas.Add(bola);        
        }
        bolasPerdidas.Clear();

    }
}
