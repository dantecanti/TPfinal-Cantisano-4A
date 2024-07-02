using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetosScript : MonoBehaviour
{
    public GameObject[] objetos;
    public int indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < objetos.Length; i++) 
        {
            objetos[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            objetos[indice].SetActive(false);
            indice--;
            if (indice == -1) 
            {
                indice = objetos.Length - 1;
            }
            objetos[indice].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            objetos[indice].SetActive(false);
            indice++;
            if (indice == objetos.Length)
            {
                indice = 0;
            }
            objetos[indice].SetActive(true);
        }
    }
}
