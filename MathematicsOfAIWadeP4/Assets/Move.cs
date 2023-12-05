using UnityEngine;

public class Move : MonoBehaviour {

    Vector3 goal = new Vector3(5,0,4);
    public float speed = 0.1f;

    void Start() {

        goal = goal * speed;
    }

    void LateUpdate() 
    {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}
