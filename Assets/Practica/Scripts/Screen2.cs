using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Screen2 : MonoBehaviour
{
    public void Main()
    {
        SceneManager.LoadScene(2);
    }

    public void Nueva()
    {
        SceneManager.LoadScene(3);
    }

    public void Cargar()
    {
        SceneManager.LoadScene(4);
    }

    public void Atras()
    {
        SceneManager.LoadScene(0);
    }
}
