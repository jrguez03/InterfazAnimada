using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screenshop : MonoBehaviour
{
    public void Shop()
    {
        SceneManager.LoadScene(5);
    }

    public void Atras()
    {
        SceneManager.LoadScene(1);
    }
}
