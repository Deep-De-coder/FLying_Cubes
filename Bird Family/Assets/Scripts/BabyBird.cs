using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyBird : MonoBehaviour
{
   public float speed = 0.4f;
    public float rotation_damping = 4f;
    public Transform MamaBird;
    // Start is called before the first frame update
    void Start()
    {
        //only works well with one mamabird
        //MamaBird = GameObject.FindGameObjectWithTag("MamaBird").GetComponent<Transform>();

        GameObject[] MamaBirds = GameObject.FindGameObjectsWithTag("MamaBird");
        int ChosenMamaBird = Random.Range(0, MamaBirds.Length);
        MamaBird = MamaBirds[ChosenMamaBird].GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //Rotate towards mama bird
        var rotation = Quaternion.LookRotation(MamaBird.transform.position - this.transform.position);
        this.transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotation_damping);
        
        //baby bird will follow mama 
        float step = speed * Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(transform.position, MamaBird.position, step);
    }
}
