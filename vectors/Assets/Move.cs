using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    float speed = 2f;

    void Start() {

        direction = goal.transform.position - this.transform.position;
        
        //this.transform.Translate(direction);
    }

    private void LateUpdate() 
    {
        Vector3 velocity = direction.normalized * speed * Time.deltaTime;
        this.transform.position = this.transform.position + velocity;
    }
}
