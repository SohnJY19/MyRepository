using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Fruit lastFruit;
    public GameObject fruitPrefab;
    public Transform fruitGroup;

    private void Start()
    {
        NextFruit();
    }
    Fruit GetFruit()
    {
        GameObject instant = Instantiate(fruitPrefab, fruitGroup);
        Fruit instantFruit = instant.GetComponent<Fruit>();
        return instantFruit;
    }

    void NextFruit()
    {
        lastFruit = GetFruit();
        lastFruit.level = Random.Range(0, 10);
        lastFruit.gameObject.SetActive(true);

        StartCoroutine("WaitNext");
    }

    IEnumerator WaitNext()
    {
        while (lastFruit != null)
        {
            yield return new WaitForSeconds(2.5f);

            NextFruit();
        }
    }

        void Update()
        {

        }

        public void TouchDown()
        {
            if (lastFruit == null)
                return;

            lastFruit.Drag(); }

        public void TouchUp()
        {
            if (lastFruit == null)
                return;

            lastFruit.Drop();
            lastFruit = null;
        }
    } 
