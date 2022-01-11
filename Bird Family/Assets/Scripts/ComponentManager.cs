using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ComponentManager : MonoBehaviour
{
    public Toggle BirdToggle;
    public GameObject MamaBirdPrefab;
    public GameObject BabyBirdPrefab;
    private GameObject SpawneBird;
    public Camera ARCamera;
    
    private List<RaycastResult> raycastResults = new List<RaycastResult>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Down");
            Ray ray = ARCamera.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);

            if (IsPointerOverUI(Input.mousePosition))
            {
                Debug.Log("Do Nothing");
            }
            else
            {
                SpawneBird = Instantiate(WhichBird(), ray.origin, Quaternion.identity);
                SpawneBird.GetComponent<Rigidbody>().AddForce(ray.direction * 100);
            }

           
        } 
    }
    public GameObject WhichBird()
    {
        if(BirdToggle.isOn)
        {
            return MamaBirdPrefab;
        }
        else
        {
            return BabyBirdPrefab;
        } 
    }

    private bool IsPointerOverUI(Vector2 fingerPosition)
    {
        PointerEventData eventDataPosition = new PointerEventData(EventSystem.current);
        eventDataPosition.position = fingerPosition;
        EventSystem.current.RaycastAll(eventDataPosition, raycastResults);
        return raycastResults.Count > 0; //if greater than 0, that means we hit UI element 
    }
}

