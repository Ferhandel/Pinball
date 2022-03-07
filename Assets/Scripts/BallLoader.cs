using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este script se usa para cargar las bolas de la "recamara" en el "lanzador".
public class BallLoader : MonoBehaviour
{

    public static BallLoader instance; 
    public Transform loadingBallPosition;

    //funcion Awake
    void Awake(){
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        //Warning para posibles fallos
        if(loadingBallPosition == null){
            Debug.Log("BallLoader.Start loadingBallPosition es null");
        }
    }

    //Método para spawnear una nueva bola
    public void LoadBall(Ball loadingBall){
        loadingBall.transform.position = loadingBallPosition.position;
    }

}
