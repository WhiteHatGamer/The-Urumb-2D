using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //public GameObject player;
    //private Vector3 offset; //For distance between objects
    [SerializeField] private Transform _target;
    [SerializeField] private float _distance=3.0f;
    [SerializeField] private float _up=-2.7f;

    //void Start()
    //{
        ////calculating distance b/w camera and players position
        //offset = transform.position - player.transform.position;
    //}
    void Update()
    {
        transform.position = _target.position - (transform.forward * _distance) + (transform.up * _up) ;
    }
}
