using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words={"Cat","Dog","Car","Pizza","Hat","Fish","Tree","Monkey","Ball","Bird"};
        int word_counter=0;
        string sentence = "";
        while(word_counter<7){
            word_counter++;
            int random_number= Random.Range(0,9);
            Debug.Log(words[random_number]);
            sentence += words[random_number] +" ";
        }
        Debug.Log(sentence);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
