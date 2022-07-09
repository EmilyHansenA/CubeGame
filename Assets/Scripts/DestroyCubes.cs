using TMPro;
using UnityEngine;

public class DestroyCubes : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI redCount, blueCount;

    public int redScore = 0;
    public int blueScore = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("redCube") && gameObject.tag.Equals("redWall")) //�������� �� ������������ ������
        {
            redScore++; //���� ���������� "�������" ������� �����
            GameManager.cubeBalance--; //���������� ���������� ���������� �����
            redCount.text = redScore.ToString(); //����� ���������� "�������" ������� �����
            Destroy(collision.gameObject); //�������� ����
        }
        if (collision.gameObject.tag.Equals("blueCube") && gameObject.tag.Equals("blueWall"))
        {
            blueScore++;
            GameManager.cubeBalance--;
            blueCount.text = blueScore.ToString();
            Destroy(collision.gameObject);
        }
    }
}
