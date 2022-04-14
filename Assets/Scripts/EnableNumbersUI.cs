using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableNumbersUI : MonoBehaviour
{
    [SerializeField] GameObject numbersUI;
    // Start is called before the first frame update


    private void Start()
    {
        numbersUI.SetActive(false);
    }
    public void ShowNumbers()
    {
        if (numbersUI.activeSelf == false)
        {
            numbersUI.SetActive(true);
        }
        else
        {
            numbersUI.SetActive(false);
        }
    }
}
