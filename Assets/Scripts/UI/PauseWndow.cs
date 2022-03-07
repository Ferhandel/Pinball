using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseWndow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnEnable() {
        Time.timeScale = 0;
    }

    public void ButtonContinuarOnClick() {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }            

    public void ButtonReiniciarOnClick() {
        Debug.Log("Pulsado el botón Reiniciar");
        GameManager.Reiniciar();
        ButtonContinuarOnClick();
    }

    
    public void ButtonVolverOnClick() {
        Debug.Log("Pulsado el botón Volver");
    }

}
