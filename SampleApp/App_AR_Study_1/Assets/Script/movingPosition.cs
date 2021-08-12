using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPosition : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 2)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1,
            gameObject.transform.position.y + 2, gameObject.transform.position.z - 1);

            time = 0;
        }
    }
}
