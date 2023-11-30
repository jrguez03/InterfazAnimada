using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen1 : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI titulo;
    [SerializeField]
    TextMeshProUGUI inicio;

    float duraciontotal = 1f;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }
    }

    private void Start()
    {
        Parpadeo();
        LeanTween.moveX(titulo.GetComponent<RectTransform>(), 0, 1.5f).setDelay(1.5f);
    }

    private void Parpadeo()
    {
        LeanTween.value(gameObject, 0f, 1f, duraciontotal / 2)
        .setEase(LeanTweenType.easeInOutSine)
        .setOnUpdate((float value) =>
        {
            Color color = inicio.color;
            color.a = value;
            inicio.color = color;
        })
            .setOnComplete(() =>
            {
                // Cuando la primera mitad del parpadeo ha terminado, invierte el proceso para la segunda mitad
                LeanTween.value(gameObject, 1f, 0f, duraciontotal / 2)
                    .setEase(LeanTweenType.easeInOutSine)
                    .setOnUpdate((float value) =>
                    {
                        // Actualiza el componente de color del GameObject con el nuevo valor de alpha
                        Color color = inicio.color;
                        color.a = value;
                        inicio.color = color;
                    })
                    .setOnComplete(() =>
                    {
                        // Llama recursivamente a la función para iniciar el siguiente parpadeo
                        Parpadeo();
                    });
            });
    }
}
