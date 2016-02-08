using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    // Use this for initialization

    static GameManager instance;
    public GameObject Enemigo;
    public static GameManager Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        //Asigna esta instancia al campo instance
        if (instance == null)
            instance = this;
        else
            Destroy(this);  //Garantiza que sólo haya una instancia de esta clase
    }

    private List<GameObject> enemigos=new List<GameObject>();

    void Start () {
        crearEnemigo();
        
    }
	
	// Update is called once per frame
	public void crearEnemigo()
    {
        

        GameObject aux=Instantiate(Enemigo, new Vector3(transform.position.x+generarplano(), transform.position.y+ generarplano(), transform.position.z-0.55f), Quaternion.identity)as GameObject;
        
        enemigos.Add(aux);
    }

    public float generarplano()
    {
        float a=0;  

        if (Random.Range(1, 4) == 1)
            a =-0.33f;
        if (Random.Range(1, 4) == 2)
            a =0f;
        if (Random.Range(1, 4) == 3)
            a =0.33f;
        return a;
    }
}
