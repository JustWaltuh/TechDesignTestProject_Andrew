using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountain_Disappear : MonoBehaviour
{
    [SerializeField] private float fade_speed;

    private SpriteRenderer button_image;

    private void Start()
    {
        button_image = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        StartCoroutine(Hide_Mountains());
    }

    private IEnumerator Hide_Mountains()
    {
        if (button_image.color.a > 0)
        {
            yield return new WaitForEndOfFrame();
            button_image.color = new Color(1, 1, 1, button_image.color.a - fade_speed);

            StartCoroutine(Hide_Mountains());
        }
        else
            StopAllCoroutines();
    }
}
