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
        DirectionA = new Vector2 (-9.11f, -0.04f);
        DirectionB = new Vector2 (9.16f, -0.04f);
    }

    // Update is called once per frame
    void Update()
    {
        _movingTime += Time.deltaTime * MoveSpeed;
        transform.position = Vector2.Lerp (DirectionA, DirectionB, Mathf.PingPong(_movingTime, 1f));
    }
}
