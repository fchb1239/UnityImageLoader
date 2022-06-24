using System.IO;
using UnityEngine;

namespace UnityImageSetter
{
    public class ImageSetter
    {
        /// <summary>
        /// Converts an image file to a Texture2D
        /// </summary>
        /// <param name="fileLocation">The file location of the image</param>
        /// <param name="filterMode">The filter mode, this can be Point, Bilinear or Trilinear</param>
        /// <param name="width">The amount of pixels for the width</param>
        /// <param name="height">The amount of pixels for the height</param>
        /// <returns>Texture2D</returns>
        public static Texture2D LoadImage(string fileLocation, FilterMode filterMode, int width, int height)
        {
            Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);
            tex.filterMode = filterMode;

            byte[] bytes = File.ReadAllBytes(fileLocation);
            tex.LoadImage(bytes);
            tex.Apply();

            return tex;
        }
    }
}

/*
MIT License

Copyright (c) 2022 fchb1239

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
