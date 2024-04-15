using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifePlayer : MonoBehaviour
{

    public List<GameObject> ListaCorazones;
    public Sprite CorazonDesactivado;
    private int hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = 4;
        RestarCorazones(hp);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp > 100)
        {
            hp = 100; //pone limite a la cantidad de vida
        }

        if (hp <= 0)
        {
            SceneManager.LoadScene("Derrota");

            Cursor.lockState = CursorLockMode.None;
        }
        RestarCorazones(hp);

    }

    public void RestarCorazones(int indice)
    {
        Image imagenCorazon = ListaCorazones[indice].GetComponent<Image>();
        imagenCorazon.sprite = CorazonDesactivado;
    }

    public void RecibirDanio(int dmg)
    {
        hp -= dmg;
        RestarCorazones(hp);
    }

    //public void Curar(int heal)
    //{
    //    hp += heal;
    //    RestarCorazones(hp);
    //}
}
