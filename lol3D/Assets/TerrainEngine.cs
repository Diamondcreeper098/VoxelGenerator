using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainEngine : MonoBehaviour {
    GameObject terrainEngine;//Parent object
	// Use this for initialization
	void Start () {
        terrainEngine = this.gameObject;
        int a = 8;//number of blocks a*a
        GameObject[] Blocks = new GameObject[a*a];//Blocks Array
        System.Random random = new System.Random();//Making a random number generator for Terrain Generation
        for (int i = 0; i < a; i++)//rows
        {
            for (int j = 0; j < a; j++)//columns
            {
                
                GameObject tmpobj = GameObject.CreatePrimitive(PrimitiveType.Cube);//Making a temporary object with cube shape
                tmpobj.transform.position = new Vector3(j, random.Next(2,4), i);// Giving temporary object postion
                if (j % 2 == 0)//Even number
                {
                    Blocks[i] = tmpobj;//Assigning tmpobj to i index of blocks
                    Blocks[i].transform.parent = terrainEngine.transform; //Childing Block to terrainengine
                    Blocks[i].transform.localScale = new Vector3(1,1,1);// giving block size
                }
                else{//odd number
                    int tt = i + a;
                    Blocks[tt] = tmpobj;//Assigning tmpobj to i index of blocks
                    Blocks[tt].transform.parent = terrainEngine.transform;//Childing Block to terrainengine
                    Blocks[tt].transform.localScale = new Vector3(1, 1, 1);// giving block size
                }

                tmpobj = null;//Clearing temporary object of memory
            }

            //GameObject.CreatePrimitive(PrimitiveType.Cube).transform.parent = terrainEngine.transform;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
