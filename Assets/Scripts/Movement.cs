using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;
    public static bool move;
    public static int rest = 0;

    // Use this for initialization
    void Start () {

        target = Waypoints.points[0];
        move = true;
	}

    // Update is called once per frame
    void Update() { 
      if (move) { 
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
                //rest--;
            GetNextWaypoint();
        }
      }
	}

    void GetNextWaypoint()
    {
        //if (rest == 0)
        //{
          //  move = false;
            //return;
        //}
        if(wavepointIndex >= Waypoints.points.Length-1)
        {
            wavepointIndex = 0;
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

}
