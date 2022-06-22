using UnityEngine.UI;
using UnityEngine;

public class scorescripts : MonoBehaviour
{
    public Text score;
    public Text finalscore;
    int sc = 0;
    void Update()
    {
        score.text = sc.ToString();
        finalscore.text = "Score: " + sc.ToString();
    }
    public void Addscore(int s)
    {
        sc = sc + s;
    }
}
