using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static List<Ball> bolasActivas;
    private static List<Ball> bolasPerdidas;


    void Awake( ) {
        //Listas de bolas activas y perdidas para llevar la cuenta
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

    //con este scrip las bolas se registran en su Star
    public static void registrarBola(Ball bola) {
        bolasActivas.Add(bola);
    }

    public static void perderBola(Ball bola) {
        bolasActivas.Remove(bola);
        bolasPerdidas.Add(bola);

        Debug.Log("GameManager.perderBola");

    //toDO: Este es el momento de testear si hemos llegado al final de la partida
    //Testeamos si bolasActivas está vacía. De ser así la partida se acaba.
    if(bolasActivas.Count == 0){
        Debug.Log("Game Over");
    } else {
    //Le decimos a la funcion BallLoader que cargue una bola. Sin mirar si hay bolas disponibles, lo cual es bastante primitivo.
    BallLoader.instance.LoadBall(bolasActivas[0]);
    }
    //toDo: si no se acabó la partida, hay que cargar otra bola de las disponibles

    }

    //Recarga las bolas.
    //Llama a cada bola a reiniciar. Las pasa de perdidas a activas y limpia las perdidas.
    public static void Reiniciar() {
        foreach(Ball bola in bolasActivas) {
            bola.Reiniciar();
        }
        //Aqui se registran las bolas cuando se "pierden". 
        foreach(Ball bola in bolasPerdidas) {
            bola.Reiniciar();
            bolasActivas.Add(bola);        
        }
        bolasPerdidas.Clear();

        //toDo: Resetear el marcador.
        //toDo: Resetear otras partes móbiles.

    }
}
