using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    int indice = -1;
    public GameObject[] objetos;
    // Start is called before the first frame update
    void Start()
    {
        ALL_desactivate();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Pasar();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            atras();
        }
    }

    void ALL_desactivate()
    {
        foreach (GameObject objeto in objetos)
        {
            objeto.gameObject.SetActive(false);
        }
    }

    void Pasar()
    {
        ALL_desactivate();
        indice++;
        if (indice == objetos.Length)
        {
            indice = 0;
        }
        objetos[indice].gameObject.SetActive(true);
    }
    void atras()
    {
        ALL_desactivate();
        indice--;
        if (indice < 0)
        {
            indice = objetos.Length - 1;
        }
        objetos[indice].gameObject.SetActive(true);
    }
}
