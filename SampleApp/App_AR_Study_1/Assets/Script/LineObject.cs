using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineObject : MonoBehaviour
{
    public Transform moving_position;
    public GameObject linePrefab;
    public LineRenderer line;
    public List<LineRenderer> linelist;

    public float time;

    void Start()
    {
        linelist = new List<LineRenderer>();
        GameObject newlineobj = Instantiate(linePrefab); //line�� �������� �����Ͽ� ����ؾ� �ϹǷ� �������� ����
        
        line = newlineobj.GetComponent<LineRenderer>();
        line.positionCount = 1;
        line.SetPosition(0, moving_position.position);
    }

    void Update()
    {
        time += Time.deltaTime;
        
        if(time > 2)
        {
            time = 0;
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, moving_position.position);
        }
    }
}
