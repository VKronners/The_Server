using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TamanhoDoJogo
{
    Pequeno = 30,
    Medio = 60,
    Grande = 90,
    Colossal = 300,
}
public enum EspacamentoDosNodos
{
    Pequeno = 15,
    Medio = 20,
    Grande = 25,
    Colossal = 30
}

public class SpawnLittleNodes : MonoBehaviour {

    DrawLines drawLines;

    public GameObject prefabLittleNode;
    public GameObject mainNode;

    [SerializeField]
    EspacamentoDosNodos espacamentoDosNodos;
    [SerializeField]
    TamanhoDoJogo tamanhoDoJogo;
 
    Vector3 posicaoNoMundoLittleNode;

    Transform NodoPai;

    void Start () {

        NodoPai = GameObject.Find("Nodo Pai").GetComponent<Transform>();
        drawLines = this.gameObject.GetComponent<DrawLines>();

        for (int i = 0; i < (int)tamanhoDoJogo; i++)
        {
            posicaoNoMundoLittleNode = Random.insideUnitSphere * (int)espacamentoDosNodos;

            if (Vector3.Distance(posicaoNoMundoLittleNode, mainNode.transform.position) <= 4)
            {
                posicaoNoMundoLittleNode = Random.insideUnitSphere * (int)espacamentoDosNodos;
            }
            else
            {
                drawLines.allNodes.Add(Instantiate(prefabLittleNode, posicaoNoMundoLittleNode, Quaternion.identity, NodoPai));
            }
            if (i == (int)tamanhoDoJogo)
            {
                for (i = 0; i < (int)tamanhoDoJogo; i++) {
                    //float distancia = Vector3.Distance(Nodos.transform.position, drawLines.allNodes[i].transform.position;
                }
            }
            if (prefabLittleNode.GetComponent<DrawLines>() == null)
            {
                prefabLittleNode.AddComponent<DrawLines>();
            }

        }
    }
	
	void Update () {
		
	}
}
