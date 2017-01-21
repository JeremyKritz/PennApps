
using UnityEngine;
using System.Collections;

public class BuildArray : MonoBehaviour
{

    private ArrayList Positions = new ArrayList();
    private int count = 0;
    private bool reachesEnd = false;


    void Update()
    {
        if (!reachesEnd && count < 70)
        {
            Positions.Add(transform.position);
            count++;
           // Debug.Log(count);
        }
        else
        {
            reachesEnd = true;
           // Debug.Log("Reached end");
        }

       
        
        if (reachesEnd && count >=0)
        {
            transform.position = (Vector3)Positions[count - 1];
            count--;
        }
       

    }
    }

