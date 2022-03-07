using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float limiteMesa;
    Vector3 initPosition;
    // Start is called before the first frame update
    void Start()
    {
        initPosition = transform.position;
        GameManager.registrarBola(this);
    }

    // Update is called once per frame
    void Update()
    {
        ComprobarBolaPerdida();
    }


    private void ComprobarBolaPerdida() {
        if (transform.position.z < limiteMesa) {
            GameManager.perderBola(this);
            gameObject.SetActive(false);
        }

    }

    public void Reiniciar() {
        transform.position = initPosition;
        gameObject.SetActive(true);
    }
}
