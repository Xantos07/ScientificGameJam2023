using System;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private InputReader input;
    private Camera cam;
    private void Start()
    {
        input=GetComponent<InputReader>();
    }

    private void Update()
    {
        //Manager pour selectionner avec un raycast ? 
        Vector3 mousePoisition = cam.ScreenToViewportPoint(Input.mousePosition);

        if(input.Click)
            Debug.Log("Click ! ");
        
        input.Click = false;
    }
}
