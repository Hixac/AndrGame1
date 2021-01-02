using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFeature : MonoBehaviour
{
    public GameObject hero;
    SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (GetComponentInChildren<HPCalc>() != null)
        {
            HPCalc = GetComponentInChildren<HPCalc>();
        }
    }
    HPCalc HPCalc;
    private void OnMouseDown()
    {
        if (HPCalc != null)
        {
            HPCalc.EnemyCalc();
        }

        transform.localScale = new Vector2(0.50f, 0.60f);
        spriteRenderer.color = new Color(0.93f, 0.93f, 0.93f);
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector2(0.46f, 0.56f);
        spriteRenderer.color = new Color(1, 1, 1);
    }
    private void OnMouseOver()
    {
        spriteRenderer.color = new Color(0.97f, 0.97f, 0.97f);
    }
    private void OnMouseExit()
    {
        spriteRenderer.color = new Color(1, 1, 1);
    }
}
