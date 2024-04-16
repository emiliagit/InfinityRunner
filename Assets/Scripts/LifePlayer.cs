using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifePlayer : MonoBehaviour
{

    public GameObject[] ListaCorazones;
    //public List<GameObject> ListaCorazones;
    public Sprite CorazonDesactivado;
    private int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 4;
        //ListaCorazones = new List<GameObject>();
        RestarCorazones(health );
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 100)
        {
            health = 100; //pone limite a la cantidad de vida
        }

        if (health <= 0)
        {
            SceneManager.LoadScene("Derrota");

            Cursor.lockState = CursorLockMode.None;
        }
        RestarCorazones(health);

    }

    public void RestarCorazones(int indice)
    {
        if (indice >= 0/* && indice < ListaCorazones.Length*/)
        {
            GameObject corazon = ListaCorazones[indice];

            Image imagenCorazon = corazon.GetComponent<Image>();

            imagenCorazon.sprite = CorazonDesactivado;
        }
        else
        {
            Debug.Log("lista null");
        }
    }

    public void RecibirDanio(int dmg)
    {
        health -= dmg;
        RestarCorazones(health);
    }

    //public void Curar(int heal)
    //{
    //    hp += heal;
    //    RestarCorazones(hp);
    //}
}
