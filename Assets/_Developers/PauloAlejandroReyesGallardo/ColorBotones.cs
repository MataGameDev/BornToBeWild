using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorBotones : MonoBehaviour
{
    public GameObject[] BiomeButtons;
    public GameObject[] bosqueButtons;
    public GameObject[] desiertoButtons;
    public GameObject[] selvaButtons;

    public void biomeColorChange(GameObject boton)
    {
        foreach (GameObject button in BiomeButtons)
        {
            if (button != boton) {
                Button b = button.GetComponent<Button>();
                ColorBlock cb = b.colors;
                cb.normalColor = new Color(0,0,0,0.5f);
                b.colors = cb;
            }

            Button a = boton.GetComponent<Button>();
            ColorBlock ca = a.colors;
            ca.normalColor = new Color(0, 0, 0, 1);
            a.colors = ca;
        }
    }
    public void bosqueColorChange(GameObject boton)
    {
        foreach (GameObject button in bosqueButtons)
        {
            if (button != boton)
            {
                Button b = button.GetComponent<Button>();
                ColorBlock cb = b.colors;
                cb.normalColor = new Color(0, 0, 0, 0.5f);
                b.colors = cb;
            }

            Button a = boton.GetComponent<Button>();
            ColorBlock ca = a.colors;
            ca.normalColor = new Color(0, 0, 0, 1);
            a.colors = ca;
        }
    }

    public void desiertoColorChange(GameObject boton)
    {
        foreach (GameObject button in desiertoButtons)
        {
            if (button != boton)
            {
                Button b = button.GetComponent<Button>();
                ColorBlock cb = b.colors;
                cb.normalColor = new Color(0, 0, 0, 0.5f);
                b.colors = cb;
            }

            Button a = boton.GetComponent<Button>();
            ColorBlock ca = a.colors;
            ca.normalColor = new Color(0, 0, 0, 1);
            a.colors = ca;
        }
    }

    public void selvaColorChange(GameObject boton)
    {
        foreach (GameObject button in selvaButtons)
        {
            if (button != boton)
            {
                Button b = button.GetComponent<Button>();
                ColorBlock cb = b.colors;
                cb.normalColor = new Color(0, 0, 0, 0.5f);
                b.colors = cb;
            }

            Button a = boton.GetComponent<Button>();
            ColorBlock ca = a.colors;
            ca.normalColor = new Color(0, 0, 0, 1);
            a.colors = ca;
        }
    }
}
