using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
public GameObject gui_ejemplo1_principal;
public GameObject gui_ejemplo1_cajaBg;
public GameObject gui_ejemplo1_brilloBg;
public GameObject gui_ejemplo1_boton_replay;
public GameObject gui_ejemplo1_boton_next;
public GameObject gui_ejemplo1_estrella1;
public GameObject gui_ejemplo1_estrella2;
public GameObject gui_ejemplo1_estrella3;
public GameObject gui_ejemplo1_puntaje_contenedor;
public GameObject gui_ejemplo1_puntaje_valor;
public GameObject gui_ejemplo1_titulo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




public void BotonInicial(){
    Debug.Log("boton inicial pulsado");
    StartCoroutine(Corutina_PopUp1());
}


    IEnumerator Corutina_PopUp1(){

        gui_ejemplo1_principal.SetActive(true);


        gui_ejemplo1_cajaBg.GetComponent<RectTransform>().localScale = new Vector3(0,0,0);
        gui_ejemplo1_brilloBg.GetComponent<RectTransform>().localScale = new Vector3(0,0,0);

        gui_ejemplo1_estrella1.GetComponent<RectTransform>().localScale = new Vector3(0,0,0);
        gui_ejemplo1_estrella2.GetComponent<RectTransform>().localScale = new Vector3(0,0,0);
        gui_ejemplo1_estrella3.GetComponent<RectTransform>().localScale = new Vector3(0,0,0);
        
        

        yield return new WaitForSeconds(1);
        Debug.Log("Corutina 1 ejecutada 1");

        gui_ejemplo1_cajaBg.GetComponent<RectTransform>().DOScaleX(1, 1f).SetEase(Ease.OutElastic);
        gui_ejemplo1_cajaBg.GetComponent<RectTransform>().DOScaleY(1, 1f).SetEase(Ease.OutElastic);
        gui_ejemplo1_cajaBg.GetComponent<RectTransform>().DOScaleZ(1, 1f).SetEase(Ease.OutElastic);

       // gui_ejemplo1_brilloBg.transform.DORotate(new Vector3(0,0,-1),-1,RotateMode.FastBeyond360);
       gui_ejemplo1_brilloBg.GetComponent<RectTransform>().DOScaleX(1, 1.5f).SetEase(Ease.InBounce);
       gui_ejemplo1_brilloBg.GetComponent<RectTransform>().DOScaleY(1, 1.5f).SetEase(Ease.InBounce);
       gui_ejemplo1_brilloBg.GetComponent<RectTransform>().DOScaleZ(1, 1.5f).SetEase(Ease.InBounce);
       gui_ejemplo1_brilloBg.transform.DORotate( new Vector3(0,0,360),5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
        

        yield return new WaitForSeconds(1);
        Debug.Log("Corutina 1 ejecutada 2");

//presentacion de estrellas
        gui_ejemplo1_estrella1.GetComponent<RectTransform>().DOScaleX(1f,0.5f).SetEase(Ease.OutBounce);
        gui_ejemplo1_estrella1.GetComponent<RectTransform>().DOScaleY(1f,0.5f).SetEase(Ease.OutBounce);
        gui_ejemplo1_estrella1.GetComponent<RectTransform>().DOScaleZ(1f,0.5f).SetEase(Ease.OutBounce);
        yield return new WaitForSeconds(0.5f);
        gui_ejemplo1_estrella2.GetComponent<RectTransform>().DOScaleX(1f,0.5f).SetEase(Ease.OutBounce);
        gui_ejemplo1_estrella2.GetComponent<RectTransform>().DOScaleY(1f,0.5f).SetEase(Ease.OutBounce);
        gui_ejemplo1_estrella2.GetComponent<RectTransform>().DOScaleZ(1f,0.5f).SetEase(Ease.OutBounce);
        yield return new WaitForSeconds(0.5f);
        gui_ejemplo1_estrella3.GetComponent<RectTransform>().DOScaleX(1f,0.5f).SetEase(Ease.OutBounce);
        gui_ejemplo1_estrella3.GetComponent<RectTransform>().DOScaleY(1f,0.5f).SetEase(Ease.OutBounce);
        gui_ejemplo1_estrella3.GetComponent<RectTransform>().DOScaleZ(1f,0.5f).SetEase(Ease.OutBounce);
        yield return new WaitForSeconds(1);


        Debug.Log("Corutina 1 ejecutada 3");

        yield break;
    }
}