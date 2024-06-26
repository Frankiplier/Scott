using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    
    public float fadeDuration = 2.0f;
    private SpriteRenderer spriteRenderer;
    private Color spriteColor;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteColor = spriteRenderer.color;
        spriteColor.a = 0;
        spriteRenderer.color = spriteColor;
        StartCoroutine(FadeInSprite());
    }

    IEnumerator FadeInSprite()
    {
        float elapsedTime = 0;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Clamp01(elapsedTime / fadeDuration);
            spriteColor.a = alpha;
            spriteRenderer.color = spriteColor;
            yield return null;
        }
        spriteColor.a = 1;
        spriteRenderer.color = spriteColor;
    }
}
