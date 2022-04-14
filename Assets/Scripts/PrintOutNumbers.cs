using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintOutNumbers : MonoBehaviour
{

    [SerializeField] Text text;
    // Start is called before the first frame update
    void Start()
    {
        printNumbers();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void printNumbers()
    {
        //int[] i;
        //i = new int[101];
        //for(int n = 0; n<101; n++)
        //{
        //    i[n] = n;
        //    foreach (var number in i)
        //    {
        //        text.text = text.text + i[n].ToString();
        //    }
        //}

        for (int i = 1; i < 101; i++)
        {
            if (i % 3 == 0 && i% 5!=0)
            {
                text.text = text.text + " " + i + " Marco ";
            }
            else if(i % 5 == 0 && i%3!=0)
            {
                text.text = text.text + " " + i + " Polo ";
            }
            else if(i%3 ==0 && i%5==0)
            {
                text.text = text.text + " " + i + " Marco Polo ";
            }
            else
            {
                text.text = text.text + " " + i + " ";
            }


        }
    }
}