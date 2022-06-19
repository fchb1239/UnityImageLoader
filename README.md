# UnityImageSetter
Made for local use instead of the [original web version](https://github.com/fchb1239/UnityImageDownloader)

```cs
private void Awake()
{
  myObject.GetComponent<MeshRenderer>().material.mainTexture = ImageSetter.LoadImage("C:\\ExampleFolder\\ExampleImage.png", FilterMode.Bilinear, 1024, 1024);
}
```
