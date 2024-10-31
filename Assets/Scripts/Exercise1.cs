using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter=0;
        while(counter<20){
            counter++;
            int random_number= Random.Range(1,20);
            if(random_number==5) continue;
            Debug.Log(random_number);
            if(random_number==15){
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
