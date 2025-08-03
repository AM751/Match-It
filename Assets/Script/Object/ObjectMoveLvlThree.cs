using UnityEngine;

public class ObjectMoveLvlThree : MonoBehaviour
{
    public Vector2 DirectionA;
    public Vector2 DirectionB;

    [SerializeField] public float MoveSpeed;

    private float _movingTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DirectionA = new Vector2 (-6.64f, 2.03f);
        DirectionB = new Vector2 (8.1f, -5.61f);
    }

    // Update is called once per frame
    void Update()
    {
        _movingTime += Time.deltaTime * MoveSpeed;
        transform.position = Vector2.Lerp (DirectionA, DirectionB, Mathf.PingPong (_movingTime, 1f));
    }
}
 