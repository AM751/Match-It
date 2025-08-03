using UnityEngine;
using UnityEngine.InputSystem.UI;

public class ObjectMove : MonoBehaviour
{
    public Vector2 DirectionA;
    public Vector2 DirectionB;

    [SerializeField] public float MoveSpeed;

    private float _movingTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DirectionA = new Vector2 (-7.51f, 0f);
        DirectionB = new Vector2 (7.52f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        _movingTime += Time.deltaTime * MoveSpeed;
        transform.position = Vector2.Lerp (DirectionA, DirectionB, Mathf.PingPong(_movingTime, 1f));
    }
}
