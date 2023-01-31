using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverScaleScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 bigScale;
    private Transform scroll;
    private Transform canvas;
    private Vector3 smallScale;
    // Start is called before the first frame update
    void Start()
    {
        smallScale = gameObject.GetComponent<RectTransform>().localScale;
        bigScale = gameObject.GetComponent<RectTransform>().localScale * 2;
        scroll = gameObject.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale = smallScale;
    }

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.GetComponent<RectTransform>().sizeDelta *= 2;
        gameObject.transform.SetParent(null,true);
        Debug.Log("aids");
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        //gameObject.transform.SetParent(scroll,true);
        //gameObject.GetComponent<RectTransform>().sizeDelta /= 2;
        Debug.Log("weg aids");
    }
}
