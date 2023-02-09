public class PopItItem : Item
{
    protected override void OnMouseDown()
    {
        var unused = transform.GetChild(0);
        unused.gameObject.SetActive(
            !unused
            .gameObject
            .activeSelf);
    }
}
