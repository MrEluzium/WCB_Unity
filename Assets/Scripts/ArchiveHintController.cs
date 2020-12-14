using UnityEngine;
using System.Collections;

public class ArchiveHintController : MonoBehaviour
{
    public Animation anim;

    private void Start()
    {
        Animation anim = GetComponent<Animation>();
    }

    public void MainToArchive()
    {
        anim.Play("ArchiveHintShow");
    }

    public void ArchiveToMain()
    {
        anim.Play("ArchiveHintHide");
    }
}
