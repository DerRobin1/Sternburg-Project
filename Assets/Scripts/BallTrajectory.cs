using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallTrajectory : MonoBehaviour
{
    private Scene scenePrediction;
    private PhysicsScene scenePredictionPhysics;
    public Rigidbody prediction;
    public int predictionCycles = 100;
    public GameObject pointTemplate;
    public List<GameObject> point;

    // Start is called before the first frame update
    void Start()
    {
        CreateSceneParameters sceneParam = new CreateSceneParameters(LocalPhysicsMode.Physics3D);
        scenePrediction = SceneManager.CreateScene("PredictionPhysics", sceneParam);
        scenePredictionPhysics = scenePrediction.GetPhysicsScene();
        CreatePoints();
    }

    void CreatePoints()
    {
        point = new List<GameObject>();
        for (int i = 0; i < predictionCycles; i++)
        {
            point.Add(Instantiate(pointTemplate, transform));
        }
    }

    public void Create(Vector3 position, Vector3 force)
    {
        if (!scenePredictionPhysics.IsValid())
            return;

        Clear();
        Rigidbody predictionBall = Instantiate(prediction, position, Quaternion.identity);
        SceneManager.MoveGameObjectToScene(predictionBall.gameObject, scenePrediction);
        predictionBall.AddForce(force);

        for (int i = 0; i < predictionCycles; i++)
        {
            scenePredictionPhysics.Simulate(Time.fixedDeltaTime);
            AddPoint(i, predictionBall.transform.position);
        }
    }

    void AddPoint(int index, Vector3 position)
    {
        point[index].SetActive(true);
        point[index].transform.position = position;
    }

    public void Clear()
    {
        point.ForEach((gobj) =>
        {
            if (gobj.activeInHierarchy) gobj.SetActive(false);
        });
    }
}
