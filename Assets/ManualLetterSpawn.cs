using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualLetterSpawn : MonoBehaviour
{
    //VARIABLES
    public GameObject letterPrefab;
    private SpriteRenderer letterSpriteRenderer;
    public Sprite[] letters;
    void Start()
    {
        letterSpriteRenderer = letterPrefab.GetComponent<SpriteRenderer>();
    }
    public void Q()
    {
        letterSpriteRenderer.sprite = letters[16];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void W()
    {
        letterSpriteRenderer.sprite = letters[22];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void E()
    {
        letterSpriteRenderer.sprite = letters[4];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void R()
    {
        letterSpriteRenderer.sprite = letters[17];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void T()
    {
        letterSpriteRenderer.sprite = letters[19];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void Y()
    {
        letterSpriteRenderer.sprite = letters[24];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void U()
    {
        letterSpriteRenderer.sprite = letters[20];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void I()
    {
        letterSpriteRenderer.sprite = letters[8];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }public void O()
    {
        letterSpriteRenderer.sprite = letters[14];
        Instantiate(letterPrefab, new Vector2(0, 5),Quaternion.identity);
    }
    public void P()
    {
        letterSpriteRenderer.sprite = letters[15];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void A()
    {
        letterSpriteRenderer.sprite = letters[0];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void S()
    {
        letterSpriteRenderer.sprite = letters[18];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void D()
    {
        letterSpriteRenderer.sprite = letters[3];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void F()
    {
        letterSpriteRenderer.sprite = letters[5];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void G()
    {
        letterSpriteRenderer.sprite = letters[6];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void H()
    {
        letterSpriteRenderer.sprite = letters[7];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void J()
    {
        letterSpriteRenderer.sprite = letters[9];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void K()
    {
        letterSpriteRenderer.sprite = letters[10];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void L()
    {
        letterSpriteRenderer.sprite = letters[11];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void Z()
    {
        letterSpriteRenderer.sprite = letters[25];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void X()
    {
        letterSpriteRenderer.sprite = letters[23];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void C()
    {
        letterSpriteRenderer.sprite = letters[2];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void V()
    {
        letterSpriteRenderer.sprite = letters[21];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void B()
    {
        letterSpriteRenderer.sprite = letters[1];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void N()
    {
        letterSpriteRenderer.sprite = letters[13];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    public void M()
    {
        letterSpriteRenderer.sprite = letters[12];
        Instantiate(letterPrefab, new Vector2(0, 5), Quaternion.identity);
    }
    void Update()
    {
        
    }

}
