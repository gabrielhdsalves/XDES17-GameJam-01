using UnityEngine;
using System.Collections.Generic;

public class MoveBackground : MonoBehaviour
{
    private SpriteRenderer[] renderers;
    [SerializeField] float speed = 0.2f;
    private float offsetX = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        renderers = GetComponentsInChildren<SpriteRenderer>(true);
    }

    // Update is called once per frame
    void Update()
    {
        offsetX += speed * Time.deltaTime;
        foreach (SpriteRenderer childrens in renderers)
        {
            childrens.material.mainTextureOffset = new Vector2(offsetX, 0);
        }
    }
}
