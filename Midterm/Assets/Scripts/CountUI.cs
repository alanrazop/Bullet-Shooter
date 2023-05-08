using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountUI: MonoBehaviour
{
    public TextMeshProUGUI bulletText;

    void Update()
    {
        bulletText.text = $"{BulletGenerator.bulletCount.ToString()} bullets";
    }
}
