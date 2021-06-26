using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPositonText : MonoBehaviour
{

    public Text cameraText;
    public Text lineText;
    public GameObject cameraObj;
    public GameObject lineObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lineText.text = "line x : " + lineObj.transform.position.x + " y : " + lineObj.transform.position.y + " z : " + lineObj.transform.position.z;
        cameraText.text = "camera x : " + cameraObj.transform.position.x + " y : " + cameraObj.transform.position.y + " z : " + cameraObj.transform.position.z;
    }
}
