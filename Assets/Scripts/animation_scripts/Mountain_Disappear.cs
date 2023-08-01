using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountain_Disappear : MonoBehaviour
{
    [SerializeField] private float fade_speed;

    private SpriteRenderer sprite_renderer;

    private void Start()
    {
        sprite_renderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        StartCoroutine(Hide_Mountains());  
    }

    private IEnumerator Hide_Mountains()
    {
        if (sprite_renderer.color.a < 1)
        {
            yield return new WaitForEndOfFrame();
            sprite_renderer.color = new Color(1, 1, 1, sprite_renderer.color.a - fade_speed);

            StartCoroutine(Hide_Mountains());
        }
        else
            StopAllCoroutines();
    }
}
